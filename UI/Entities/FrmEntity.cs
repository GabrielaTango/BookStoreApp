using BL;
using Models;

namespace UI
{
    public partial class FrmEntity : Form
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
            if(_index > 0)
            {
                _obj = _service.GetById(_index);
                Maperar();
            } else
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
            _obj.Id = id ;
            _obj.Codigo = txtCodigo.Text;
            _obj.Descripcion = txtDescripcion.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
