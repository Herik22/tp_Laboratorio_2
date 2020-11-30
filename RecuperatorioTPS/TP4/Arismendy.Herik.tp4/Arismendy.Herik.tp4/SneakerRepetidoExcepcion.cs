using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{/// <summary>
/// Excepcion que sera lanzada si se intenta agregar ods sneakers iguales. 
/// </summary>
    public class SneakerRepetidoExcepcion : Exception
    {
        public SneakerRepetidoExcepcion(string msj): base (msj)
        {

        }
    }
}
