using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A.TP3
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
• ToString retornará los datos de la Persona.
    
                  #region Atributos
        #endregion

        #region CONSTRUCTORES
        #endregion

        #region PROPIEDADES
        #endregion

        #region METODOS 
        #endregion

        #region SOBRECARGAS 
        #endregion*/
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
        public Persona ()
        {}

        /// <summary>
        /// Constructor parametrizado de tipo PERSONA 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona (string nombre,string apellido,ENacionalidad nacionalidad): this()
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
        public Persona (string nombre, string apellido,int dni, ENacionalidad nacionalidad) : this (nombre,apellido,nacionalidad)
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
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido,int.Parse(dni), nacionalidad)
        {

        }

        #endregion

        #region PROPIEDADES // VALIDAR EL STRINGTODNI
        /// <summary>
        /// propiedad de lectura / escritura para el apellido
        /// </summary>
        public string Apellido { get { return this.apellido; } set { apellido = value; }  }

        /// <summary>
        /// propiedad de lectura / escritura para el DNI
        /// </summary>
        public  int Dni { get { return this.dni; } set { dni = value; } }

        /// <summary>
        /// propiedad de lectura / escritura para la Nacionalidad
        /// </summary>
        public  ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { nacionalidad = value; } }

        /// <summary>
        /// propiedad de lectura / escritura para el Nombre
        /// </summary>
        public  string Nombre { get { return this.nombre; } set { nombre = value; } }

        /// <summary>
        /// propiedad de  escritura para el DNI
        /// </summary>
        public string StringToDNI { set { dni = int.Parse(value); } } 

        #endregion

        #region METODOS 

        /// <summary>
        /// Retorna la informacion de persona. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendFormat("NOMBRE COMPLETO: {0},{1}", this.nombre, this.apellido);
            sb.AppendLine();
            sb.AppendFormat("NACIONALIDAD: {0}",this.nacionalidad);
            return sb.ToString();
        }

        ///DESARROLLAR LAS VALIDACIONES
        #endregion

        #region SOBRECARGAS 
        #endregion
    }
}
