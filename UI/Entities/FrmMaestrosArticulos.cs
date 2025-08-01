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

namespace UI.Entities
{
    public partial class FrmMaestrosArticulos : FrmBase
    {
        private IService<Articulo> _service;
        public FrmMaestrosArticulos()
        {
            InitializeComponent();
            _service = new Service<ArticuloRepository, Articulo>();
        }

        private void FrmMaestrosArticulos_Load(object sender, EventArgs e)
        {
            lblTittle.Text = "Articulos";
            base.Text = "Maestros de Articulos";
        }

        protected override void EditarEntity(int i)
        {
            FrmArticulo fArt = new FrmArticulo();
            fArt.ShowDialog();
        }

        protected override void CargarGrilla()
        {
            try
            {
                var clientes = _service.GetAll();
                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
