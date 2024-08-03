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
    public partial class FormOpcionesAdmin : Form
    {
        private int codigo;
        public FormOpcionesAdmin(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void btnPedidoEventos_Click(object sender, EventArgs e)
        {
            FormRegistroParaEvento form = new FormRegistroParaEvento(codigo);
            form.Show();
        }

        private void btnPedidoLocal_Click(object sender, EventArgs e)
        {
            FormRegistroEnLocal form = new FormRegistroEnLocal(codigo);
            form.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaboresPopulares_Click(object sender, EventArgs e)
        {
            FormReporte1 form = new FormReporte1();
            form.Show();
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            FormReporte2 form = new FormReporte2();
            form.Show();
        }

        private void btnDiasMayoresVentasDelivery_Click(object sender, EventArgs e)
        {
            FormReporte3 form = new FormReporte3();
            form.Show();
        }

        private void btnEventosMayorDemanda_Click(object sender, EventArgs e)
        {
            FormReporte4 form = new FormReporte4();
            form.Show();
        }

        private void btnEncuestas_Click(object sender, EventArgs e)
        {
            FormReporte5 form = new FormReporte5();
            form.Show();
        }
    }
}
