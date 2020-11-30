using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Arismendy.Herik.tp4
{
    /// <summary>
    /// Clase que permite almacenar los datos de clientes. 
    /// </summary>
    public class Cliente: IFactura
    {
        #region ATRIBUTOS
        private string nombre;
        private int dni;
        private string direccion;
        private EMetodoPago formaPago;
        private float total;


        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad de L/E para el campo Nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                nombre = value;
            }

        }

        /// <summary>
        /// Propiedad de L/E para el campo Dni.
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                dni = value;
            }
        }

        /// <summary>
        /// Propiedad de L/E para el campo Direccion.
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                direccion = value;
            }
        }

        /// <summary>
        /// Propiedad de L/E para el campo Forma de Pago.
        /// </summary>
        public EMetodoPago FormaPago
        {
            get
            {
                return this.formaPago;
            }
            set
            {
                formaPago = value;
            }
        }

        #endregion

        #region CONSTRUCTOR 
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cliente()
        {

        }
        /// <summary>
        /// Constructor parametrizado para el Cliente. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dni"></param>
        /// <param name="direccion"></param>
        /// <param name="total_"></param>
        /// <param name="formPago"></param>
        public Cliente(string name, int dni,string direccion,float total_, EMetodoPago formPago)
        {
            this.Nombre = name;
            this.Dni = dni;
            this.direccion = direccion;
            this.FormaPago = formPago;
            this.total = total_;
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Implementacion de la interfaz IFactura, que permite realizar el tiquete de compra con los datos del cliente y el total del carrito. 
        /// </summary>
        /// <returns></returns>
        public bool Facturar()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Factura.log";
            bool rta = true;

            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamWriter sw = new StreamWriter(ruta, true))
                    {
                        sw.WriteLine("Consumidor final: {0}", this.nombre);
                        sw.WriteLine("Dni: {0}", this.dni);
                        sw.WriteLine("Domicilio: {0}", this.direccion);
                        sw.WriteLine("Metodo de Pago: {0}", this.formaPago.ToString());
                        sw.WriteLine("Fecha: {0}", DateTime.Now);
                        sw.WriteLine("");
                        sw.WriteLine("Total Productos: {0}", this.total);
                    }
                }else 
                {
                    using (StreamWriter sw = new StreamWriter(ruta, false))
                    {
                        sw.WriteLine("Consumidor final: {0}", this.nombre);
                        sw.WriteLine("Dni: {0}", this.dni);
                        sw.WriteLine("Domicilio: {0}", this.direccion);
                        sw.WriteLine("Metodo de Pago: {0}", this.formaPago.ToString());
                        sw.WriteLine("Fecha: {0}", DateTime.Now);
                        sw.WriteLine("");
                        sw.WriteLine("Total Productos: {0}", this.total);
                    }
                }
            }
            catch (Exception)
            {

                rta = false;
            }
            return rta;
        }
        #endregion
    }
}
