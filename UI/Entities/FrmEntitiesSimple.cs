using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Entities;

namespace UI
{
    public partial class FrmEntitiesSimple : FrmUtil
    {
        private readonly string _entity;
        private readonly EntidadService _service;
        public FrmEntitiesSimple(string pEntity)
        {
            InitializeComponent();
            _entity = pEntity;
            _service = new EntidadService(_entity);
            this.Text = Capitalize(_entity);
        }

        private void FrmEntitySimple_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
        }

        private void CargarDataGridView()
        {
            dgvEntities.DataSource = _service.GetAll();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntity fEntity = new FrmEntity(_entity, 0);
            if (fEntity.ShowDialog() == DialogResult.OK)
                CargarDataGridView();
        }

        private void dgvEntity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntities.SelectedRows.Count == 1)
            {
                int i = (int)dgvEntities.SelectedRows[0].Cells["Id"].Value;
                FrmEntity fEntity = new FrmEntity(_entity,i);
                if (fEntity.ShowDialog() == DialogResult.OK)
                    CargarDataGridView();
            }
        }
    }
}
