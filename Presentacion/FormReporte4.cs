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
    public partial class FormReporte4 : Form
    {
        private NEncuestas nEncuestas = new NEncuestas();
        public FormReporte4()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFrecuencia_Click(object sender, EventArgs e)
        {
            string frecuencia = nEncuestas.ObtenerMayorFrecuencia();
            lblFrecuecnia.Text = frecuencia;
        }

        private void btTipo_Click(object sender, EventArgs e)
        {
            string tipo = nEncuestas.ObtenerTipoTortaMasPedido();
            lbltio.Text = tipo;
        }

        private void btOcasion_Click(object sender, EventArgs e)
        {
            string ocasion = nEncuestas.ObtenerMayorOcasionDeCompra();
            lblocasion.Text = ocasion;
        }

        private void btSabor_Click(object sender, EventArgs e)
        {
            string sabor = nEncuestas.ObtenerSaborMasPedido();
            lblsabor.Text = sabor;
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
