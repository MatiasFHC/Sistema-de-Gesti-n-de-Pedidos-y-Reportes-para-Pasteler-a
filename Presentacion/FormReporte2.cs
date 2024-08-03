using Datos;
using Negocio;
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
    public partial class FormReporte2 : Form
    {
        private NOrdenes nOrdenes = new NOrdenes();
        public FormReporte2()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (dtFecha.Text == "")
            {
                MessageBox.Show("Seleccione una fecha");
                return;
            }

            DateTime fecha;
            fecha = dtFecha.Value.Date;
            int gananciaObtenida = nOrdenes.ObtenerGananciaPorFecha(fecha);
            lblGanancia.Text = gananciaObtenida.ToString();
        }
    }
}
