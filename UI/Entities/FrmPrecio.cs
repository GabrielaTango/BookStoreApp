using BL;
using DAL.Repositories;
using Models;
using UI.Procesos;

namespace UI.Entities
{
    public partial class FrmPrecio : FrmUtil
    {
        IService<Articulo> _service = new Service<ArticuloRepository, Articulo>();
        PrecioService _precioService = new PrecioService();
        Precio _precio;
        public FrmPrecio(Precio p)
        {
            InitializeComponent();
            _precio = p;
        }

        private void FrmPrecio_Load(object sender, EventArgs e)
        {
            if (_precio.Id > 0)
            { 
                this.Text = "Modificación";
                GetInfoObjeto();
                button1.Enabled = false;
            }
            else
                BuscarArticulo();
        }

        private void BuscarArticulo()
        {
            FrmBuscar fBuscar = new FrmBuscar(new QueryService("articulos"));
            if (fBuscar.ShowDialog() == DialogResult.OK)
            {
                var articulo = _service.GetById(fBuscar.id);
                _precio.Articulo_Id = articulo.Id;
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripcion;
                SendKeys.Send("{TAB}");
            }
        }
        public Precio GetPrecio()
        {
            return _precio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, num.Text.Length);
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GetInfoControl();
                if(_precio.Id > 0)
                    _precioService.Actualizar(_precio);
                else
                    _precioService.Guardar(_precio);

                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void GetInfoObjeto()
        {
            txtPrecio.Value = _precio.Importe.GetValueOrDefault();
            txtCodigo.Text = _precio.Codigo;
            txtDescripcion.Text = _precio.Descripcion;
        }

        private void GetInfoControl()
        {
            _precio.Importe = txtPrecio.Value;
        }

        private bool Validar()
        {
            if (_precio.Id < 1 && _precioService.Existe(_precio))
            {
                MessageWarning("Cuidado", "Precio Existe");
                return false;
            }
            return true;
        }
    }
}
