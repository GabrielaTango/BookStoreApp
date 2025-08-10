using Models;
using System;

public class ComprobanteDetalle
{
    public int Id { get; set; }

    public int FacturaId { get; set; }

    public int ArticuloId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Subtotal { get; set; }

    public string Descripcion { get; set; }
}
