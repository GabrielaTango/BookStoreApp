using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class ComprobanteDetalleRepository : BaseRepository<ComprobanteDetalle>
    {
        private const string tableName = "comprobante_detalle";

        protected override string GetSelectAllQuery() =>
            $"SELECT * FROM {tableName}";

        protected override string GetSelectByIdQuery() =>
            $"SELECT * FROM {tableName} WHERE id = @id";

        protected override string GetInsertQuery() =>
            @$"
            INSERT INTO {tableName} (
                factura_id,
                articulo_id,
                cantidad,
                precio_unitario,
                subtotal
            ) VALUES (
                @FacturaId,
                @ArticuloId,
                @Cantidad,
                @PrecioUnitario,
                @Subtotal
            );";

        protected override string GetUpdateQuery() =>
            $@"
            UPDATE {tableName} SET
                factura_id = @FacturaId,
                articulo_id = @ArticuloId,
                cantidad = @Cantidad,
                precio_unitario = @PrecioUnitario,
                subtotal = @Subtotal
            WHERE id = @Id;";

        protected override string GetDeleteQuery() =>
            $"DELETE FROM {tableName} WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, ComprobanteDetalle detalle)
        {
            cmd.Parameters.AddWithValue("@Id", detalle.Id);
            cmd.Parameters.AddWithValue("@FacturaId", detalle.FacturaId);
            cmd.Parameters.AddWithValue("@ArticuloId", detalle.ArticuloId);
            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", detalle.Subtotal);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, ComprobanteDetalle detalle)
        {
            AddParameters(cmd, detalle);
        }

        protected override ComprobanteDetalle Map(IDataReader reader)
        {
            return new ComprobanteDetalle
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                FacturaId = reader.GetInt32(reader.GetOrdinal("factura_id")),
                ArticuloId = reader.GetInt32(reader.GetOrdinal("articulo_id")),
                Cantidad = reader.GetInt32(reader.GetOrdinal("cantidad")),
                PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("precio_unitario")),
                Subtotal = reader.GetDecimal(reader.GetOrdinal("subtotal"))
            };
        }
    }
}
