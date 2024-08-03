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
    public partial class FormMetodoPagoYape : Form
    {
        private double precio;
        public FormMetodoPagoYape(double precio)
        {
            InitializeComponent();
            this.precio = precio;
            string cantidad = precio.ToString();
            lblImporte.Text = cantidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMetodoPagoTarjeta form = new FormMetodoPagoTarjeta(precio);
            form.Show();
            this.Close();
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado");
            this.Close();
        }
    }
}
