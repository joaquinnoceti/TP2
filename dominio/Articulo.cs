using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    class Articulo
    {
        public int CodArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public Marca IDMarca { get; set; }
        public Categoria IDCategoria { get; set; }
        public string Imagen { get; set; }
        public float Precio { get; set; }

    }
}
