using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{ 
    /// <summary>
    ///  Clase que servirá como inicio de la jerarquia. 
    /// </summary>
    public class Zapatillas
    {
        #region ATRIBUTOS
        protected string marca;
         protected float talla;
         protected float precio;

        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de lectura para la marca.
        /// </summary>
        protected string Marca
        {
            get 
            {
                return this.marca;
            }
        }
        /// <summary>
        /// Propiedad de lectura para la talla.
        /// </summary>
        protected float Talla
        {
            get
            {
                return this.talla;
            }
           
        }

        /// <summary>
        /// Propiedad de lectura para el precio.
        /// </summary>
        protected float Precio 
        {
            get
            {
                return this.precio;
            }
            
        }
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto para la Zapatilla
        /// </summary>
        public Zapatillas()
        { }

        /// <summary>
        /// Constructor parametrizado para zapatilla
        /// </summary>
        /// <param name="Marca"></param>
        /// <param name="Talla"></param>
        /// <param name="Precio"></param>
        public Zapatillas(string Marca, float Talla, float Precio) : this ()
        {
            this.marca = Marca;
            this.talla = Talla;
            this.precio = Precio;
        }
        #endregion
    }
}

