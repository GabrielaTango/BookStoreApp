using BL;
using DAL.Repositories;
using Models;
using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Entities
{
    public partial class FrmArticulo : FrmUtil
    {
        private int _id;
        private readonly Service<ArticuloRepository, Articulo> _service = new Service<ArticuloRepository, Articulo>();

        Articulo articulo;

        public FrmArticulo(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            txtId.Text = "0";
            if (_id > 0)
            {
                articulo = _service.GetById(_id);
                CargarArticuloEnFormulario();
            }
        }

        private void CargarArticuloEnFormulario()
        {
            if (articulo is null) return;

            txtId.Text = articulo.Id.ToString();
            txtCodigo.Text = articulo.Codigo ?? string.Empty;
            txtDescripcion.Text = articulo.Descripcion ?? string.Empty;
            txtCodBarras.Text = articulo.CodBarras ?? string.Empty;
            txtObservaciones.Text = articulo.Observaciones ?? string.Empty;
            txtTomos.Text = articulo.Tomos?.ToString() ?? string.Empty;
            txtTema.Text = articulo.Tema ?? string.Empty;
        }

        private void LeerFormularioAArticulo()
        {
            articulo = new Articulo();
            // Id (si está vacío o inválido, dejamos 0)
            articulo.Id = TryParseInt(txtId.Text, 0);

            articulo.Codigo = NullIfEmpty(txtCodigo.Text);
            articulo.Descripcion = NullIfEmpty(txtDescripcion.Text);
            articulo.CodBarras = NullIfEmpty(txtCodBarras.Text);
            articulo.Observaciones = NullIfEmpty(txtObservaciones.Text);
            articulo.Tomos = TryParseIntNullable(txtTomos.Text);
            articulo.Tema = NullIfEmpty(txtTema.Text);
        }

        // --- Helpers simples ---
        private string? NullIfEmpty(string? s)
            => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

        private int TryParseInt(string? s, int fallback)
            => int.TryParse(s, out var n) ? n : fallback;

        private int? TryParseIntNullable(string? s)
            => int.TryParse(s, out var n) ? n : (int?)null;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LeerFormularioAArticulo();

                if (_id > 0)
                    _service.Actualizar(articulo);
                else
                    _service.Guardar(articulo);

                MessageOk("Ok", "Actualizado correctamente!");
                this.Dispose();
            }
        }

        private bool Validar()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Requeridos
            if (string.IsNullOrWhiteSpace(articulo.Codigo))
            {
                valido = false;
                errorProvider1.SetError(txtCodigo, "El Código es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(articulo.Descripcion))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "La descripción es obligatoria.");
            }

            // Longitudes
            if (!string.IsNullOrEmpty(articulo.Codigo) && articulo.Codigo.Length > 25)
            {
                valido = false;
                errorProvider1.SetError(txtCodigo, "Máximo 25 caracteres.");
            }

            if (!string.IsNullOrEmpty(articulo.Descripcion) && articulo.Descripcion.Length > 100)
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "Máximo 100 caracteres.");
            }

            if (!string.IsNullOrEmpty(articulo.CodBarras) && articulo.CodBarras.Length > 13)
            {
                valido = false;
                errorProvider1.SetError(txtCodBarras, "Máximo (y típico) 13 caracteres.");
            }

            if (!string.IsNullOrEmpty(articulo.Observaciones) && articulo.Observaciones.Length > 2000)
            {
                valido = false;
                errorProvider1.SetError(txtObservaciones, "Máximo 2000 caracteres.");
            }

            if (!string.IsNullOrEmpty(articulo.Tema) && articulo.Tema.Length > 50)
            {
                valido = false;
                errorProvider1.SetError(txtTema, "Máximo 50 caracteres.");
            }

            // Tomos
            if (articulo.Tomos is < 0)
            {
                valido = false;
                errorProvider1.SetError(txtTomos, "No puede ser negativo.");
            }

            // CodBarras con EAN-13
            if (!string.IsNullOrWhiteSpace(articulo.CodBarras))
            {
                if (!Regex.IsMatch(articulo.CodBarras, @"^\d{13}$"))
                {
                    valido = false;
                    errorProvider1.SetError(txtCodBarras, "Debe tener exactamente 13 dígitos.");
                }
                else if (!CheckEan13(articulo.CodBarras))
                {
                    valido = false;
                    errorProvider1.SetError(txtCodBarras, "Dígito verificador inválido (EAN-13/ISBN-13).");
                }
            }

            return valido;
        }

        // EAN-13 / ISBN-13 checksum
        // Sumatoria: (dígitos en pos impar *1) + (pos par *3), DV = (10 - (sum % 10)) % 10
        private static bool CheckEan13(string digits13)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int d = digits13[i] - '0';
                sum += (i % 2 == 0) ? d : d * 3;
            }
            int dv = (10 - (sum % 10)) % 10;
            return dv == (digits13[12] - '0');
        }
    }
}
