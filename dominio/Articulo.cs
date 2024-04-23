using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {   
        public int ID { get; set; }
        public string CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marca IDMarca { get; set; }
        public Categoria IDCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }

    }
}
