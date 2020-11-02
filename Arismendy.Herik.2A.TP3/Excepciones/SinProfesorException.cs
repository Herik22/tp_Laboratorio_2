using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        /// <summary>
        /// Constructor y mensaje por defecto 
        /// </summary>
        /// <param name="msj"></param>
        public SinProfesorException () :base("No hay profesor para la clase.")
        { }

        /// <summary>
        /// constructor que recibe un  mensaje como parametro.
        /// </summary>
        /// <param name="msj"></param>
        public SinProfesorException (string msj) : base (msj)
        { }
    }
}
