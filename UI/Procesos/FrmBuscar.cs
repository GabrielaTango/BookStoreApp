using BL;

namespace UI.Procesos
{
    public partial class FrmBuscar : Form
    {
        public int id = -1;

        readonly QueryService _queryService;
        public FrmBuscar(QueryService service)
        {
            InitializeComponent();
            _queryService = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            dataGridView1.DataSource = _queryService.EjecutarQuery(txtBuscar.Text);
        }

        private void Seleccionar()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                id = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            var texto = _queryService.table;
            lblTitulo.Text = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
            Buscar();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Seleccionar();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Seleccionar();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar();
                dataGridView1.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                dataGridView1.Focus();
            }
        }
    }
}


