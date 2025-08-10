using BL;
using DAL.Repositories;
using Models;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Entities;

namespace UI
{
    public partial class FrmCliente : FrmUtil
    {
        private readonly Service<ClienteRepository, Cliente> _service = new Service<ClienteRepository, Cliente>();

        Cliente cliente;

        int _id;
        public FrmCliente(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            CargarCombos();

            if (_id > 0)
            {
                cliente = _service.GetById(_id);
                CargarClienteEnFormulario();
            }

        }

        private void CargarClienteEnFormulario()
        {
            txtCodigo.Text = cliente.Codigo;
            txtNombre.Text = cliente.Nombre;
            cmbZona.SelectedValue = cliente.Zona_Id ?? -1;
            cmbVendedor.SelectedValue = cliente.Vendedor_Id ?? -1;
            cmbSubZona.SelectedValue = cliente.SubZona_Id ?? -1;
            txtDomComercial.Text = cliente.DomicilioComercial;
            txtDomParticular.Text = cliente.DomicilioParticular;
            cmbProvincia.SelectedValue = cliente.Provincia_Id ?? -1;
            txtCodigoPostal.Text = cliente.CodigoPostal;
            dtpFechaAlta.Value = cliente.FechaAlta;

            if (cliente.FechaInha.HasValue)
            {
                dtpFechaInha.Value = cliente.FechaInha.Value;
                dtpFechaInha.Checked = true;
            }
            else
            {
                dtpFechaInha.Checked = false;
            }

            chkSoloContado.Checked = cliente.SoloContado;
            txtTelefono.Text = cliente.Telefono;
            txtTelefonoMovil.Text = cliente.TelefonoMovil;
            txtEmail.Text = cliente.EMail;
            txtContacto.Text = cliente.Contacto;
            cmbTipoDoc.Text = cliente.TipoDocumento;
            txtNroDoc.Text = cliente.NroDocumento;
            txtIIBB.Text = cliente.NroIIBB;
            cmbCategoriaIva.Text = cliente.CategoriaIva;
            cmbCondicionPago.Text = cliente.CondicionPago;
            nudDescuento.Value = cliente.Descuento ?? 0;
            txtObservaciones.Text = cliente.Observaciones;
        }

        private void CargarCombos()
        {
            CargarCombo(cmbZona, "zonas");
            CargarCombo(cmbProvincia, "provincias");
            CargarCombo(cmbSubZona, "subzonas");
            CargarCombo(cmbTipoDoc, "tipodocumento");
            CargarCombo(cmbVendedor, "vendedores");
            CargarCombo(cmbCondicionPago, "condicionVenta");
        }

        private Cliente LeerFormularioACliente()
        {
            var c = new Cliente
            {
                Id = _id,
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),

                Zona_Id = cmbZona.SelectedIndex > 0 ? (int?)Convert.ToInt32(cmbZona.SelectedValue) : null,
                SubZona_Id = cmbSubZona.SelectedIndex > 0 ? (int?)Convert.ToInt32(cmbSubZona.SelectedValue) : null,

                Vendedor_Id = cmbVendedor.SelectedIndex > 0 ? (int?)Convert.ToInt32(cmbVendedor.SelectedValue) : null,

                DomicilioComercial = string.IsNullOrWhiteSpace(txtDomComercial.Text) ? null : txtDomComercial.Text.Trim(),
                DomicilioParticular = string.IsNullOrWhiteSpace(txtDomParticular.Text) ? null : txtDomParticular.Text.Trim(),

                Provincia_Id = cmbProvincia.SelectedIndex > 0 ? (int?)Convert.ToInt32(cmbProvincia.SelectedValue) : null,
                CodigoPostal = string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ? null : txtCodigoPostal.Text.Trim(),

                FechaAlta = dtpFechaAlta.Value,
                FechaInha = dtpFechaInha.Checked ? dtpFechaInha.Value : (DateTime?)null,

                SoloContado = chkSoloContado.Checked,

                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                TelefonoMovil = string.IsNullOrWhiteSpace(txtTelefonoMovil.Text) ? null : txtTelefonoMovil.Text.Trim(),

                EMail = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Contacto = string.IsNullOrWhiteSpace(txtContacto.Text) ? null : txtContacto.Text.Trim(),

                NroDocumento = string.IsNullOrWhiteSpace(txtNroDoc.Text) ? null : txtNroDoc.Text.Trim(),

                NroIIBB = string.IsNullOrWhiteSpace(txtIIBB.Text) ? null : txtIIBB.Text.Trim(),

                CategoriaIva = cmbCategoriaIva.SelectedIndex > 0 ? cmbCategoriaIva.Text.Trim() : null,
                CondicionPago = cmbCondicionPago.SelectedIndex > 0 ? cmbCondicionPago.Text.Trim() : null,

                Descuento = nudDescuento.Value,

                Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text) ? null : txtObservaciones.Text.Trim()
            };

            if (cmbTipoDoc.SelectedIndex > 0)
            {
                c.TipoDocumento = cmbTipoDoc.Text.Trim();
                var id = (int)cmbTipoDoc.SelectedValue;
                var codEntity = new EntidadService("tipodocumento").GetById(id).Codigo;
                c.TipoDocArca = codEntity;
            }
            return c;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var cliente = LeerFormularioACliente();

                if (_id > 0)
                    _service.Actualizar(cliente);
                else
                    _service.Guardar(cliente);

                MessageOk("Ok", "Actualizado correctamente!");
                this.Dispose();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Fields_Validating(object sender, CancelEventArgs e)
        {
            Validar();
        }

        private bool Validar()
        {
            bool esValido = true;
            errorProvider1.Clear();

            // Código (obligatorio)
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "El campo Código es obligatorio.");
                esValido = false;
            }

            // Nombre (obligatorio)
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El campo Nombre es obligatorio.");
                esValido = false;
            }

            // Zona (obligatorio)
            if (cmbZona.SelectedIndex < 1)
            {
                errorProvider1.SetError(cmbZona, "Debe seleccionar una Zona.");
                esValido = false;
            }

            // SubZona (obligatorio)
            if (cmbSubZona.SelectedIndex < 1)
            {
                errorProvider1.SetError(cmbSubZona, "Debe seleccionar una SubZona.");
                esValido = false;
            }

            // Provincia (obligatorio)
            if (cmbProvincia.SelectedIndex < 1)
            {
                errorProvider1.SetError(cmbProvincia, "Debe seleccionar una Provincia.");
                esValido = false;
            }

            // Tipo Documento (opcional pero validable si completo nro documento)
            //if (!string.IsNullOrWhiteSpace(txtNroDoc.Text) && string.IsNullOrWhiteSpace(cmbTipoDoc.Text))
            //{
            //    errorProvider1.SetError(cmbTipoDoc, "Debe seleccionar un Tipo de Documento.");
            //    esValido = false;
            //}

            // Email (si se completa, validar formato)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                try
                {
                    var email = new System.Net.Mail.MailAddress(txtEmail.Text);
                }
                catch
                {
                    errorProvider1.SetError(txtEmail, "Email no válido.");
                    esValido = false;
                }
            }

            // Descuento (si se completa, debe ser >= 0)
            if (nudDescuento.Value < 0)
            {
                errorProvider1.SetError(nudDescuento, "El descuento no puede ser negativo.");
                esValido = false;
            }

            return esValido;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
