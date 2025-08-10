using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL.Repositories
{
    public class ComprobanteRepository : BaseRepository<Comprobante>
    {
        private const string tableName = "comprobantes";

        protected override string GetSelectAllQuery() =>
            $"SELECT * FROM {tableName}";

        protected override string GetSelectByIdQuery() =>
            $"SELECT * FROM {tableName} WHERE id = @id";

        protected override string GetInsertQuery() =>
            @$"
            INSERT INTO {tableName} (
                cliente_id,
                fecha,
                tipoComprobante,
                numeroComprobante,
                total
                ,CAE
                ,VTO
            ) VALUES (
                @ClienteId,
                @Fecha,
                @TipoComprobante,
                @NumeroComprobante,
                @Total,
                @CAE,                
                @VTO
            );";

        protected override string GetUpdateQuery() =>
            $@"
            UPDATE {tableName} SET
                cliente_id = @ClienteId,
                fecha = @Fecha,
                tipoComprobante = @TipoComprobante,
                numeroComprobante = @NumeroComprobante,
                total = @Total
            WHERE id = @Id;";

        protected override string GetDeleteQuery() =>
            $"DELETE FROM {tableName} WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, Comprobante comprobante)
        {
            cmd.Parameters.AddWithValue("@Id", comprobante.Id);
            cmd.Parameters.AddWithValue("@ClienteId", comprobante.ClienteId);
            cmd.Parameters.AddWithValue("@Fecha", comprobante.Fecha);
            cmd.Parameters.AddWithValue("@TipoComprobante", comprobante.TipoComprobante);
            cmd.Parameters.AddWithValue("@NumeroComprobante", comprobante.NumeroComprobante);
            cmd.Parameters.AddWithValue("@Total", comprobante.Total);
            cmd.Parameters.AddWithValue("@CAE", comprobante.CAE);
            cmd.Parameters.AddWithValue("@VTO", comprobante.VTO);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, Comprobante comprobante)
        {
            AddParameters(cmd, comprobante);
        }

        protected override Comprobante Map(IDataReader reader)
        {
            return new Comprobante
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                ClienteId = reader.GetInt32(reader.GetOrdinal("cliente_id")),
                Fecha = reader.GetDateTime(reader.GetOrdinal("fecha")),
                TipoComprobante = reader.GetString(reader.GetOrdinal("tipoComprobante")),
                NumeroComprobante = reader.GetString(reader.GetOrdinal("numeroComprobante")),
                Total = reader.GetDecimal(reader.GetOrdinal("total"))
            };
        }
    }
}
