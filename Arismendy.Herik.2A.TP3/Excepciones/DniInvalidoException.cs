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

        public DniInvalidoException () : base ("El FORMATO DEL DNI ES INVALIDO")
        { }

        public DniInvalidoException ( Exception e)
        { }

        public DniInvalidoException (string msj) : base (msj)
        { }

        public DniInvalidoException (string msj , Exception e): base (msj,e)
        { }
    }
}
