using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Ciclomotor  deriva de la clase Vehiculo. y es publica
    /// </summary>
    public class Ciclomotor : Vehiculo
    {

        #region PROPIEDADES
        /// <summary>
        /// Retornara el tamaño del Ciclomotor, Las motos son chicas
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor parametrizado de la clase Ciclomotor, que a su vez llama al cosntructor base. 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Ciclomotor (EMarca marca, string chasis, ConsoleColor color): base (chasis,marca,color)
        {
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Retornara un string con la informacion del vehiculo CICLOMOTOR
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
