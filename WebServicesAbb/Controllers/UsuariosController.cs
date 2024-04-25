using ABB.Catalogo.Entidades.Core;
using ABB.Catalogo.LogicaNegocio.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

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
        public int Get([FromUri] string pUsuario, [FromUri] string pPassword)   //recuperar info
        {
            try { 
                UsuariosLN usuario = new UsuariosLN();
                return usuario.GetUsuarioId(pUsuario,pPassword);
            } 
            catch(Exception ex) {
                string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
                //Logger.Escribir("Error en la logica del negocio: " + ex.Message + "." + ex.StackTrace + "." + innerException);
                return -1;
            }
        }

        // POST: api/Usuarios
        public void Post([FromBody]Usuarios value)    //insertar info
        {
            Usuarios usuarios = new UsuariosLN().InsertarUsuario(value);
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]Usuarios value) //modificar info
        {
            Usuarios usuarios = new Usuarios();
            usuarios = new UsuariosLN().ModificarUsuario(id, value);

        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)      //eliminar info
        {
            new UsuariosLN().EliminarUsuario(id);

        }

    }
}
