using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Precio
    {
        public int Id { get; set; }

        [Browsable(false)]
        public int? Lista_Id { get; set; }     // FK a listas.id
         // mapea a columna `Precio` (DECIMAL(17,2))
        [Browsable(false)]
        //Articulo
        public int? Articulo_Id { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public decimal? Importe { get; set; }

    }
}


