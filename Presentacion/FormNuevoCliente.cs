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
    public partial class FormNuevoCliente : Form
    {
        private NUsuarios nUsarios = new NUsuarios();

        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || dtFechaNacimiento.Text == "" || tbCorreo.Text == "" ||
                tbContrasena.Text == "" || tbConfirmacionContrasena.Text == "" ||
                tbDireccion.Text == "" || cbDistritos.Text == "" || tbDNI.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (tbNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre debe tener minimo 3 letras");
                return;
            }

            int DNI;
            try
            {
                DNI = int.Parse(tbDNI.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("El DNI no puede tener letras ni signos");
                return;
            }
            if (tbDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos");
                return;
            }

            if(!tbCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un arroba");
                return;
            }

            if (tbContrasena.Text != tbConfirmacionContrasena.Text)
            {
                MessageBox.Show("Ingrese la misma contraseña");
                return;
            }

            int cantidad = nUsarios.CantidadUsuarios();

            usuarios usuario = new usuarios()
            {
                codigo = cantidad,
                nombre = tbNombre.Text,
                fecha_de_nacimiento = dtFechaNacimiento.Value,
                correo = tbCorreo.Text,
                contrasena = tbContrasena.Text,
                direccion = tbDireccion.Text,
                distrito = cbDistritos.Text,
                dni = tbDNI.Text,
            };

            String mensaje = nUsarios.Registrar(usuario);
            MessageBox.Show(mensaje);

            this.Close();

            FormOpcionesCliente form = new FormOpcionesCliente(cantidad);
            form.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
