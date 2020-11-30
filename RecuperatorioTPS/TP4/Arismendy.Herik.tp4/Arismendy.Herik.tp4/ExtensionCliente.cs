using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    /// <summary>
    /// Clase dedicada a la extension de metodos  de la clase Cliente 
    /// </summary>
    public static class ExtensionCliente
    {
        /// <summary>
        /// Permite hacer el mapeo del string recibido a un EMetodoPago valido. 
        /// </summary>
        /// <param name="micliente"></param>
        /// <param name="metodoPago"></param>
        /// <returns></returns>
        public static EMetodoPago StringaMetodoPago(this Cliente micliente,  string metodoPago)
        {
            switch (metodoPago)
            {
                case "Efectivo":
                    return EMetodoPago.Efectivo;

                case "Tarjeta Debito/Credito":
                    return EMetodoPago.Tarjeta;

                case "Mercado Pago":
                    return EMetodoPago.MercadoPago;

                default:
                    return EMetodoPago.Efectivo;
            }
        }
    }
}
