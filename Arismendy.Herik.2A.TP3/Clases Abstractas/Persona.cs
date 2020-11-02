using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{               /*Clase Persona:
                        • Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
                        • Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad. Argentino entre 1 y
                        89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción
                        NacionalidadInvalidaException.
                        • Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará
                        DniInvalidoException.
                        • Sólo se realizarán las validaciones dentro de las propiedades.
                        • Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se
                        cargará.
                        • ToString retornará los datos de la Persona.*/
    public abstract class Persona
    {
        #region Atributos

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto  de tipo PERSONA 
        /// </summary>
        public Persona()
        { }

        /// <summary>
        /// Constructor parametrizado de tipo PERSONA 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        /// <summary>
        ///  Constructor parametrizado con todos los atributos de  tipo PERSONA 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        /// <summary>
        ///  Constructor parametrizado con todos los atributos de  tipo PERSONA 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region PROPIEDADES 
        /// <summary>
        /// propiedad de lectura / escritura para el apellido con previa validacion.
        /// </summary>
        public string Apellido 
        { 
            get 
            { 
                return this.apellido; 
            } 
            set 
            { 
                apellido = this.ValidarNombreApellido(value); 
            }
        
        }

        /// <summary>
        /// propiedad de lectura / escritura para el DNI validando previamente. 
        /// </summary>
        public int Dni 
        { 
            get
            {
              return this.dni; 
            }
            set 
            {                   
                dni = this.ValidarDni(this.nacionalidad, value);                
            } 
        }

        /// <summary>
        /// propiedad de lectura / escritura para la Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { nacionalidad = value; } }

        /// <summary>
        /// propiedad de lectura / escritura para el Nombre
        /// </summary>
        public string Nombre
        { 
            get 
            { 
                return this.nombre; 
            } 
            set
            { 
                nombre = this.ValidarNombreApellido(value);
            } 
        }

        /// <summary>
        /// propiedad de  escritura para el DNI con previ validacion.
        /// </summary>
        public string StringToDNI
        { 
            set
            { 
                dni = this.ValidarDni(this.nacionalidad,value);
            } 
        }

        #endregion

        #region METODOS 

        /// <summary>
        /// Retorna la informacion de persona. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine();
            sb.AppendFormat("NOMBRE COMPLETO: {0},{1}", this.apellido , this.nombre);
            sb.AppendLine();
            sb.AppendFormat("NACIONALIDAD: {0}", this.nacionalidad);
            return sb.ToString();
        }

        /// <summary>
        ///  Se valida que el DNI sea correcto, teniendo en cuenta su nacionalidad. si es Argentino menor a 1 o 
        ///  mayor a 89999999 o si es  Extranjero menor a 90000000 o mayor a  99999999.  se lanzará la excepción
        ///  " NacionalidadInvalidaException. "
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {          
            if (nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999 ||
                nacionalidad == ENacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999)
            {
                return dato;
            }else
            {
                throw new NacionalidadInvalidaException();
            }
            
        }

        /// <summary>
        /// • valida que el DNI no presenta un error de formato (más caracteres de los permitidos, letras, etc.).
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni (ENacionalidad nacionalidad,string dato)
        {
            int auxDni = -1;

            if (dato.Length < 1 && dato.Length > 8 || !int.TryParse(dato, out auxDni))
            {
                 throw new DniInvalidoException();
            }
            return this.ValidarDni(nacionalidad, auxDni);
            
                   
        }

        /// <summary>
        ///  Validará que los nombres sean cadenas con caracteres válidos para nombres. Caso contrario, no se cargará.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (dato.Length > 1 && dato.Any(char.IsSymbol) || dato.Any(char.IsDigit))
            {
                return "";
            }
            return dato;
        }
           
        #endregion  
     
        #region ENUMERADOS

        public enum ENacionalidad
        {
            Argentino,
            Extranjero 
        }
        #endregion

   }
}
