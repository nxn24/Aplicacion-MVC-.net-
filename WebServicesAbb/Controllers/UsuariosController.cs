using ABB.Catalogo.Entidades.Core;
using ABB.Catalogo.LogicaNegocio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebServicesAbb.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        public IEnumerable<Usuarios> Get()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = new UsuariosLN().ListarUsuarios();

            return usuarios;
        }

        // GET: api/Usuarios/5
        public string Get(int id)   //recuperar info
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody]string value)    //insertar info
        {
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]string value) //modificar info
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)      //eliminar info
        {
        }
    }
}
