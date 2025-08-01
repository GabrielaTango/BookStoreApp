using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ArticuloRepository : BaseRepository<Articulo>
    {
        private const string tableName = "articulos";
        protected override string GetSelectAllQuery() =>
        $"SELECT * FROM {tableName}";

        protected override string GetSelectByIdQuery() =>
            $"SELECT * FROM {tableName} WHERE id = @id";

        protected override string GetInsertQuery() =>
            @$"
        INSERT INTO {tableName} (
            Codigo,
            Descripcion
        ) VALUES (
            @Codigo,
            @Descripcion
        );";

        protected override string GetUpdateQuery() =>
           $@"
        UPDATE {tableName} SET
            Codigo = @Codigo,
            Descripcion = @Descripcion
        WHERE Id = @Id;
    ";

        protected override string GetDeleteQuery() =>
            $"DELETE FROM {tableName} WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, Articulo cliente)
        {
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", cliente.Descripcion);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, Articulo c)
        {
            AddParameters(cmd, c);
        }

        protected override Articulo Map(IDataReader reader)
        {
            Articulo c = new Articulo();

            c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            c.Codigo = reader.GetString(reader.GetOrdinal("Codigo"));
            c.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));

            return c;
        }
    }
}
