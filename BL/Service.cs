using DAL.Interfaces;
using DAL.Repositories;
using Models;

namespace BL
{
    public class Service<R, E> : IService<E> where R : IRepository<E>, new()
    {
        private readonly R _repository;
        public Service()
        {
            _repository = new R();
        }
        public IEnumerable<E> GetAll()
        {
            return _repository.GetAll();
        }
        public E GetById(int v)
        {
            return _repository.GetById(v);
        }
        public void Guardar(E entity)
        {
            _repository.Add(entity);
        }

        public void Actualizar(E entity)
        {
            _repository.Update(entity);
        }

    }
}
