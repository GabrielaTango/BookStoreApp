using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PrecioService : Service<PrecioRepository,Precio>
    {
        public PrecioService() 
        {

        }

        public bool Existe(Precio p)
        {
            var param = $@"  WHERE Lista_Id = {p.Lista_Id} and Articulo_Id = {p.Articulo_Id}";
            if(GetQuery(param).Count() > 0)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<Precio> GetPorLista(int lista) { 
            return GetQuery(" " +
                    $"INNER JOIN listas on listas.id = precios.lista_id WHERE precios.lista_id = {lista}");
        }

        public decimal GetPrecio(int lista, int articulo_id)
        {
            var articulo = GetQuery(" " +
                    $"INNER JOIN listas on listas.id = precios.lista_id WHERE precios.lista_id = {lista} and precios.Articulo_id = {articulo_id}").FirstOrDefault();

            if (articulo != null)
                return articulo.Importe.GetValueOrDefault(0);

            return 0;
        }

    }
}
