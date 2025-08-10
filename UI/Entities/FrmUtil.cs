using BL;
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

namespace UI.Entities
{
    public partial class FrmUtil : Form
    {
        public FrmUtil()
        {
            InitializeComponent();
        }

        private void FrmUtil_Load(object sender, EventArgs e)
        {

        }

        protected string Capitalize(string entity)
        {
            return char.ToUpper(entity[0]) + entity.Substring(1).ToLower();
        }

        protected void CargarCombo(ComboBox cmb, string table)
        {

            var listaConSeleccion = new List<EntidadSimple>
            {
                new EntidadSimple { Id = null, Descripcion = "Seleccione uno" }
            };

            listaConSeleccion.AddRange(new EntidadService(table).GetAll());

            cmb.DataSource = listaConSeleccion;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "descripcion";
        }

        protected void MessageError(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void MessageOk(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        protected void MessageWarning(string title, string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool MessageWarningYesNo(string title, string text)
        {
            if(MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
