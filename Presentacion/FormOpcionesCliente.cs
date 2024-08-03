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
    public partial class FormOpcionesCliente : Form
    {
        private int codigo;

        public FormOpcionesCliente(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            FormCompraTortaDelivery form = new FormCompraTortaDelivery(codigo);
            form.Show();
        }

        private void btnCompletarEncuesta_Click(object sender, EventArgs e)
        {
            FormEncuestas form = new FormEncuestas(codigo);
            form.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
