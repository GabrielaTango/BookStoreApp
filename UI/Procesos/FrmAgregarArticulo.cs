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

        private readonly PrecioService _precioService = new PrecioService();
        public Detalle detalle;

        private int _lista = 0;
        public FrmAgregarArticulo(int lista)
        {
            InitializeComponent();
            _lista = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void BuscarArticulo()
        {
            FrmBuscar fBuscar = new FrmBuscar(new QueryService("articulos"));
            if (fBuscar.ShowDialog() == DialogResult.OK)
            {
                detalle = new Detalle(_artService.GetById(fBuscar.id));
                var precio = _precioService.GetPrecio(_lista, detalle.Id);
                txtPrecio.Value = precio;
                txtCodigo.Text = detalle.Codigo;
                txtDescripcion.Text = detalle.Descripcion;
                SendKeys.Send("{TAB}");
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            this.Text = "Agregar Articulo";
            if (detalle == null)
                BuscarArticulo();
            else
            {
                this.Text = "Modificar Articulo";
                btnBuscar.Enabled = false;
                txtCodigo.Text = detalle.Codigo;
                txtDescripcion.Text = detalle.Descripcion;
                txtCantidad.Value = detalle.Cantidad;
                txtPrecio.Value = detalle.Precio;

            }
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
            NumericUpDown num = (NumericUpDown)sender;
            num.Select(0, num.Text.Length);
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
