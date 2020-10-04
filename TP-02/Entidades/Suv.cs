using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Suv deriva de la clase Vehiculo. y es publica
    /// </summary>
    public class Suv : Vehiculo
    {
      
        #region PROPIEDADES
        /// <summary>
        ///  Retornara el tamaño, Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Grande; // en el ejecutable aparece MEDIANO. 
            }
        }

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Consturctor parametrizado de la clase derivada SUV 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Muestra la informacion del vehiculo  SUV
        /// </summary>
        /// <returns></returns>
        public override  string Mostrar() 
        {
            StringBuilder sb = new StringBuilder(); 

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar()); 
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
