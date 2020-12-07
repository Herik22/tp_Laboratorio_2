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
    /// <summary>
    /// Formulario que visualizara los productos que hayan sido agragados al carrito.
    /// </summary>
    public partial class CarritoForm : Form
    {
        protected Carrito auxCarrito;

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor por defecto para el formulario
        /// </summary>
        public CarritoForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Constructor parametrizado que recibe el carrito a mostrar por parametro. 
        /// </summary>
        /// <param name="carrito"></param>
        public CarritoForm(Carrito carrito) : this()
        {
            this.auxCarrito = carrito;
            this.labelCarrito.Text = carrito.ToString();
        }


        #endregion

        private void CarritoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
