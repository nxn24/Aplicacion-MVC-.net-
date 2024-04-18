using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.Catalogo.Entidades.Core
{
    public class Usuarios
    {
        // Define una propiedad pública.Con tipo de dato int y tiene métodos get y set para acceder y modificar.
        public int IdUsuario { get; set; } 
        public String CodUsuario { get; set; }
        public String ClaveTxt { get; set; }
        public byte[] Clave { get; set; }
        public String Nombres { get; set; }
        public int IdRol { get; set; }
        public String DesRol { get; set; }

    }
}
