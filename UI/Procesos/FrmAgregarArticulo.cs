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

namespace UI.Procesos
{
    public partial class FrmAgregarArticulo : Form
    {
        private readonly Service<ArticuloRepository, Articulo> _artService = new Service<ArticuloRepository, Articulo>();

        public Detalle detalle;
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscar fBuscar = new FrmBuscar(new QueryService("articulos"));
            if (fBuscar.ShowDialog() == DialogResult.OK)
            {
                detalle = new Detalle(_artService.GetById(fBuscar.id));
                txtCodigo.Text = detalle.Codigo;
                txtDescripcion.Text = detalle.Descripcion;
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (detalle != null)
            {
                this.DialogResult = DialogResult.OK;
                detalle.Cantidad = txtCantidad.Value;
                detalle.Precio = txtPrecio.Value;
                txtCantidad.Focus();
            }
            this.Dispose();
        }

        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select();
        }

        private void NumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
