using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik.tp4
{
    /// <summary>
    /// Clase que contendra la informacion de los productos seleccionados.
    /// </summary>
    public class Carrito 
    {
        #region ATRIBUTOS

        private int contadorSneaker;
        private List<Sneakers> listaSneakers;
        private List<Botines> listaBotines;



        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de Lectura para la lista de Sneakers 
        /// </summary>
        public  List<Sneakers> ListaSneakers
        {
            get
            {
                return this.listaSneakers;
            }
        }

        /// <summary>
        /// Propiedad de Lectura para la lista de Botines 
        /// </summary>
        public List<Botines> ListaBotines
        {
            get
            {
                return this.listaBotines;
            }
        }

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto que dara inicio a las listas genericas.
        /// </summary>
        public Carrito ()
        {
            this.listaSneakers = new List<Sneakers>();
            this.listaBotines = new List<Botines>();
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Mostrara la informacion de cada producto agregado al carrito.
        /// </summary>
        /// <returns></returns>
        private string MostrarProductos ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
                
                if (this.listaSneakers.Count > 0)
                {
                    sb.AppendLine(" TUS SNEAKERS ");
                    foreach (Sneakers item in this.listaSneakers)
                    {
                        sb.AppendFormat(item.ToString());
                        sb.AppendLine();
                    }
                }
                if (this.listaBotines.Count > 0)
                {
                    sb.AppendLine(" TUS BOTINES ");
                    foreach (Botines item in this.listaBotines)
                    {
                        sb.AppendFormat(item.ToString());
                        sb.AppendLine();
                    }
                }
            
            return sb.ToString();
        }

        /// <summary>
        /// Metodo que hara publica la informacion de todo el carrito. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarProductos();
        }

       
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Sobrecarga que permite agregar un sneaker al carrito siempre y cuando no este ya agregado.
        /// </summary>
        /// <param name="carrito"></param>
        /// <param name="sneaker"></param>
        /// <returns></returns>
        public static Carrito operator + (Carrito carrito,Sneakers sneaker)
        {
            foreach(Sneakers item in carrito.listaSneakers)
            {
                if(item != sneaker)
                {
                    carrito.listaSneakers.Add(sneaker);
                    carrito.contadorSneaker++;
                }else
                {
                    throw new SneakerRepetidoExcepcion("SNEAKER YA EN LISTA!");
                }
            }
            
           
            return carrito;
        }
        /// <summary>
        /// Sobrecarga que permite agregar un Botin al carrito. 
        /// </summary>
        /// <param name="carrito"></param>
        /// <param name="botin"></param>
        /// <returns></returns>
        public static Carrito operator + (Carrito carrito, Botines botin)
        {           
           carrito.listaBotines.Add(botin);
            return carrito;
        }
        #endregion


    }
}
