using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class QueryService
    {
        readonly QueryRepository _queryRepository;

        public string table = "clientes";

        string sql = "";
        
        public QueryService(string table)
        {
            _queryRepository = new QueryRepository();
            this.table = table;
            sql = $"select * from {this.table}";
        }

        public DataTable EjecutarQuery(string parameter)
        {
            var parameters = new Dictionary<string, object>();
            parameters.Add("Nombre", parameter);

            return _queryRepository.EjecutarConsulta(sql,parameters);
        }
    }
}
