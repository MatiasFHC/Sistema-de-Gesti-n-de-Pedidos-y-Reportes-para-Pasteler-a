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
    public partial class FormNivelUsuario : Form
    {
        public FormNivelUsuario()
        {
            InitializeComponent();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            FormSesionAdmin form = new FormSesionAdmin();
            form.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormSesionCliente form = new FormSesionCliente();
            form.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
