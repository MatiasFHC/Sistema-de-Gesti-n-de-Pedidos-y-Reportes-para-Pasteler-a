using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEncuestas
    {
        public String Registrar(encuestas encuesta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.encuestas.Add(encuesta);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<encuestas> ListarTodo()
        {
            List<encuestas> encuesta = new List<encuestas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    encuesta = context.encuestas.ToList();
                }
                return encuesta;
            }
            catch (Exception ex)
            {
                return encuesta;
            }
        }

        public int Cantidads()
        {
            List<int> ObtenerCodigos = new List<int>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    ObtenerCodigos = context.encuestas.Select(e => e.codigo).ToList();
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

        public string ObtenerMayorFrecuencia()
        {
            string frecuenciaMasRepetida = "";
            List<encuestas> EncuestaFrecuencia = new List<encuestas>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    EncuestaFrecuencia = context.encuestas.ToList();

                    var FrecuenciaMasRepetida = EncuestaFrecuencia.GroupBy(o => o.frecuencia).OrderByDescending(o => o.Count());
                    frecuenciaMasRepetida = FrecuenciaMasRepetida.First().Key;
                }
                return frecuenciaMasRepetida;
            }
            catch (Exception ex)
            {
                return frecuenciaMasRepetida;
            }
        }

        public string ObtenerTipoTortaMasPedido()
        {
            string tipoTortaMasPedido = "";
            List<encuestas> EncuestaTipo = new List<encuestas>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    EncuestaTipo = context.encuestas.ToList();

                    var TipoMasRepetido = EncuestaTipo.GroupBy(o => o.tipo).OrderByDescending(o => o.Count());
                    tipoTortaMasPedido = TipoMasRepetido.First().Key;
                }
                return tipoTortaMasPedido;
            }
            catch (Exception ex)
            {
                return tipoTortaMasPedido;
            }
        }

        public string ObtenerMayorOcasionDeCompra()
        {
            string mayorOcasionDeCompra = "";
            List<encuestas> EncuestaOcasion = new List<encuestas>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    EncuestaOcasion = context.encuestas.ToList();

                    var OcasionMasRepetida = EncuestaOcasion.GroupBy(o => o.ocasion).OrderByDescending(o => o.Count());
                    mayorOcasionDeCompra = OcasionMasRepetida.First().Key;
                }
                return mayorOcasionDeCompra;
            }
            catch (Exception ex)
            {
                return mayorOcasionDeCompra;
            }
        }

        public string ObtenerSaborMasPedido()
        {
            string saborMasPedido = "";
            List<encuestas> EncuestaSabor = new List<encuestas>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    EncuestaSabor = context.encuestas.ToList();

                    var SaborMasRepetido = EncuestaSabor.GroupBy(o => o.sabor).OrderByDescending(o => o.Count());
                    saborMasPedido = SaborMasRepetido.First().Key;
                }
                return saborMasPedido;
            }
            catch (Exception ex)
            {
                return saborMasPedido;
            }
        }
    }
}
