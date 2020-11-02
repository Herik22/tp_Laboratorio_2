using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivo<T>
    {
        #region METODOS
        /// <summary>
        /// Permite guardar en la ruta especificada el dato recibido.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar (string archivo,T datos);

        /// <summary>
        /// Permite leer de la ruta especificada y guardar en el dato dado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Leer(string archivo, out T datos);

        #endregion
    }
}
