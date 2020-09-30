using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
     public class Sedan : Vehiculo
    {

        #region ATRIBUTOS

        private ETipo tipo;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Los automoviles son medianos
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Por defecto, TIPO será Monovolumen
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            
        }

        public Sedan (EMarca marca, string chasis, ConsoleColor color,ETipo tipo):this (marca,chasis,color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region METODOS
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendFormat("TIPO : \n" + this.tipo);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

        #region ENUMERADOS
        public enum ETipo
        {
            CuatroPuertas, CincoPuertas 
        }
        #endregion
    }
}
