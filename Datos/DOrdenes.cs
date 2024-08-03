using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DOrdenes
    {
        public String Registrar(ordenes orden)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.ordenes.Add(orden);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_ordenes)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    ordenes ordenTemp = context.ordenes.Find(id_ordenes);
                    context.ordenes.Remove(ordenTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<ordenes> ListarTodoPorCliente(int id_usuario)
        {
            List<ordenes> ordenes = new List<ordenes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.ordenes.Where(o => o.usuarios_codigo == id_usuario).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }

        public List<ordenes> ListarTodoPorAdministrador(int id_administrador)
        {
            List<ordenes> ordenes = new List<ordenes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenes = context.ordenes.Where(o => o.administradores_codigo == id_administrador).ToList();
                }
                return ordenes;
            }
            catch (Exception ex)
            {
                return ordenes;
            }
        }

        public int AsignarID()
        {
            List<int> ObtenerCodigos = new List<int>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    ObtenerCodigos = context.ordenes.Select(o => o.codigo).ToList();
                    int id_orden = 1;

                    while(ObtenerCodigos.Contains(id_orden))
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

        public List<int> ObtenerCodigosOrdenes(int sedeCodigo)
        {
            List<int> codigosObtenidos = new List<int>();
            List<ordenes> Orden = new List<ordenes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    Orden = context.ordenes.Where(o => o.sedes_codigo == sedeCodigo).ToList();
                }
                foreach (ordenes orden in Orden)
                {
                    codigosObtenidos.Add(orden.codigo);
                }
                return codigosObtenidos;
            }
            catch (Exception ex)
            {
                return codigosObtenidos;
            }
        }

        public int ObtenerGananciaPorFecha(DateTime fecha)
        {
            List<ordenes> ordenesSegunFecha = new List<ordenes>();
            int ganancia = 0;

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    ordenesSegunFecha = context.ordenes.Where(o => o.fecha_entrega == fecha).ToList();

                    ganancia = ordenesSegunFecha.Sum(o => o.precio);
                }
                return ganancia;
            }
            catch (Exception ex)
            {   
                return ganancia;
            }
        }

        public List<ordenes> OrdenesPorFechaYUsuario(int codigoUsuario, DateTime fechaa)
        {
            List<ordenes> Ordenes = new List<ordenes>();

            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;

                    Ordenes = context.ordenes.Where(o => o.usuarios_codigo == codigoUsuario
                    && o.fecha_entrega == fechaa.Date).ToList();
                }
                return Ordenes;
            }
            catch (Exception ex)
            {
                return Ordenes;
            }
        }
    }
}
