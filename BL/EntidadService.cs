using DAL.Repositories;
using Models;

namespace BL
{
    public class EntidadService
    {
        private readonly EntityRepository _repository;
        private string _entity;

        public EntidadService(string entity)
        {
            _entity = entity;
            _repository = new EntityRepository(_entity);
        }

        public IEnumerable<EntidadSimple> GetAll()
        {
            return _repository.GetAll();
        }

        public EntidadSimple GetById(int index)
        {
            return _repository.GetById(index);
        }
    }
}
