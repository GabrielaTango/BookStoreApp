using Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;

namespace DAL.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>
    {
        private const string tableName = "clientes";
        protected override string GetSelectAllQuery() =>
        $"SELECT * FROM {tableName}";

        protected override string GetSelectByIdQuery() =>
            "SELECT * FROM clientes WHERE id = @id";

        protected override string GetInsertQuery() =>
            @"
        INSERT INTO clientes (
            Codigo,
            Nombre,
            Zona_Id,
            SubZona_Id,
            Vendedor_Id,
            DomicilioComercial,
            DomicilioParticular,
            Provincia_Id,
            CodigoPostal,
            FechaAlta,
            FechaInha,
            SoloContado,
            Telefono,
            TelefonoMovil,
            EMail,
            Contacto,
            TipoDocumento,
            NroDocumento,
            NroIIBB,
            CategoriaIva,
            CondicionPago,
            Descuento,
            Observaciones,
            TipoDocArca
        ) VALUES (
            @Codigo,
            @Nombre,
            @Zona_Id,
            @SubZona_Id,
            @DomicilioComercial,
            @DomicilioParticular,
            @Provincia_Id,
            @CodigoPostal,
            @FechaAlta,
            @FechaInha,
            @SoloContado,
            @Telefono,
            @TelefonoMovil,
            @EMail,
            @Contacto,
            @TipoDocumento,
            @NroDocumento,
            @NroIIBB,
            @CategoriaIva,
            @CondicionPago,
            @Descuento,
            @Observaciones,
            @TipoDocArca
        );";

        protected override string GetUpdateQuery() =>
           @"
        UPDATE clientes SET
            Codigo = @Codigo,
            Nombre = @Nombre,
            Zona_Id = @Zona_Id,
            Vendedor_Id = @Vendedor_Id,
            SubZona_Id = @SubZona_Id,
            DomicilioComercial = @DomicilioComercial,
            DomicilioParticular = @DomicilioParticular,
            Provincia_Id = @Provincia_Id,
            CodigoPostal = @CodigoPostal,
            FechaAlta = @FechaAlta,
            FechaInha = @FechaInha,
            SoloContado = @SoloContado,
            Telefono = @Telefono,
            TelefonoMovil = @TelefonoMovil,
            EMail = @EMail,
            Contacto = @Contacto,
            TipoDocumento = @TipoDocumento,
            NroDocumento = @NroDocumento,
            NroIIBB = @NroIIBB,
            CategoriaIva = @CategoriaIva,
            CondicionPago = @CondicionPago,
            Descuento = @Descuento,
            Observaciones = @Observaciones,
            TipoDocArca = @TipoDocArca
        WHERE Id = @Id;
    ";

        protected override string GetDeleteQuery() =>
            "DELETE FROM clientes WHERE id = @id";

        protected override void AddParameters(MySqlCommand cmd, Cliente cliente)
        {
            cmd.Parameters.AddWithValue("@Id", cliente.Id);
            cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Zona_Id", cliente.Zona_Id);
            cmd.Parameters.AddWithValue("@Vendedor_Id", cliente.Vendedor_Id);
            cmd.Parameters.AddWithValue("@SubZona_Id", cliente.SubZona_Id);
            cmd.Parameters.AddWithValue("@DomicilioComercial", cliente.DomicilioComercial);
            cmd.Parameters.AddWithValue("@DomicilioParticular", cliente.DomicilioParticular);
            cmd.Parameters.AddWithValue("@Provincia_Id", cliente.Provincia_Id);
            cmd.Parameters.AddWithValue("@CodigoPostal", cliente.CodigoPostal);
            cmd.Parameters.AddWithValue("@FechaAlta", cliente.FechaAlta);
            cmd.Parameters.AddWithValue("@FechaInha", cliente.FechaInha.HasValue ? cliente.FechaInha.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@SoloContado", cliente.SoloContado);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@TelefonoMovil", cliente.TelefonoMovil);
            cmd.Parameters.AddWithValue("@EMail", cliente.EMail);
            cmd.Parameters.AddWithValue("@Contacto", cliente.Contacto);
            cmd.Parameters.AddWithValue("@TipoDocumento", cliente.TipoDocumento);
            cmd.Parameters.AddWithValue("@NroDocumento", cliente.NroDocumento);
            cmd.Parameters.AddWithValue("@NroIIBB", cliente.NroIIBB);
            cmd.Parameters.AddWithValue("@CategoriaIva", cliente.CategoriaIva);
            cmd.Parameters.AddWithValue("@CondicionPago", cliente.CondicionPago);
            cmd.Parameters.AddWithValue("@Descuento", cliente.Descuento);
            cmd.Parameters.AddWithValue("@Observaciones", cliente.Observaciones);
            cmd.Parameters.AddWithValue("@TipoDocArca", cliente.TipoDocArca);
        }

        protected override void SetUpdateParameters(MySqlCommand cmd, Cliente c)
        {
            AddParameters(cmd, c);
        }

        protected override Cliente Map(IDataReader reader)
        {
            Cliente c = new Cliente();

            c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            c.Codigo = reader.GetString(reader.GetOrdinal("Codigo"));
            c.Nombre = reader.GetString(reader.GetOrdinal("Nombre"));

            c.Zona_Id = reader.IsDBNull(reader.GetOrdinal("Zona_Id"))
                    ? null
                    : reader.GetInt32(reader.GetOrdinal("Zona_Id"));
            c.SubZona_Id = reader.IsDBNull(reader.GetOrdinal("SubZona_Id"))
                    ? null
                    : reader.GetInt32(reader.GetOrdinal("SubZona_Id"));

            c.Vendedor_Id = reader.IsDBNull(reader.GetOrdinal("Vendedor_Id"))
                   ? null
                   : reader.GetInt32(reader.GetOrdinal("Vendedor_Id"));

            c.DomicilioComercial = reader.IsDBNull(reader.GetOrdinal("DomicilioComercial"))
                    ? null
                    : reader.GetString(reader.GetOrdinal("DomicilioComercial"));

            c.DomicilioParticular = reader.IsDBNull(reader.GetOrdinal("DomicilioParticular"))
                ? null
                : reader.GetString(reader.GetOrdinal("DomicilioParticular"));

            c.Provincia_Id = reader.IsDBNull(reader.GetOrdinal("Provincia_Id"))
                    ? null
                    : reader.GetInt32(reader.GetOrdinal("Provincia_Id"));

            c.CodigoPostal = reader.IsDBNull(reader.GetOrdinal("CodigoPostal"))
                ? null
                : reader.GetString(reader.GetOrdinal("CodigoPostal"));

            c.FechaAlta = reader.GetDateTime(reader.GetOrdinal("FechaAlta"));

            c.FechaInha = reader.IsDBNull(reader.GetOrdinal("FechaInha"))
                ? (DateTime?)null
                : reader.GetDateTime(reader.GetOrdinal("FechaInha"));

            c.SoloContado = reader.GetBoolean(reader.GetOrdinal("SoloContado"));

            c.Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono"))
                ? null
                : reader.GetString(reader.GetOrdinal("Telefono"));

            c.TelefonoMovil = reader.IsDBNull(reader.GetOrdinal("TelefonoMovil"))
                ? null
                : reader.GetString(reader.GetOrdinal("TelefonoMovil"));

            c.EMail = reader.IsDBNull(reader.GetOrdinal("EMail"))
                ? null
                : reader.GetString(reader.GetOrdinal("EMail"));

            c.Contacto = reader.IsDBNull(reader.GetOrdinal("Contacto"))
                ? null
                : reader.GetString(reader.GetOrdinal("Contacto"));


            c.TipoDocumento = reader.IsDBNull(reader.GetOrdinal("TipoDocumento"))
                ? null
                : reader.GetString(reader.GetOrdinal("TipoDocumento"));

            c.TipoDocArca = reader.IsDBNull(reader.GetOrdinal("TipoDocArca"))
            ? null
            : reader.GetString(reader.GetOrdinal("TipoDocArca"));

            c.NroDocumento = reader.IsDBNull(reader.GetOrdinal("NroDocumento"))
                ? null
                : reader.GetString(reader.GetOrdinal("NroDocumento"));

            c.NroIIBB = reader.IsDBNull(reader.GetOrdinal("NroIIBB"))
                ? null
                : reader.GetString(reader.GetOrdinal("NroIIBB"));

            c.CategoriaIva = reader.IsDBNull(reader.GetOrdinal("CategoriaIva"))
                ? null
                : reader.GetString(reader.GetOrdinal("CategoriaIva"));

            c.CondicionPago = reader.IsDBNull(reader.GetOrdinal("CondicionPago"))
                ? null
                : reader.GetString(reader.GetOrdinal("CondicionPago"));

            c.Descuento = reader.IsDBNull(reader.GetOrdinal("Descuento"))
                ? 0m
                : reader.GetDecimal(reader.GetOrdinal("Descuento"));

            c.Observaciones = reader.IsDBNull(reader.GetOrdinal("Observaciones"))
                ? null
                : reader.GetString(reader.GetOrdinal("Observaciones"));
            return c;
        }
    }
}
