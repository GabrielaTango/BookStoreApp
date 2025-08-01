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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UI.Procesos
{
    public partial class FrmFacturador : Form
    {
        BindingList<Detalle> detalle = new BindingList<Detalle>();

        private readonly Service<ClienteRepository, Cliente> _cliService = new Service<ClienteRepository, Cliente>();

        QueryService clientesQuery = new QueryService("clientes");
        public FrmFacturador()
        {
            InitializeComponent();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            CentrarTitulo();
        }

        private void FrmFacturador_Load(object sender, EventArgs e)
        {
            CentrarTitulo();

            dataGridView1.DataSource = detalle;
        }

        private void CentrarTitulo()
        {
            label4.Left = (panel1.Width - label4.Width) / 2;
            label4.Top = (panel1.Height - label4.Height) / 2;
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

        private void CargarArticulo()
        {
            FrmAgregarArticulo fArticulo = new FrmAgregarArticulo();
            if (fArticulo.ShowDialog() == DialogResult.OK)
            {
                detalle.Add(fArticulo.detalle);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarCliente();
        }

        private void CargarCliente()
        {
            FrmBuscar fBuscar = new FrmBuscar(clientesQuery);

            if (fBuscar.ShowDialog() == DialogResult.OK)
            {
                var cliente = _cliService.GetById(fBuscar.id);
                txtCodigo.Text = cliente.Codigo;
                txtNroDocumento.Text = cliente.NroDocumento;
                txtDomicilioComercial.Text = cliente.DomicilioComercial;
                txtDomicilioParticular.Text = cliente.DomicilioParticular;
                txtNombreCliente.Text = cliente.Nombre;
            }
        }
    }
}
