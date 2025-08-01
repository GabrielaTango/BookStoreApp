using BL;
using Models;
using UI.Entities;
using UI.Procesos;

namespace UI
{
    public partial class FrmMain : Form
    {
        FacturaService FeService = new();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FeService.ObtenerTA();
            //FeService.UltimoComp();
            //FeService.Facturar();

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

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FeService.ObtenerTA();
            //FeService.UltimoComp();
            //FeService.Facturar();
            FrmFacturador fFacturador = new FrmFacturador();
            fFacturador.ShowDialog();
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
    }
}
