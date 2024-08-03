using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DTortas
    {
        public String Registrar(tortas torta)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.tortas.Add(torta);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<tortas> ListarTodo()
        {
            List<tortas> torta = new List<tortas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    torta = context.tortas.ToList();
                }
                return torta;
            }
            catch (Exception ex)
            {
                return torta;
            }
        }

        public String Eliminar(int id_ordenes)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    tortas ordenTemp = context.tortas.Find(id_ordenes);
                    context.tortas.Remove(ordenTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public int AsignarID()
        {
            List<int> ObtenerCodigos = new List<int>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    ObtenerCodigos = context.tortas.Select(o => o.codigo).ToList();
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
