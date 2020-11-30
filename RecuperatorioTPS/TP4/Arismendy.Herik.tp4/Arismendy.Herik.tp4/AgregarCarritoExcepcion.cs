using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    public class AgregarCarritoExcepcion : Exception
    {
        #region CONSTRUCTORES

       public AgregarCarritoExcepcion() : base ("NO HA SELECCIONADO NADA. ")
        {

        }
        #endregion

    }
}
