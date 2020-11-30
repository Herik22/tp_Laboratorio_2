using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arismendy.Herik.tp4;

namespace FormPrincipal
{
    public partial class ClienteForm : Form
    {
        #region ATRIBUTOS
        protected Cliente cliente;
        protected float total;
        #endregion

        #region CONSTRUCTORES
        public ClienteForm()
        {
            InitializeComponent();
            this.comboBoxMetodoPago.Items.Add("Efectivo");
            this.comboBoxMetodoPago.Items.Add("Tarjeta Debito/Credito");
            this.comboBoxMetodoPago.Items.Add("Mercado Pago");
        }

        public ClienteForm (Cliente cliente1,float total)
            : this()
        {
            this.cliente = cliente1;
            this.total = total;
        }
        #endregion

        #region EVENTOS
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // obtengo y convierto los datos. 
                string nombre = this.textBoxNombre.Text;
                string direccion = this.textBoxDireccion.Text;
                int dni = int.Parse(this.textBoxDni.Text);
                EMetodoPago pago = this.cliente.StringaMetodoPago(this.comboBoxMetodoPago.SelectedIndex.ToString());

                // creo el cliente del form. 

                this.cliente = new Cliente(nombre, dni, direccion, this.total, pago);
                if (this.textBoxNombre != null && this.textBoxDni != null && this.textBoxDireccion != null)
                {

                    bool tiquete = this.cliente.Facturar();
                    if (tiquete)
                    {
                        MessageBox.Show("Se genero el ticket!");

                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar el ticket!");
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de completar TODOS los datos!!");
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception)
            {

                MessageBox.Show("INGRESE TODOS LOS DATOS DE FORMA CORRECTA. ");
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
            
        }
        #endregion
    }
}
