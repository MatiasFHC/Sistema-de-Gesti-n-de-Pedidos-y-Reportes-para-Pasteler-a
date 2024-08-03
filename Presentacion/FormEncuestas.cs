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
    public partial class FormEncuestas : Form
    {
        private int codigo_usuario;
        private NEncuestas nEncuestas = new NEncuestas();

        public FormEncuestas(int codigo_usuario)
        {
            InitializeComponent();
            this.codigo_usuario = codigo_usuario;
        }

        private void btTerminar_Click(object sender, EventArgs e)
        {
            if ((!cbChocoalte.Checked && !cbVainilla.Checked && !cbLucuma.Checked &&
                !cbCoco.Checked && !cbFresa.Checked) || (!cbDiario.Checked &&
                !cbSemanal.Checked && !cbMensual.Checked && !cbOcasional.Checked &&
                !cbRaramente.Checked) || (!cbFondant.Checked && !cbCremaMantequilla.Checked &&
                !cbFrutas.Checked && !cbChocoalte.Checked && !cbDulces.Checked) ||
                (!cbCumpleaños.Checked && !cbBodas.Checked && !cbAniversario.Checked &&
                !cbCelebraciones.Checked && !cbSinOcasion.Checked))
            {
                MessageBox.Show("Debe seleccionar una opcion en cada pregunta");
                return;
            }

            int cont1 = 0;
            string sabor1 = "";
            if (cbChocoalte.Checked) { cont1++; }
            if (cbVainilla.Checked) { cont1++; }
            if (cbLucuma.Checked) { cont1++; }
            if (cbCoco.Checked) { cont1++; }
            if (cbFresa.Checked) { cont1++; }

            if (cont1 > 1)
            {
                MessageBox.Show("Debe seleccionar una opcion en la pregunta 1");
                return;
            }
            else
            {
                if (cbChocoalte.Checked) { sabor1 = "Chocolate"; }
                if (cbVainilla.Checked) { sabor1 = "Vainilla"; }
                if (cbLucuma.Checked) { sabor1 = "Lucuma"; }
                if (cbCoco.Checked) { sabor1 = "Coco"; }
                if (cbFresa.Checked) { sabor1 = "Fresa"; }
            }

            int cont2 = 0;
            string sabor2 = "";
            if (cbDiario.Checked) { cont2++; }
            if (cbSemanal.Checked) { cont2++; }
            if (cbMensual.Checked) { cont2++; }
            if (cbRaramente.Checked) { cont2++; }
            if (cbOcasional.Checked) { cont2++; }

            if (cont2 > 1)
            {
                MessageBox.Show("Debe seleccionar una opcion en la pregunta 2");
                return;
            }
            else
            {
                if (cbDiario.Checked) { sabor2 = "Diariamente"; }
                if (cbSemanal.Checked) { sabor2 = "Semanalmente"; }
                if (cbMensual.Checked) { sabor2 = "Mensualmente"; }
                if (cbRaramente.Checked) { sabor2 = "Raramente"; }
                if (cbOcasional.Checked) { sabor2 = "Ocasionalmente"; }
            }

            int cont3 = 0;
            string sabor3 = "";
            if (cbFondant.Checked) { cont3++; }
            if (cbFrutas.Checked) { cont3++; }
            if (cbCremaMantequilla.Checked) { cont3++; }
            if (cbChocoalte.Checked) { cont3++; }
            if (cbDulces.Checked) { cont3++; }

            if (cont3 > 1)
            {
                MessageBox.Show("Debe seleccionar una opcion en la pregunta 3");
                return;
            }
            else
            {
                if (cbFondant.Checked) { sabor3 = "Fondant"; }
                if (cbFrutas.Checked) { sabor3 = "Frutas frescas"; }
                if (cbCremaMantequilla.Checked) { sabor3 = "Crema de mantequilla"; }
                if (cbChocoalte.Checked) { sabor3 = "Chocolates"; }
                if (cbDulces.Checked) { sabor3 = "Dulces"; }
            }

            int cont4 = 0;
            string sabor4 = "";
            if (cbAniversario.Checked) { cont4++; }
            if (cbSinOcasion.Checked) { cont4++; }
            if (cbBodas.Checked) { cont4++; }
            if (cbCelebraciones.Checked) { cont4++; }
            if (cbCumpleaños.Checked) { cont4++; }

            if (cont4 > 1)
            {
                MessageBox.Show("Debe seleccionar una opcion en la pregunta 4");
                return;
            }
            else
            {
                if (cbAniversario.Checked) { sabor4 = "Aniversarios"; }
                if (cbSinOcasion.Checked) { sabor4 = "Sin ocasion especial"; }
                if (cbBodas.Checked) { sabor4 = "Bodas"; }
                if (cbCelebraciones.Checked) { sabor4 = "Celebraciones familiares"; }
                if (cbCumpleaños.Checked) { sabor4 = "Cumpleaños"; }
            }

            int cantidad = nEncuestas.Cantidads();

            encuestas encuesta = new encuestas()
            {
                codigo = cantidad,
                preguntas = "",
                usuarios_codigo = codigo_usuario,
                frecuencia = sabor2,
                tipo = sabor3,
                ocasion = sabor4,
                sabor = sabor1,
            };

            String mensaje = nEncuestas.Registrar(encuesta);
            MessageBox.Show(mensaje);

            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
