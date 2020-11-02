using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Constructor y mensaje por defecto 
        /// </summary>
        /// <param name="msj"></param>
        public NacionalidadInvalidaException () : base ("La nacionalidad no se condice con el numero de DNI")
        { }

        /// <summary>
        /// constructor que recibe un  mensaje como parametro.
        /// </summary>
        /// <param name="msj"></param>
        public NacionalidadInvalidaException (string msj ) : base (msj)
        { }
    }
}
