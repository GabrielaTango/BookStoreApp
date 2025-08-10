using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetQuery(string query);
        T GetById(int id);
        int Guardar(T entidad);
        void Delete(int id);
    }
}
