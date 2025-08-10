using BL;
using DAL.Repositories;
using Models;

namespace UI.Entities
{
    public partial class FrmMaestrosPrecios : FrmUtil
    {
        private PrecioService _service;
        public FrmMaestrosPrecios()
        {
            _service = new PrecioService();
            InitializeComponent();
        }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbLista, "listas");
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void dataGridView1_CellDoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                var precio = _service.GetById(id);
                FrmPrecio fPrecio = new FrmPrecio(precio);
                if (fPrecio.ShowDialog() == DialogResult.OK)
                {
                    MessageOk("Ok", "Precio modificado correctamente!");
                    CargarDataGridView();
                }
            }
        }

        private void CargarDataGridView()
        {

            if (cmbLista.SelectedIndex > 0)
            {
                var value = (int)cmbLista.SelectedValue;
                dataGridView1.DataSource = _service.GetPorLista(value);
            }
            else
                dataGridView1.DataSource = null;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                if (MessageWarningYesNo("Cuidado", "Ësta seguro desea eliminar el precio?"))
                {
                    _service.Delete(id);
                    CargarDataGridView();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbLista.SelectedIndex > 0)
            {
                var value = (int)cmbLista.SelectedValue;
                FrmPrecio fPrecio = new FrmPrecio(new Precio() { Lista_Id = value });
                if (fPrecio.ShowDialog() == DialogResult.OK)
                {
                    MessageOk("Ok", "Precio cargado correctamente!");
                    CargarDataGridView();
                }
            }
            else
                MessageWarning("Cuidado", "Debe seleccionar una lista!");
        }
    }
}
