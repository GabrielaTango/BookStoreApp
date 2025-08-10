using Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class EntityRepository : BaseRepository<EntidadSimple>
    {
        private readonly string _table;
        public EntityRepository(string pTable)
        {
            _table = pTable;
        }

        protected override string GetSelectAllQuery() =>
$"SELECT id, Codigo, Descripcion FROM {_table}";

        protected override string GetSelectByIdQuery() =>
            $"SELECT * FROM {_table} WHERE id = @id";

        protected override string GetInsertQuery() =>
            @$"
        INSERT INTO {_table} (
            Codigo,
            Descripcion
        ) VALUES (
            @Codigo,
            @Descripcion
        );";

        protected override string GetUpdateQuery() =>
           @$"
        UPDATE {_table} SET
            Codigo = @Codigo,
            Descripcion = @Descripcion
        WHERE Id = @Id;
    ";

        protected override string GetDeleteQuery() =>
            "DELETE FROM clientes WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, EntidadSimple entity)
        {
            cmd.Parameters.AddWithValue("@Id", entity.Id);
            cmd.Parameters.AddWithValue("@Codigo", entity.Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);

        }

        protected override void SetUpdateParameters(MySqlCommand cmd, EntidadSimple c)
        {
            AddParameters(cmd, c);
        }

        protected override EntidadSimple Map(IDataReader reader)
        {
            EntidadSimple e = new EntidadSimple();

            e.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            e.Codigo = reader.GetString(reader.GetOrdinal("Codigo"));
            e.Descripcion = reader.GetString(reader.GetOrdinal("Descripcion"));

            return e;
        }
   }
}
