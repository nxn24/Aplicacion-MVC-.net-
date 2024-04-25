using ABB.Catalogo.Entidades.Core;
using ABB.Catalogo.AccesoDatos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Catalogo.Entidades.Base;


namespace ABB.Catalogo.LogicaNegocio.Core
{
    public class UsuariosLN : BaseLN
    {
        public List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> lista = new List<Usuarios>();
            try
            {
                UsuariosDA usuarios = new UsuariosDA();
                return usuarios.ListarUsuarios();


            }
            catch (Exception ex)
            {
                string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
                //Logger.Escribir("Error en Logica de Negocio: " + ex.Message + ". " + ex.StackTrace + ". " + innerException);
                return lista;
            }
        }

        public int GetUsuarioId(string pUsuario, string pPassword)
        {
            try { 
                UsuariosDA usuarios = new UsuariosDA();
                return usuarios.GetUsuarioId(pUsuario,pPassword);
            }
            catch(Exception ex) { 
                string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
                //Logger.Escribir("Error en Logica de Negocio: " + ex.Message + ". " + ex.StackTrace + ". " + innerException);
                return -1;
            }
        }

        public Usuarios InsertarUsuario(Usuarios usuarios)
        {
            try
            {
                return new UsuariosDA().InsertarUsuario(usuarios);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;

            }
        }

        public Usuarios ModificarUsuario(int IdUsuario, Usuarios usuarios)
        {
            try
            {
                return new UsuariosDA().ModificarUsuario(IdUsuario, usuarios);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;

            }
        }

        public void EliminarUsuario(int idUsuario)
        {
            try
            {
                new UsuariosDA().EliminarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }


    }
}
