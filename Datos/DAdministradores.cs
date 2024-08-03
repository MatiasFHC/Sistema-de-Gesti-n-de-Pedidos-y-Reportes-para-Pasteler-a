using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAdministradores
    {
        public List<administradores> ListarTodo()
        {
            List<administradores> administrador = new List<administradores>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    administrador = context.administradores.ToList();
                }
                return administrador;
            }
            catch (Exception ex)
            {
                return administrador;
            }
        }

        public bool ValidarCredenciales(string correoo, string contrasenaa)
        {
            bool validacion = false;
            try
            {
                using (var context = new BDEFEntities())
                {
                    validacion = context.administradores.Any(u => u.correo == correoo && u.contrasena == contrasenaa);
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
                    ObtenerCodigos = context.administradores.Select(a => a.codigo).ToList();
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
    }
}
