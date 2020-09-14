using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidadess;

namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent(); // Constructor de todo el formulario.           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // NOMBREDELBOTON Y LA ACCION
        {
            this.BackColor = Color.Black;  // cambio color de fondo

            btnCerrar.BackColor = Color.Black;
            btnCerrar.ForeColor = Color.Aqua;

            btnLimpiar.BackColor = Color.Black;
            btnLimpiar.ForeColor = Color.Aqua;

            btnOperar.BackColor = Color.Black;
            btnOperar.ForeColor = Color.Aqua;

            btnConvertiraBinario.BackColor = Color.Black;
            btnConvertiraBinario.ForeColor = Color.Aqua;

            btnConvertiraDecimal.BackColor = Color.Black;
            btnConvertiraDecimal.ForeColor = Color.Aqua;

            txtNumero1.BackColor = Color.Black;
            txtNumero1.ForeColor = Color.Aqua;

            txtNumero2.BackColor = Color.Black;
            txtNumero2.ForeColor = Color.Aqua;

            cmbOperador.BackColor = Color.Black;
            cmbOperador.ForeColor = Color.Aqua;

            lblResultado.ForeColor = Color.Aqua;

        }

        /// <summary>
        /// Cierra la calculadora tras hacer click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /// <summary>
        /// Convierte si es posible, el resultado decimal  a Binario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertiraBinario_Click(object sender, EventArgs e)
        {

            string resultado = Convert.ToString(Numero.DecimalBinario(lblResultado.Text));
            lblResultado.Text = resultado;
        }

        /// <summary>
        /// Convierte si es posible, el resultado  Binario a Decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertiraDecimal_Click(object sender, EventArgs e)
        {
            string Resultado = Numero.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = Resultado;
        }

        /// <summary>
        ///  Limpia los valores de la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Recibe los valores de la calculadora , invoca al metodo operar y devuelve su resultado en el label txtResultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string n1 = txtNumero1.Text;
            string n2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            lblResultado.Text = Convert.ToString(Operar(n1, n2, operador));
        }

        /// <summary>
        /// ComboBox de tipo LIST que permite escoger un operador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        ///  etiqueta en la cual se mostraran los resultados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Caja de texto la cual almacenara el primer valor 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Caja de texto la cual almacenara el primer valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }


        private void FormCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Calculadora.Operar()
        }
        
       
        
       

        /// <summary>
        /// recibe los numeros 1 / 2 y el operador, para luego llamar al metodo Operar de Calculadora y retornar el resultado
        /// en el Label respuesta
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero n1 = new Numero(numero1);
            Numero n2 = new Numero(numero2);
            return Calculadora.Operar(n1, n2, operador);

        }

        private  void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear(); // limpio ambos textBOX
        }
        
    }
}
