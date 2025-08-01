using BL;
using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmCliente : Form
    {
        private readonly Service<ClienteRepository,Cliente> _service = new Service<ClienteRepository, Cliente>();

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
                CargarClienteEnFormulario(_service.GetById(_id));

        }

        private void CargarClienteEnFormulario(Cliente c)
        {
            txtCodigo.Text = c.Codigo;
            txtNombre.Text = c.Nombre;
            cmbZona.SelectedValue = c.Zona_Id ?? -1;
            cmbSubZona.SelectedValue = c.SubZona_Id ?? -1;
            txtDomComercial.Text = c.DomicilioComercial;
            txtDomParticular.Text = c.DomicilioParticular;
            cmbProvincia.SelectedValue = c.Provincia_Id ?? -1;
            txtCodigoPostal.Text = c.CodigoPostal;
            dtpFechaAlta.Value = c.FechaAlta;

            if (c.FechaInha.HasValue)
            {
                dtpFechaInha.Value = c.FechaInha.Value;
                dtpFechaInha.Checked = true;
            }
            else
            {
                dtpFechaInha.Checked = false;
            }

            chkSoloContado.Checked = c.SoloContado;
            txtTelefono.Text = c.Telefono;
            txtTelefonoMovil.Text = c.TelefonoMovil;
            txtEmail.Text = c.EMail;
            txtContacto.Text = c.Contacto;
            cmbTipoDoc.Text = c.TipoDocumento;
            txtNroDoc.Text = c.NroDocumento;
            txtIIBB.Text = c.NroIIBB;
            cmbCategoriaIva.Text = c.CategoriaIva;
            cmbCondicionPago.Text = c.CondicionPago;
            nudDescuento.Value = c.Descuento ?? 0;
            txtObservaciones.Text = c.Observaciones;
        }

        private void CargarCombos()
        {
            CargarCombo(cmbZona, "zonas");
            CargarCombo(cmbProvincia, "provincias");
            CargarCombo(cmbSubZona, "subzonas");

        }

        private void CargarCombo(ComboBox cmb, string table)
        {
            cmb.DataSource = new EntidadService(table).GetAll();
            cmb.ValueMember = "id";
            cmb.DisplayMember = "descripcion";
        }

        private Cliente LeerFormularioACliente()
        {
            return new Cliente
            {
                Id = _id,
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),

                Zona_Id = cmbZona.SelectedValue != null ? (int?)Convert.ToInt32(cmbZona.SelectedValue) : null,
                SubZona_Id = cmbSubZona.SelectedValue != null ? (int?)Convert.ToInt32(cmbSubZona.SelectedValue) : null,

                DomicilioComercial = string.IsNullOrWhiteSpace(txtDomComercial.Text) ? null : txtDomComercial.Text.Trim(),
                DomicilioParticular = string.IsNullOrWhiteSpace(txtDomParticular.Text) ? null : txtDomParticular.Text.Trim(),

                Provincia_Id = cmbProvincia.SelectedValue != null ? (int?)Convert.ToInt32(cmbProvincia.SelectedValue) : null,
                CodigoPostal = string.IsNullOrWhiteSpace(txtCodigoPostal.Text) ? null : txtCodigoPostal.Text.Trim(),

                FechaAlta = dtpFechaAlta.Value,
                FechaInha = dtpFechaInha.Checked ? dtpFechaInha.Value : (DateTime?)null,

                SoloContado = chkSoloContado.Checked,

                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim(),
                TelefonoMovil = string.IsNullOrWhiteSpace(txtTelefonoMovil.Text) ? null : txtTelefonoMovil.Text.Trim(),

                EMail = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Contacto = string.IsNullOrWhiteSpace(txtContacto.Text) ? null : txtContacto.Text.Trim(),

                TipoDocumento = string.IsNullOrWhiteSpace(cmbTipoDoc.Text) ? null : cmbTipoDoc.Text.Trim(),
                NroDocumento = string.IsNullOrWhiteSpace(txtNroDoc.Text) ? null : txtNroDoc.Text.Trim(),

                NroIIBB = string.IsNullOrWhiteSpace(txtIIBB.Text) ? null : txtIIBB.Text.Trim(),

                CategoriaIva = string.IsNullOrWhiteSpace(cmbCategoriaIva.Text) ? null : cmbCategoriaIva.Text.Trim(),
                CondicionPago = string.IsNullOrWhiteSpace(cmbCondicionPago.Text) ? null : cmbCondicionPago.Text.Trim(),

                Descuento = nudDescuento.Value,

                Observaciones = string.IsNullOrWhiteSpace(txtObservaciones.Text) ? null : txtObservaciones.Text.Trim()
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                var cliente = LeerFormularioACliente();

                if(_id > 0)
                    _service.Actualizar(cliente);
                else
                    _service.Guardar(cliente);
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
            if (cmbZona.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbZona, "Debe seleccionar una Zona.");
                esValido = false;
            }

            // SubZona (obligatorio)
            if (cmbSubZona.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbSubZona, "Debe seleccionar una SubZona.");
                esValido = false;
            }

            // Provincia (obligatorio)
            if (cmbProvincia.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbProvincia, "Debe seleccionar una Provincia.");
                esValido = false;
            }

            // Tipo Documento (opcional pero validable si completo nro documento)
            if (!string.IsNullOrWhiteSpace(txtNroDoc.Text) && string.IsNullOrWhiteSpace(cmbTipoDoc.Text))
            {
                errorProvider1.SetError(cmbTipoDoc, "Debe seleccionar un Tipo de Documento.");
                esValido = false;
            }

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
    }
}
