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
    public partial class FormReporte5 : Form
    {
        private NOrdenes nOrdenes = new NOrdenes();
        private NUsuarios nUsuarios = new NUsuarios();
        private int codigo;
        private DateTime fechaa;

        public FormReporte5()
        {
            InitializeComponent();
        }

        private void MostrarOrdenes(List<ordenes> ordenes)
        {
            dgReporte5.DataSource = null;
            if (ordenes.Count == 0)
            {
                return;
            }
            else
            {
                dgReporte5.DataSource = ordenes;
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbCorreo.Text == "" || tbNombre.Text == "" || dtFecha.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }       

            string correo = tbCorreo.Text;
            string nombre = tbNombre.Text;
            fechaa = dtFecha.Value;           
            int codigoUsaurio = nUsuarios.ObtenerCodigo(correo, nombre);
            codigo = codigoUsaurio;

            MostrarOrdenes(nOrdenes.OrdenesPorFechaYUsuario(codigo, fechaa));
        }
    }
}
