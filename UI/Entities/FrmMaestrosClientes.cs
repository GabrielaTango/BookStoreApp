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
    public partial class FrmMaestrosClientes : FrmBase
    {
        private IService<Cliente> _service;
        public FrmMaestrosClientes() : base()
        {
            _service = new Service<ClienteRepository, Cliente>();
        }

        private void FrmMaestrosClientes_Load(object sender, EventArgs e)
        {
            lblTittle.Text = "Clientes";
            base.Text = "Maestros de Clientes";
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

        protected override void EditarEntity(int i)
        {
            FrmCliente f = new FrmCliente(i);
            f.ShowDialog();
        }
    }
}
