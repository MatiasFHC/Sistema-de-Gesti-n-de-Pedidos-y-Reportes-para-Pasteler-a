using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCompraTortaDelivery : Form
    {
        private NTortas nTortas = new NTortas();
        private int codigo_usuario;
        private int cont;
        private double Precioooo;
        private NOrdenes nOrdenes = new NOrdenes();

        public FormCompraTortaDelivery(int codigo_usuario)
        {
            InitializeComponent();         
            this.codigo_usuario = codigo_usuario;
            MostrarOrdenes(nOrdenes.ListarTodoPorCliente(codigo_usuario));
        }

        private void MostrarOrdenes(List<ordenes> orden)
        {
            dgordenes.DataSource = null;
            if (orden.Count == 0)
            {
                return;
            }
            else
            {
                dgordenes.DataSource = orden;
            }
        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgordenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_orden = int.Parse(dgordenes.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje1 = nTortas.Eliminar(id_orden);
            String mensaje = nOrdenes.Eliminar(id_orden);
            MessageBox.Show(mensaje);

            ObtenerNuevosValores();

            MostrarOrdenes(nOrdenes.ListarTodoPorCliente(codigo_usuario));    
            if(dgordenes.Rows.Count == 0)
            {
                int num = 0;
                lblSubtotal.Text = num.ToString();
                lblIGV.Text = num.ToString();
                lblDelivery.Text = num.ToString();
                lblTotal.Text = num.ToString();
                cont = 0;
            }
        }

        private void ObtenerNuevosValores()
        {
            List<ordenes> Orden = new List<ordenes>();

            double subtotal = 0;
            double igv = 0;
            double total = 0;
            int delivery = 15; 

            int cont1 = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    Orden = context.ordenes.Where(o => o.usuarios_codigo == codigo_usuario).ToList();

                    foreach (ordenes orden in Orden)
                    {
                        subtotal += orden.precio;
                        igv += orden.precio * 0.18;
                    }
                    if(cont1 == 0)
                    {
                        total += subtotal + igv + delivery;
                        cont++;
                    }
                    else
                    {
                        total += subtotal + igv;                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return;
            }
            Precioooo = total;
            lblSubtotal.Text = subtotal.ToString();
            lblIGV.Text = igv.ToString();
            lblDelivery.Text = delivery.ToString();
            lblTotal.Text = total.ToString();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (tbDireccion.Text == "" || cbDistritos.Text == "" || tbCantidad.Text == "" ||
                dtFecha.Text == "" || cbSabor.Text == "" || cbTamaño.Text == "" || cbTematica.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int cant = 0;
            try
            {
                cant = int.Parse(tbCantidad.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos correctamente");
                return;
            }

            int cantidad = nOrdenes.AsignarID();

            double precioOrden = CalcularPrecioTotal(cant);
            Precioooo = precioOrden;

            int precioTemp = CalcularPrecioOrdenIndividual(cant);

            ordenes orden = new ordenes()
            {
                codigo = cantidad,
                fecha_entrega = dtFecha.Value,
                direccion = tbDireccion.Text,
                distrito = cbDistritos.Text,
                cantidad = cant,
                precio = precioTemp, 
                //setear
                usuarios_codigo = codigo_usuario,
                administradores_codigo = 2,
                pagos_codigo = 1,
                sedes_codigo = 7,
            };

            int cantidad2 = nTortas.AsignarID();
            tortas torta = new tortas()
            {
                codigo = cantidad2,
                nombre = "Name",
                sabor = cbSabor.Text,
                tematica = cbTematica.Text,
                tamano = cbTamaño.Text,
                ordenes_codigo = cantidad,
            };

            String mensaje = nOrdenes.Registrar(orden);
            String mensaje1 = nTortas.Registrar(torta);
            MessageBox.Show(mensaje);

            MostrarOrdenes(nOrdenes.ListarTodoPorCliente(codigo_usuario));
        }       

        private double CalcularPrecioTotal(int cant)
        {
            int precioTemp = CalcularPrecioOrdenIndividual(cant);

            double subtotal = double.Parse(lblSubtotal.Text);
            double igv = double.Parse(lblIGV.Text);
            double delivery = double.Parse(lblDelivery.Text);
            double total = double.Parse(lblTotal.Text);
            
            subtotal += precioTemp;           
            igv += (precioTemp * 0.18);
            delivery = 15;

            if (cont == 0)
            {
                total += (precioTemp + (precioTemp * 0.18) + delivery);
                cont++;
            }
            else
            {
                total += (precioTemp + (precioTemp * 0.18));
            }

            lblSubtotal.Text = subtotal.ToString();
            lblIGV.Text = igv.ToString();
            lblDelivery.Text = delivery.ToString(); 
            lblTotal.Text = total.ToString();

            return total;
        }

        private int CalcularPrecioOrdenIndividual(int cant)
        {
            string sabor = cbSabor.Text;
            string tamaño = cbTamaño.Text;

            int precio = 0;

            //Canddy
            if (sabor == "Canddy" && tamaño == "Mini")
            {
                precio = 30;
            }
            if (sabor == "Canddy" && tamaño == "Chica")
            {
                precio = 40;
            }
            if (sabor == "Canddy" && tamaño == "Mediana")
            {
                precio = 50;
            }
            if (sabor == "Canddy" && tamaño == "Grande")
            {
                precio = 62;
            }
            if (sabor == "Canddy" && tamaño == "Naked")
            {
                precio = 72;
            }


            //Sublime
            if (sabor == "Sublime" && tamaño == "Mini")
            {
                precio = 25;
            }
            if (sabor == "Sublime" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Sublime" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Sublime" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Sublime" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Moccaccino
            if (sabor == "Moccaccino" && tamaño == "Mini")
            {
                precio = 25;
            }
            if (sabor == "Moccaccino" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Moccaccino" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Moccaccino" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Moccaccino" && tamaño == "Naked")
            {
                precio = 65;
            }


            //Torta Helada
            if (sabor == "Torta Helada" && tamaño == "Mini")
            {
                precio = 20;
            }
            if (sabor == "Torta Helada" && tamaño == "Chica")
            {
                precio = 24;
            }
            if (sabor == "Torta Helada" && tamaño == "Mediana")
            {
                precio = 34;
            }
            if (sabor == "Torta Helada" && tamaño == "Grande")
            {
                precio = 42;
            }
            if (sabor == "Torta Helada" && tamaño == "Naked")
            {
                precio = 52;
            }

            //Red Velvet
            if (sabor == "Red Velvet" && tamaño == "Mini")
            {
                precio = 36;
            }
            if (sabor == "Red Velvet" && tamaño == "Chica")
            {
                precio = 36;
            }
            if (sabor == "Red Velvet" && tamaño == "Mediana")
            {
                precio = 46;
            }
            if (sabor == "Red Velvet" && tamaño == "Grande")
            {
                precio = 56;
            }
            if (sabor == "Red Velvet" && tamaño == "Naked")
            {
                precio = 70;
            }

            //Tres leches oreo
            if (sabor == "Tres leches oreo" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches oreo" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches oreo" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches oreo" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches oreo" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Tres leches de chocolate
            if (sabor == "Tres leches de chocolate" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches de chocolate" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches de chocolate" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches de chocolate" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches de chocolate" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Tres leches de fresa
            if (sabor == "Tres leches de fresa" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches de fresa" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches de fresa" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches de fresa" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches de fresa" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Tres leches de lucuma
            if (sabor == "Tres leches de lucuma" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches de lucuma" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches de lucuma" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches de lucuma" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches de lucuma" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Tres leches de guanabana
            if (sabor == "Tres leches de guanabana" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches de guanabana" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches de guanabana" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches de guanabana" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches de guanabana" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Tres leches de vainilla
            if (sabor == "Tres leches de vainilla" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Tres leches de vainilla" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Tres leches de vainilla" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Tres leches de vainilla" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Tres leches de vainilla" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Cheesecake de oreo
            if (sabor == "Cheesecake de oreo" && tamaño == "Mini")
            {
                precio = 20;
            }
            if (sabor == "Cheesecake de oreo" && tamaño == "Chica")
            {
                precio = 30;
            }
            if (sabor == "Cheesecake de oreo" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Cheesecake de oreo" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Cheesecake de oreo" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Cheesecake de maracuya
            if (sabor == "Cheesecake de maracuya" && tamaño == "Mini")
            {
                precio = 20;
            }
            if (sabor == "Cheesecake de maracuya" && tamaño == "Chica")
            {
                precio = 30;
            }
            if (sabor == "Cheesecake de maracuya" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Cheesecake de maracuya" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Cheesecake de maracuya" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Cheesecake de fresa
            if (sabor == "Cheesecake de fresa" && tamaño == "Mini")
            {
                precio = 20;
            }
            if (sabor == "Cheesecake de fresa" && tamaño == "Chica")
            {
                precio = 30;
            }
            if (sabor == "Cheesecake de fresa" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Cheesecake de fresa" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Cheesecake de fresa" && tamaño == "Naked")
            {
                precio = 65;
            }


            //Cheesecake de nutella 
            if (sabor == "Cheesecake de nutella" && tamaño == "Mini")
            {
                precio = 20;
            }
            if (sabor == "Cheesecake de nutella" && tamaño == "Chica")
            {
                precio = 30;
            }
            if (sabor == "Cheesecake de nutella" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Cheesecake de nutella" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Cheesecake de nutella" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Chantilly de fresa 
            if (sabor == "Chantilly de fresa" && tamaño == "Mini")
            {
                precio = 25;
            }
            if (sabor == "Chantilly de fresa" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Chantilly de fresa" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Chantilly de fresa" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Chantilly de fresa" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Selva negra
            if (sabor == "Selva negra" && tamaño == "Mini")
            {
                precio = 27;
            }
            if (sabor == "Selva negra" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Selva negra" && tamaño == "Mediana")
            {
                precio = 45;
            }
            if (sabor == "Selva negra" && tamaño == "Grande")
            {
                precio = 55;
            }
            if (sabor == "Selva negra" && tamaño == "Naked")
            {
                precio = 65;
            }

            //Genovesa
            if (sabor == "Genovesa" && tamaño == "Mini")
            {
                precio = 28;
            }
            if (sabor == "Genovesa" && tamaño == "Chica")
            {
                precio = 38;
            }
            if (sabor == "Genovesa" && tamaño == "Mediana")
            {
                precio = 48;
            }
            if (sabor == "Genovesa" && tamaño == "Grande")
            {
                precio = 58;
            }
            if (sabor == "Genovesa" && tamaño == "Naked")
            {
                precio = 68;
            }

            //Pasion morena
            if (sabor == "Pasion morena" && tamaño == "Mini")
            {
                precio = 30;
            }
            if (sabor == "Pasion morena" && tamaño == "Chica")
            {
                precio = 35;
            }
            if (sabor == "Pasion morena" && tamaño == "Mediana")
            {
                precio = 40;
            }
            if (sabor == "Pasion morena" && tamaño == "Grande")
            {
                precio = 57;
            }
            if (sabor == "Pasion morena" && tamaño == "Naked")
            {
                precio = 67;
            }
            precio *= cant;

            return precio;
        }

            private void btSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            if (dgordenes.Rows.Count != 0)
            {
                FormMetodoPagoTarjeta form = new FormMetodoPagoTarjeta(Precioooo);
                form.Show();
            }
            else
            {
                MessageBox.Show("No hay ninguna compra, no puede continuar al Pago");
            }
        }
    }
}
