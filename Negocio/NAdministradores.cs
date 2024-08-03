using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAdministradores
    {
        private DAdministradores dAdministradores = new DAdministradores();

        public List<administradores> ListarTodo()
        {
            return dAdministradores.ListarTodo();
        }

        public bool ValidarCredenciales(string correoo, string contrasenaa)
        {
            return dAdministradores.ValidarCredenciales(correoo, contrasenaa);
        }

        public int CantidadUsuarios()
        {
            return dAdministradores.CantidadUsuarios();
        }
    }
}
