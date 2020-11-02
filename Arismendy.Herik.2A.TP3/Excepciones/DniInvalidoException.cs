using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{       /* 
         * Todas las excepciones deberán tener mensajes propios: que tengan al menos un constructor que
         * reciba mensaje y que tengan un constructor sin parámetros que asigne un mensaje por defecto.  */
    public class DniInvalidoException : Exception
    {

        /// <summary>
        /// Constructor y mensaje por defecto 
        /// </summary>
        public DniInvalidoException () : base ("El FORMATO DEL DNI ES INVALIDO")
        { }

        /// <summary>
        /// constructor que recibe una excepcion.
        /// </summary>
        /// <param name="msj"></param>
        public DniInvalidoException ( Exception e)
        { }

        /// <summary>
        /// constructor que recibe un  mensaje como parametro.
        /// </summary>
        /// <param name="msj"></param>
        public DniInvalidoException (string msj) : base (msj)
        { }

        /// <summary>
        /// Consturctor con mensaje y excepcion como parametros(mas informacion de la excepcion)
        /// </summary>
        /// <param name="msj"></param>
        /// <param name="e"></param>
        public DniInvalidoException (string msj , Exception e): base (msj,e)
        { }
    }
}
