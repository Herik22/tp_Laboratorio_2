using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{   /// <summary>
    /// Excepcion que sera lanzada si se sobrepasa el maximo de botines. 
    /// </summary>
    public class MaximoBotinesExcepcion : Exception
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado que recibe el mensaje explicnado la excepcion.
        /// </summary>
        /// <param name="msj"></param>
        public MaximoBotinesExcepcion(string msj) : base(msj)
        {

        }

        #endregion
    }
}
