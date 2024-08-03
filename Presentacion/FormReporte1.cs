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
    public partial class FormReporte1 : Form
    {
        private NOrdenes nOrdenes = new NOrdenes();
        public FormReporte1()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (cbSede.Text == "")
            {
                MessageBox.Show("Seleccione una sede");
                return;
            }

            String sede = cbSede.Text;
            int Sedes_codigo = 0;

            if (cbSede.Text == "Surco")
            {
                Sedes_codigo = 1;
            }
            if (cbSede.Text == "La Molina")
            {
                Sedes_codigo = 2;
            }
            if (cbSede.Text == "Villa María del Triunfo")
            {
                Sedes_codigo = 3;
            }
            if (cbSede.Text == "Manchay")
            {
                Sedes_codigo = 4;
            }
            if (cbSede.Text == "Independencia")
            {
                Sedes_codigo = 5;
            }
            if (cbSede.Text == "Los Olivos")
            {
                Sedes_codigo = 6;
            }

            List<int> codigosObtenidos = nOrdenes.ObtenerCodigosOrdenes(Sedes_codigo);

            string sabor = ObtenerSaborMasRepetido(codigosObtenidos);
            lblsabor.Text = sabor.ToString();
        }

        private string ObtenerSaborMasRepetido(List<int> codigosOrdenes)
        {
            string sabor = "Sin ordenes";
            List<tortas> todasLasOrdenes = new List<tortas>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    todasLasOrdenes = context.tortas.Where(t => codigosOrdenes.Contains(t.ordenes_codigo)).ToList();

                    if (todasLasOrdenes.Any())
                    {
                        var saborMasRepetido = todasLasOrdenes.GroupBy(t => t.sabor).OrderByDescending(s => s.Count());

                        sabor = saborMasRepetido.First().Key;
                    }
                }
                return sabor;
            }
            catch (Exception ex)
            {
                return sabor;
            }
        }

        private void lblsabor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
