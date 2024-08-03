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
    public partial class FormSesionAdmin : Form
    {
        private NAdministradores nAdministradores = new NAdministradores();

        public FormSesionAdmin()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (tbCorreo.Text == "" || tbContrasena.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            string correo = tbCorreo.Text;
            string contrasena = tbContrasena.Text;

            if (nAdministradores.ValidarCredenciales(correo, contrasena))
            {
                int codigo = ObtenerCodigoAdministrador(correo, contrasena);
                if (codigo != -5)
                {
                    FormOpcionesAdmin form = new FormOpcionesAdmin(codigo);
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

        private int ObtenerCodigoAdministrador(string correoo, string contrasenaa)
        {
            List<administradores> Administrador = new List<administradores>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    Administrador = context.administradores.Where(a => a.correo == correoo && a.contrasena == contrasenaa).ToList();

                    if(Administrador.Count > 0)
                    {
                        return Administrador[0].codigo;
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

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
