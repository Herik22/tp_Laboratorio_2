using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor y mensaje por defecto 
        /// </summary>
        public ArchivosException () : base ("Excepcion de Archivos.!!")
        { }

        /// <summary>
        /// constructor con mensaje como parametro.
        /// </summary>
        /// <param name="msj"></param>
        public ArchivosException (string msj) : base (msj)
        { }

        /// <summary>
        /// constructor que recibe una excepcion.
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException ( Exception innerException)
        { }

    }
}
