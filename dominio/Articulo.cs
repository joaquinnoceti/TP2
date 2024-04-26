using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio

{

    public class Articulo
    {   
        public int ID { get; set; }
        [DisplayName("Código")]
        public string CodArticulo { get; set; }
        [DisplayName("Nombre")]
        public string NombreArticulo { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }

    }
}
