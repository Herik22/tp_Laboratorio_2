using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    public class Botines : Zapatillas
    {
        #region ATRIBUTOS 

        protected bool esMultiterreno;
       
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura que indica si el botin es o no multiterreno
        /// </summary>
        public bool Multiterreno 
        { 
            get
            {
                return this.esMultiterreno;
            }
        }

        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor por defecto para el botin.
        /// </summary>
        public Botines() : base ()
        {
            
        }

        /// <summary>
        /// Constructor parametrizado que invoca a la base zapatilla. 
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="talle"></param>
        /// <param name="price"></param>
        /// <param name="multiterreno"></param>
        public Botines (string marca,float talle,float price,bool multiterreno) : base (marca,talle,price)
        {
            this.esMultiterreno = multiterreno;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Permite ver la informacion detallada de los botines.
        /// </summary>
        /// <returns></returns>
        public string InformarBotines ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("MARCA: {0}", base.Marca);
            sb.AppendLine();
            sb.AppendFormat("TALLA: {0}", base.Talla);
            sb.AppendLine();
            if (this.esMultiterreno == true)
            {
                sb.AppendFormat("LOS BOTINES SON APTOS PARA TODO TERRENO!: {0}", this.esMultiterreno);
                sb.AppendLine();
            }
            
            sb.AppendFormat("PRECIO: {0}", base.Precio);

            return sb.ToString();
        }

        /// <summary>
        /// Háce publica la informacion del Botin. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.InformarBotines();
        }


        #endregion
    }
}
