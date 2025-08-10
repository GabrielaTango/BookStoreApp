using BL;
using DAL.Repositories;
using Models;
using Models.FacturaElectronica;
using System.ComponentModel;
using System.Globalization;
using UI.Entities;

namespace UI.Procesos
{
    public partial class FrmFacturador : FrmUtil
    {

        FacturaService FeService = new();

        int numero = 0;
        string ptoVta = "13";
        TipoComprobanteAfip _tipoComprobante;

        Cliente cliente;

        BindingList<Detalle> detalle = new BindingList<Detalle>();

        private readonly Service<ClienteRepository, Cliente> _cliService = new Service<ClienteRepository, Cliente>();
        private readonly Service<ComprobanteRepository, Comprobante> _compService = new Service<ComprobanteRepository, Comprobante>();
        private readonly Service<ComprobanteDetalleRepository, ComprobanteDetalle> _compDetalleService = new Service<ComprobanteDetalleRepository, ComprobanteDetalle>();


        QueryService clientesQuery = new QueryService("clientes");
        public FrmFacturador(TipoComprobanteAfip tc)
        {
            InitializeComponent();
            _tipoComprobante = tc;
        }

        #region Eventos
        private void panel1_Resize(object sender, EventArgs e)
        {
            CentrarTitulo();
        }

        private void FrmFacturador_Load(object sender, EventArgs e)
        {
            if (_tipoComprobante == TipoComprobanteAfip.FacturaC)
                lblComprobante.Text = "Factura";

            if (_tipoComprobante == TipoComprobanteAfip.NotaCreditoC)
                lblComprobante.Text = "Nota de Credito";

            lblTotal.Text = "0.00";

            FeService.ObtenerTA();
            FeService.UltimoComp();
            numero = FeService.GetProximo();

            CargarCombo(cmbVendedor, "vendedores");
            CargarCombo(cmbListas, "listas");

            CentrarTitulo();

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtNumeroComprobante.Text = GenerarNroComprobante();

            dgvDetalles.DataSource = detalle;
            SetColumnDecimalFormat("Cantidad");
            SetColumnDecimalFormat("Precio");
            SetColumnDecimalFormat("Importe");
        }

        private void FrmFacturador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.A)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                CargarArticulo();
            }

            if (e.KeyCode == Keys.C)
            {
                CargarCliente();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var comprobante = new Comprobante();
                List<ComprobanteDetalle> detalles = new List<ComprobanteDetalle>();

                SetComprobante(comprobante);
                SetDetalles(detalles);

                FECAEDetRequest compArca = new FECAEDetRequest
                {
                    Concepto = 1,
                    DocTipo = int.Parse(cliente.TipoDocArca),
                    DocNro = long.Parse(cliente.NroDocumento),
                    CbteDesde = numero,
                    CbteHasta = numero,
                    CbteFch = DateTime.Now.ToString("yyyyMMdd"),
                    ImpTotal = detalle.Sum(x => x.Importe),
                    ImpNeto = detalle.Sum(x => x.Importe),
                    ImpIVA = 0.00m,
                    MonId = "PES",
                    MonCotiz = 1.000m,
                    CondicionIVAReceptorId = 5
                };
                var msg = FeService.Facturar(compArca);

                if (string.IsNullOrEmpty(msg.Error))
                {
                    comprobante.CAE = msg.CAE;
                    comprobante.VTO = msg.VTO;
                    int idFactura = _compService.Guardar(comprobante);
                    if (idFactura > 0)
                    {
                        foreach (var det in detalles)
                        {
                            det.FacturaId = idFactura;
                            _compDetalleService.Guardar(det);
                        }
                        ComprobantePDFGenerator.GenerarComprobantePDF(comprobante, detalles, "");
                    }

                    MessageBox.Show($"Comprobante Realizado {comprobante.NumeroComprobante}");
                    this.Dispose();
                }

            }
        }
        
        private void dgvDetalles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarArticulo();
        }

        private void lblTotalTittle_Click(object sender, EventArgs e)
        {

        }

        private void txtParaCuotas_ValueChanged(object sender, EventArgs e)
        {
            CalcularCuota();
        }

        private void txtParaCuotas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, num.Text.Length);
        }
        #endregion

        #region Metodos
        private void CalcularCuota()
        {
            var subtotal = detalle.Sum(x => x.Importe);

            lblTotal.Text = subtotal.ToString("N2", CultureInfo.GetCultureInfo("en-US"));

            var AFinanciar = subtotal - txtAnticipo.Value;

            txtValorCuota.Value = AFinanciar / txtCuotas.Value;
        }

        private void CargarArticulo()
        {
            if(cmbListas.SelectedIndex < 1)
            {
                MessageWarning("Cuidado", "Debe seleccionar uan lista");
                return;
            }
            int lista = (int)cmbListas.SelectedValue;

            FrmAgregarArticulo fArticulo = new FrmAgregarArticulo(lista);
            if (fArticulo.ShowDialog() == DialogResult.OK)
            {
                fArticulo.detalle.Renglon = detalle.Count + 1;
                detalle.Add(fArticulo.detalle);
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            CalcularCuota();
        }

        private void SetDetalles(List<ComprobanteDetalle> detalles)
        {
            foreach (var d in detalle)
            {
                detalles.Add(new ComprobanteDetalle()
                {
                    ArticuloId = d.Id,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.Precio,
                    Subtotal = d.Importe,
                    Descripcion = d.Descripcion
                });
            }
        }

        private void SetComprobante(Comprobante comprobante)
        {
            comprobante.TipoComprobante = "FAC";
            comprobante.Total = detalle.Sum(x => x.Importe);
            comprobante.Fecha = DateTime.Now;
            comprobante.NumeroComprobante = GenerarNroComprobante();
            comprobante.ClienteId = cliente.Id;
        }

        private string GenerarNroComprobante()
        {
            return $"C{ptoVta.PadLeft(5, '0')}{numero.ToString().PadLeft(8, '0')}";
        }

        private bool Validar()
        {
            bool valido = true;

            if (cliente == null)
            {
                MessageBox.Show("Debe ingresar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            if (detalle.Count < 1)
            {
                MessageBox.Show("Debe ingresar al menos un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valido = false;
            }

            return valido;
        }

        private void ModificarArticulo()
        {
            if (dgvDetalles.SelectedRows.Count == 1)
            {
                int renglon = (int)dgvDetalles.SelectedRows[0].Cells["Renglon"].Value;
                var articulo = detalle.First(x => x.Renglon == renglon);
                FrmAgregarArticulo fArticulo = new FrmAgregarArticulo(0);
                fArticulo.detalle = articulo;
                if (fArticulo.ShowDialog() == DialogResult.OK)
                    dgvDetalles.Refresh();
                CalcularTotales();

            }
        }

        private void SetColumnDecimalFormat(string column)
        {
            dgvDetalles.Columns[column].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dgvDetalles.Columns[column].DefaultCellStyle.Format = "N2";
        }

        private void CargarCliente()
        {
            FrmBuscar fBuscar = new FrmBuscar(clientesQuery);

            if (fBuscar.ShowDialog() == DialogResult.OK)
            {
                cliente = _cliService.GetById(fBuscar.id);
                txtCodigo.Text = cliente.Codigo;
                txtNroDocumento.Text = cliente.NroDocumento;
                txtDomicilioComercial.Text = cliente.DomicilioComercial;
                txtDomicilioParticular.Text = cliente.DomicilioParticular;
                txtNombreCliente.Text = cliente.Nombre;

                cmbVendedor.SelectedValue = cliente.Vendedor_Id;
            }
        }

        private void CentrarTitulo()
        {
            lblComprobante.Left = (panel1.Width - lblComprobante.Width) / 2;
            lblComprobante.Top = (panel1.Height - lblComprobante.Height) / 2;
        }
        #endregion
    }
}
