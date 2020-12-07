using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    /// <summary>
    /// Interface que permite serializar un cliente. 
    /// </summary>
    public interface  ISerializar 
    {
        #region METODOS

        /// <summary>
        /// Propiedad de lectura que estipulara la direccion donde se guardara el archivo xml.
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Permite serializar la clase donde se implemente.
        /// </summary>
        /// <returns> TRUE : Si logra serializar, FALSE si suede algun problema. </returns>
        bool Xml();

       

        #endregion
    }
}
