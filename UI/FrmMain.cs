using Models.FacturaElectronica;
using UI.Entities;
using UI.Procesos;

namespace UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fMaestros = new FrmMaestrosClientes();
            fMaestros.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmMaestrosArticulos();
            f.ShowDialog();
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("zonas");
        }

        private void subZonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("subzonas");
        }

        private void EditarEntity(string entity)
        {
            FrmEntitiesSimple fEntity = new FrmEntitiesSimple(entity);
            fEntity.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("provincias");
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturador fFacturador = new FrmFacturador(TipoComprobanteAfip.FacturaC);
            fFacturador.ShowDialog();
        }

        private void condicionVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("condicionVenta");
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("vendedores");
        }

        private void listasDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEntity("listas");
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaestrosPrecios fPrecios = new FrmMaestrosPrecios();
            fPrecios.ShowDialog();
        }
    }
}
