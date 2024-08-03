using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTortas
    {
        private DTortas dTortas = new DTortas();

        public String Registrar(tortas torta)
        {
            return dTortas.Registrar(torta);
        }

        public List<tortas> ListarTodo()
        {
            return dTortas.ListarTodo();
        }
        public int AsignarID()
        {
            return dTortas.AsignarID();
        }
        public String Eliminar(int id_ordenes)
        {
            return dTortas.Eliminar(id_ordenes);
        }

    }
}
