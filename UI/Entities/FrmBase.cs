using Accessibility;
using BL;
using Models;


namespace UI
{
    public partial class FrmBase : Form
    {

        public FrmBase()
        {
            InitializeComponent();

        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        protected virtual void CargarGrilla()
        {
            
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 1)
            {
                int i = (int)dgvCustomers.SelectedRows[0].Cells["Id"].Value;
                EditarEntity(i);
                CargarGrilla();
            }
        }

        protected virtual void EditarEntity(int i)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarEntity(0);
            CargarGrilla();
        }
    }
}
