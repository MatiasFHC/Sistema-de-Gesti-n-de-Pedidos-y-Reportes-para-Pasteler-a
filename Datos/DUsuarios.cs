using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuarios
    {
        public String Registrar(usuarios usuario)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.usuarios.Add(usuario);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<usuarios> ListarTodo()
        {
            List<usuarios> usuario = new List<usuarios>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuario = context.usuarios.ToList();
                }
                return usuario;
            }
            catch (Exception ex)
            {
                return usuario;
            }
        }

        public bool ValidarCredenciales(string correoo, string contrasenaa)
        {
            bool validacion = false;
            try
            {
                using (var context = new BDEFEntities())
                {
                    validacion = context.usuarios.Any(u => u.correo == correoo && u.contrasena == contrasenaa);
                }
                return validacion;
            }
            catch (Exception ex)
            {
                return validacion;
            }
        }

        public int CantidadUsuarios()
        {
            List<int> ObtenerCodigos = new List<int>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    ObtenerCodigos = context.usuarios.Select(u => u.codigo).ToList();
                    int id_orden = 1;

                    while (ObtenerCodigos.Contains(id_orden))
                    {
                        id_orden++;
                    }
                    return id_orden;
                }
            }
            catch (Exception ex)
            {
                return -5;
            }
        }

        public int ObtenerCodigo(string correoo, string nombree)
        {
            List<int> Usuario = new List<int>();
            int codigoUsuario = 0;

            try
            {
                using (var context = new BDEFEntities()) 
                {
                    Usuario = context.usuarios.Where(u => u.correo == correoo && u.nombre == nombree).Select(u => u.codigo).ToList();
                }
                if(Usuario.Any())
                {
                    codigoUsuario = Usuario[0];
                }
                return codigoUsuario;
            }
            catch (Exception ex)
            {
                return codigoUsuario;
            }
        }
    }
}
