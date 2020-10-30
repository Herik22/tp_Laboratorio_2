using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// La clase Sedan deriva de la clase Vehiculo. y es publica
    /// </summary>
    public class Sedan : Vehiculo
    {

        #region ATRIBUTOS

        private ETipo tipo;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Retorna el damaño del SEDAN, Los automoviles son medianos
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
        /// Constructor que a su vez reutiliza al constructor por defecto
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis,marca,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor Por defecto,que llama tambien al constructor base,  TIPO será Monovolumen 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca,chasis,color,ETipo.CuatroPuertas)
        {
            
        }

        
        #endregion

        #region METODOS
        /// <summary>
        /// Retornara la informacion del vehiculo  SEDAN
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendFormat("TIPO : " + this.tipo);
            sb.AppendLine();
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
