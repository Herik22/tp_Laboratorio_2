using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    /// <summary>
    /// Interface que indica la facturacion de productos. 
    /// </summary>
    public interface IFactura
    {
        /// <summary>
        /// Permite generar una factura de la compra asociada al cliente. 
        /// </summary>
        /// <returns></returns>
        bool Facturar();
    }
}
