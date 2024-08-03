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
    public partial class FormSesionCliente : Form
    {
        private NUsuarios nUsarios = new NUsuarios();
        public FormSesionCliente()
        {
            InitializeComponent();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            if (tbCorreo.Text == "" || tbContrasena.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            string correo = tbCorreo.Text;
            string contrasena = tbContrasena.Text;

            if (nUsarios.ValidarCredenciales(correo, contrasena))
            {
                int codigo = ObtenerCodigoUsuario(correo, contrasena);
                if(codigo != -5)
                {
                    FormOpcionesCliente form = new FormOpcionesCliente(codigo);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña mal ingresados");
            }
        }

        private int ObtenerCodigoUsuario(string correoo, string contrasenaa)
        {
            List<usuarios> Usuario = new List<usuarios>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    Usuario = context.usuarios.Where(u => u.correo == correoo && u.contrasena == contrasenaa).ToList();

                    if (Usuario.Count > 0)
                    {
                        return Usuario[0].codigo;
                    }
                    else
                    {
                        return -5;
                    }
                }
            }
            catch (Exception ex)
            {
                return -5;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            FormNuevoCliente form = new FormNuevoCliente();
            form.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
