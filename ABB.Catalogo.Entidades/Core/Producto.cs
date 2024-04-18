using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.Catalogo.Entidades.Core
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public String NomProducto { get; set; }
        public String MarcaProducto { get; set; }
        public String ModeloProducto { get; set; }
        public String LineaProducto { get; set; }
        public String GarantiaProducto { get; set; }
        public decimal? Precio { get; set; }
        public byte[] Imagen { get; set; }
        public String DescripcionTecnica { get; set; }
    }
}
