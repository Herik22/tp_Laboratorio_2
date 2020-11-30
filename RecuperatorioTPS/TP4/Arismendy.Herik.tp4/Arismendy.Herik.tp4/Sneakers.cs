using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{

    /// <summary>
    /// Clase Derivada de Zapatillas que representa un sneakers.
    /// </summary>
    public class Sneakers : Zapatillas
    {

        #region ATRIBUTOS   

        EProcedencia procedencia;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de solo lectura para la procedencia. 
        /// </summary>
        public EProcedencia Procedencia
        {
            get
            {
                return this.procedencia;
            }
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto para los Sneakers
        /// </summary>
        public Sneakers() : base()
        {
            this.procedencia = EProcedencia.NN;
        }
        /// <summary>
        /// Constructor parametrizado para Sneaker
        /// </summary>
        /// <param name="marca">marca del snaker</param>
        /// <param name="talle">talle. </param>
        /// <param name="price">precio. </param>
        /// <param name="procedencia">enumerado de la procedencia. </param>
        public Sneakers(string marca, float talle, float price, EProcedencia procedencia) : base(marca, talle, price)
        {
            this.procedencia = procedencia;
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Permite mostrar los datos del Sneaker. No los publica. 
        /// </summary>
        /// <returns></returns>
        private string InformarSneaker()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("MARCA: {0}", base.Marca);
            sb.AppendLine();
            sb.AppendFormat("TALLA: {0}", base.Talla);
            sb.AppendLine();
            sb.AppendFormat("PROCEDENCIA: {0}", base.Talla);
            sb.AppendLine();
            sb.AppendFormat("PRECIO: {0}", base.Precio);

            return sb.ToString();
        }
        /// <summary>
        /// Publica los datos del sneaker.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.InformarSneaker();
        }

        /// <summary>
        /// Mapea el dato recibido como string por una EProcedencia valida. 
        /// </summary>
        /// <param name="procedencia"></param>
        /// <returns></returns>
        public static EProcedencia StringaProcedencia(string procedencia)
        {
            switch (procedencia)
            {
                case "Argentina":
                    {
                        return EProcedencia.Argentina;
                    }
                case "Afganistan":
                    {
                        return EProcedencia.Afganistan;
                    }
                case "EstadosUnidos":
                    {
                        return EProcedencia.EstadosUnidos;
                    }
                default:
                    {
                        return EProcedencia.NN;
                    }
            }
        }
        #endregion

        /// <summary>
        /// Seranm iguales si comparten la marca y procedencia. 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Sneakers s1, Sneakers s2)
        {
            bool rta = false;
            if (s1.marca == s2.marca && s1.procedencia == s2.procedencia)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Sneakers s1, Sneakers s2)
        {
            return !(s1 == s2);
        }
    }
}
