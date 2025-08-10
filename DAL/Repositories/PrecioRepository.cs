using Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class PrecioRepository : BaseRepository<Precio>
    {
        private const string tableName = "precios";

        protected override string GetSelectAllQuery() =>
            $"SELECT * FROM {tableName}" +
            $" INNER JOIN articulos on articulos.id = {tableName}.Articulo_Id";

        protected string GetSelectAllQueryByListaId() =>
            $"SELECT * FROM {tableName}" +
            $" INNER JOIN articulos on articulos.id = {tableName}.id" +
            $" @param";

        protected override string GetSelectByIdQuery() =>
            GetSelectAllQuery() + $" WHERE {tableName}.Id = @Id";

        protected override string GetInsertQuery() =>
            @$"
            INSERT INTO {tableName} (
                Lista_Id,
                Articulo_Id,
                Precio
            ) VALUES (
                @Lista_Id,
                @Articulo_Id,                
                @Precio
            );";

        protected override string GetUpdateQuery() =>
            @$"
            UPDATE {tableName} SET
                Lista_Id = @Lista_Id,
                Precio   = @Precio
            WHERE Id = @Id;";

        protected override string GetDeleteQuery() =>
            $"DELETE FROM {tableName} WHERE Id = @Id";

        protected override void AddParameters(MySqlCommand cmd, Precio p)
        {
            // Incluyo @Id por coherencia con tu BaseRepository (Update/Delete)
            cmd.Parameters.AddWithValue("@Id", p.Id);
            cmd.Parameters.AddWithValue("@Lista_Id", (object?)p.Lista_Id ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Articulo_Id", (object?)p.Articulo_Id ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Precio", (object?)p.Importe ?? DBNull.Value);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, Precio p)
        {
            AddParameters(cmd, p);
        }

        protected override Precio Map(IDataReader reader)
        {
            var r = new Precio();

            r.Id = reader.GetInt32(reader.GetOrdinal("Id"));

            r.Lista_Id = reader.IsDBNull(reader.GetOrdinal("Lista_Id"))
                ? (int?)null
                : reader.GetInt32(reader.GetOrdinal("Lista_Id"));

            r.Importe = reader.IsDBNull(reader.GetOrdinal("Precio"))
                ? (decimal?)null
                : reader.GetDecimal(reader.GetOrdinal("Precio"));

            r.Articulo_Id = reader.IsDBNull(reader.GetOrdinal("Articulo_Id"))
                ? (int?)null
                : reader.GetInt32(reader.GetOrdinal("Lista_Id"));

            r.Codigo = reader.IsDBNull(reader.GetOrdinal("Codigo"))
                ? (string?)null
                : reader.GetString(reader.GetOrdinal("Codigo"));

            r.Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion"))
                ? (string?)null
                : reader.GetString(reader.GetOrdinal("Descripcion"));

            return r;
        }

        public IEnumerable<Precio> GetSelectAllByListaId(int id)
        {
            var list = new List<Precio>();
            using var conn = _connection.GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand(GetSelectAllQueryByListaId(), conn);
            cmd.Parameters.AddWithValue("@id", id);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
                list.Add(Map(reader));

            return list;
        }

    }
}
