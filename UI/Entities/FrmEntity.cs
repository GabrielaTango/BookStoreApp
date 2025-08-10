using BL;
using Models;
using UI.Entities;

namespace UI
{
    public partial class FrmEntity : FrmUtil
    {
        private readonly string _entity;

        private readonly EntidadService _service;
        private readonly int _index;

        private EntidadSimple _obj;

        public FrmEntity(string entity, int index)
        {
            InitializeComponent();
            _entity = entity;
            _service = new EntidadService(_entity);
            _index = index;
        }

        private void FrmEntity_Load(object sender, EventArgs e)
        {
            this.Text = Capitalize(_entity);
            if (_index > 0)
            {
                btnGuardar.Text = "Actualizar";
                _obj = _service.GetById(_index);
                Maperar();
            }
            else
            {
                _obj = new EntidadSimple();
            }

        }

        private void Maperar()
        {
            txtId.Text = _obj.Id.ToString();
            txtCodigo.Text = _obj.Codigo;
            txtDescripcion.Text = _obj.Descripcion;
        }

        private void LeerDatos()
        {
            int id;
            int.TryParse(txtId.Text, out id);
            _obj.Id = id;
            _obj.Codigo = txtCodigo.Text;
            _obj.Descripcion = txtDescripcion.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                LeerDatos();
                _service.Save(_obj);
                this.DialogResult = DialogResult.OK;
                MessageOk("Ok", "Actaulizado correctamente!");
                this.Dispose();
            } catch (Exception ex)
            {
                MessageError("Error", ex.Message);
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
