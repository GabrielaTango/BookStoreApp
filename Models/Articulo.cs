using System.ComponentModel;

namespace Models
{
    public sealed class Articulo
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }          // varchar(25)
        public string? Descripcion { get; set; }     // varchar(100)
        public string? CodBarras { get; set; }       // varchar(13)
        public string? Observaciones { get; set; }   // varchar(2000)
        public int? Tomos { get; set; }              // int
        public string? Tema { get; set; }            // varchar(50)
    }
}
