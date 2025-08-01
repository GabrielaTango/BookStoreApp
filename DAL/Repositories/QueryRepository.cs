using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class QueryRepository
    {
        protected readonly Connection _connection;

        public QueryRepository()
        {
            _connection = new Connection();
        }

        public DataTable EjecutarConsulta(string sql, Dictionary<string, object> parametros = null)
        {
            using (var conn = _connection.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                if (parametros != null)
                {
                    foreach (var kvp in parametros)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value ?? DBNull.Value);
                    }
                }

                using (var da = new MySqlDataAdapter(cmd))
                {
                    var tabla = new DataTable();
                    da.Fill(tabla);
                    return tabla;
                }
            }
        }
    }
}

