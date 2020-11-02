using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Constructor y mensaje por defecto 
        /// </summary>
        public AlumnoRepetidoException() : base("Alumno repetido.")
        { }
        /// <summary>
        /// constructor con mensaje como parametro.
        /// </summary>
        /// <param name="msj"></param>
        public AlumnoRepetidoException(string msj) : base (msj)
        { }
    }
}
