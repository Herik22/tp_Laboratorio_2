using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{   /// <summary>
    /// Excepcion que sera lanzada si se intenta agregar ods sneakers iguales. 
    /// </summary>
    public class SneakerRepetidoExcepcion : Exception
    {
        #region CONSTRUCTORES
        /// <summary>
        /// Constructor parametrizado que recibe un mensaje explicando la exepcion.
        /// </summary>
        /// <param name="msj"></param>
        public SneakerRepetidoExcepcion(string msj): base (msj)
        {

        }
        #endregion
    }
}
