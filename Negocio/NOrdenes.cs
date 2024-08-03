using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NOrdenes
    {
        private DOrdenes dOrden = new DOrdenes();

        public String Registrar(ordenes orden)
        {
            return dOrden.Registrar(orden);
        }

        public String Eliminar(int id_ordenes)
        {
            return dOrden.Eliminar(id_ordenes);
        }

        public List<ordenes> ListarTodoPorCliente(int id_usuario)
        {
            return dOrden.ListarTodoPorCliente(id_usuario);
        }

        public List<ordenes> ListarTodoPorAdministrador(int id_administrador)
        {
            return dOrden.ListarTodoPorAdministrador(id_administrador);
        }

        public int AsignarID()
        {
            return dOrden.AsignarID();
        }
        public List<int> ObtenerCodigosOrdenes(int sedeCodigo)
        {
            return dOrden.ObtenerCodigosOrdenes(sedeCodigo);
        }

        public int ObtenerGananciaPorFecha(DateTime fecha)
        {
            return dOrden.ObtenerGananciaPorFecha(fecha);
        }

        public List<ordenes> OrdenesPorFechaYUsuario(int codigo, DateTime fechaa)
        {
            return dOrden.OrdenesPorFechaYUsuario(codigo, fechaa);
        }
    }
}
