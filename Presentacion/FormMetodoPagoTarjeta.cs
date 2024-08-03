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
    public partial class FormMetodoPagoTarjeta : Form
    {
        private double precio;
        public FormMetodoPagoTarjeta(double precio)
        {
            InitializeComponent();
            this.precio = precio;
            string cantidad = precio.ToString();
            lblImporte.Text = cantidad;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {            
            if (tbcvv.Text == "" || tbnombre.Text == "" || tbNumeroTarjeta.Text == "" ||
                dateTimePicker1.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            long NumeroTarjeta = 0;
            try
            {
                NumeroTarjeta = long.Parse(tbNumeroTarjeta.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el numero de la tarjeta correctamente");
                return;
            }

            int CVV = 0;
            try
            {
                CVV = int.Parse(tbcvv.Text);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el CVV correctamente");
                return;
            }
            if (tbcvv.Text.Length != 3)
            {
                MessageBox.Show("El CVV debe contener exactamente 3 dígitos");
                return;
            }
            MessageBox.Show("Pago realizado");
            this.Close();
        }

        private void btYape_CheckedChanged(object sender, EventArgs e)
        {
            FormMetodoPagoYape form = new FormMetodoPagoYape(precio);
            form.Show();
            this.Close();
        }
    }
}
