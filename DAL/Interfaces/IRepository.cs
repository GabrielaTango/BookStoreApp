namespace DAL.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllWithParam(string param);
        T GetById(int id);
        int Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
