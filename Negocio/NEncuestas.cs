using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEncuestas
    {
        private DEncuestas dEncuestas = new DEncuestas();

        public String Registrar(encuestas encuesta)
        {
            return dEncuestas.Registrar(encuesta);
        }

        public List<encuestas> ListarTodo()
        {
            return dEncuestas.ListarTodo();
        }

        public int Cantidads()
        {
            return dEncuestas.Cantidads();
        }

        public string ObtenerMayorFrecuencia()
        {
            return dEncuestas.ObtenerMayorFrecuencia();
        }

        public string ObtenerTipoTortaMasPedido()
        {
            return dEncuestas.ObtenerTipoTortaMasPedido();
        }

        public string ObtenerMayorOcasionDeCompra()
        {
            return dEncuestas.ObtenerMayorOcasionDeCompra();
        }

        public string ObtenerSaborMasPedido()
        {
            return dEncuestas.ObtenerSaborMasPedido();
        }
    }
}
