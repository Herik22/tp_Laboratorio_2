using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Suv : Vehiculo
    {
      
        #region PROPIEDADES
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Grande;
            }
        }

        #endregion

        #region CONSTRUCTORES
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Muestra la informacion del vehiculo
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
