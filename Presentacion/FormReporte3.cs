using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporte3 : Form
    {
        public FormReporte3()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string fecha = ObtenerDiaMayorPedidosDelivery();
            lblFecha.Text = fecha;
        }

        public string ObtenerDiaMayorPedidosDelivery()
        {
            string diaMayorPedidos = "";
            DateTime fechaa;
            List<ordenes> OrdenDelivery = new List<ordenes>();
            try
            {
                using (var context = new BDEFEntities()) 
                {
                    OrdenDelivery = context.ordenes.Where(o => o.sedes_codigo == 7).ToList();

                    if (OrdenDelivery.Any())
                    {
                        var DiaMayorPedidosDelivery = OrdenDelivery.GroupBy(o => o.fecha_entrega).OrderByDescending(o => o.Count());

                        fechaa = DiaMayorPedidosDelivery.First().Key;
                        diaMayorPedidos = fechaa.ToLongDateString();
                    }
                }
                return diaMayorPedidos;
            }
            catch (Exception ex)
            {
                return diaMayorPedidos;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
