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
    public partial class CarritoForm : Form
    {

        #region CONSTRUCTOR
        public CarritoForm()
        {
            InitializeComponent();

        }

        public CarritoForm(Carrito carrito) : this()
        {
            this.labelCarrito.Text = carrito.ToString();
        }


        #endregion
        
    }
}
