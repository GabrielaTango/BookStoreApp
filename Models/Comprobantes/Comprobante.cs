using Models;
using System;

public class Comprobante
{
    public int Id { get; set; }

    public int ClienteId { get; set; }

    public DateTime Fecha { get; set; }

    public string TipoComprobante { get; set; }  // Ej: "A", "B", "NC"

    public string NumeroComprobante { get; set; }  // Ej: "0001-00000001"

    public decimal Total { get; set; }
    public string? CAE { get; set; }
    public DateTime? VTO { get; set; }
}
