using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Detalle
    {
        public Detalle(Articulo art)
        {
            Id = art.Id;
            Codigo = art.Codigo;
            Descripcion = art.Descripcion;
        }

        [Browsable(false)]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe => Cantidad * Precio;
    }
}
