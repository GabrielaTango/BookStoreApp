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
Codigo, Descripcion, CodBarras, Observaciones, Tomos, Tema
        ) VALUES (
@Codigo, @Descripcion, @CodBarras, @Observaciones, @Tomos, @Tema
        );";

        protected override string GetUpdateQuery() =>
           $@"
        UPDATE {tableName} SET
Codigo = @Codigo
, Descripcion = @Descripcion
, CodBarras = @CodBarras
, Observaciones = @Observaciones
, Tomos = @Tomos
, Tema = @Tema
        WHERE Id = @Id;
    ";

        protected override string GetDeleteQuery() =>
            $"DELETE FROM {tableName} WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, Articulo a)
        {
            // Nota: Incluyo @Id por si tu BaseRepository lo usa en Update/Delete
            cmd.Parameters.AddWithValue("@Id", a.Id);

            cmd.Parameters.AddWithValue("@Codigo", (object?)a.Codigo ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Descripcion", (object?)a.Descripcion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CodBarras", (object?)a.CodBarras ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Observaciones", (object?)a.Observaciones ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Tomos", (object?)a.Tomos ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Tema", (object?)a.Tema ?? DBNull.Value);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, Articulo c)
        {
            AddParameters(cmd, c);
        }

        protected override Articulo Map(IDataReader reader)
        {
            var artriculo = new Articulo
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Codigo = reader.IsDBNull(reader.GetOrdinal("Codigo"))
                   ? null
                   : reader.GetString(reader.GetOrdinal("Codigo")),
                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion"))
                   ? null
                   : reader.GetString(reader.GetOrdinal("Descripcion")),
                CodBarras = reader.IsDBNull(reader.GetOrdinal("CodBarras"))
                   ? null
                   : reader.GetString(reader.GetOrdinal("CodBarras")),
                Observaciones = reader.IsDBNull(reader.GetOrdinal("Observaciones"))
                   ? null
                   : reader.GetString(reader.GetOrdinal("Observaciones")),
                Tomos = reader.IsDBNull(reader.GetOrdinal("Tomos"))
                   ? (int?)null
                   : reader.GetInt32(reader.GetOrdinal("Tomos")),
                Tema = reader.IsDBNull(reader.GetOrdinal("Tema"))
                   ? null
                   : reader.GetString(reader.GetOrdinal("Tema"))
            };

            return artriculo;      
        }
    }
}
