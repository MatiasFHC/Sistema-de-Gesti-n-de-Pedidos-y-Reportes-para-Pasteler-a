using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuarios
    {
        private DUsuarios dUsuario = new DUsuarios();

        public String Registrar(usuarios usuario)
        {
            return dUsuario.Registrar(usuario);
        }

        public List<usuarios> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }

        public bool ValidarCredenciales(string correoo, string contrasenaa)
        {
            return dUsuario.ValidarCredenciales(correoo, contrasenaa);
        }

        public int CantidadUsuarios()
        {
            return dUsuario.CantidadUsuarios();
        }

        public int ObtenerCodigo(string correoo, string nombree)
        {
            return dUsuario.ObtenerCodigo(correoo, nombree);
        }
    }
}
