using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{       /*Clase Jornada:
            • Atributos Profesor, Clase y Alumnos que toman dicha clase.
            • Se inicializará la lista de alumnos en el constructor por defecto.
            • Una Jornada será igual a un Alumno si el mismo participa de la clase.
            • Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente
            cargados.
            • ToString mostrará todos los datos de la Jornada.
            • Guardar de clase guardará los datos de la Jornada en un archivo de texto.
            • Leer de clase retornará los datos de la Jornada como texto.*/
    public class Jornada
    {
        #region Atributos

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// COnstructor por defecto que inicializa la lista.
        /// </summary>
        private Jornada ()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor parametrizado que llama al constructor por defecto. 
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="profesor"></param>
        public Jornada (Universidad.EClases clase,Profesor profesor) : this ()
        {
            this.clase = clase;
            this.instructor = profesor;
        }

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura/escritura para la lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos { get { return this.alumnos; } set {this.alumnos = value; } }

        /// <summary>
        /// Propiedad de lectura/escritura para la clase.
        /// </summary>
        public Universidad.EClases Clase { get { return this.clase; } set { this.clase = value; } }

        /// <summary>
        /// Propiedad de lectura/escritura para el instructor.
        /// </summary>
        public Profesor Instructor { get { return this.instructor; } set { this.instructor = value; } }


        #endregion

        #region METODOS  

        /// <summary>
        /// Permite guardar la jornada en un archivo de texto. 
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar (Jornada jornada)
        {
            Texto t = new Texto();

            return t.Guardar("Jornada.txt", jornada.ToString()); 
        }

        /// <summary>
        /// Permite leer los datos de un archivo en modo texto, establecerlos en ua variable y retornarla. 
        /// </summary>
        /// <returns></returns>
        public static string Leer ()
        {
            Texto t = new Texto();

            Jornada auxJ = new Jornada();
            t.Leer("Jornada.txt",out string datos);

            return datos;
        }
        /// <summary>
        /// Hace publicos los datos de la jornada. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");
            sb.AppendFormat("CLASE DE: {0} POR: {1}ALUMNOS:", this.clase, this.instructor.ToString());
            foreach(Alumno item in this.alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        #endregion

        #region SOBRECARGAS 

        /// <summary>
        /// TRUE=   si el alumno participa  de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator == (Jornada j, Alumno a)
        {
            bool rta = false;
            foreach (Alumno item in j.alumnos)
            {
                rta = item.Equals(a);               
            }
                return rta;
        }

        public static bool operator != (Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega el alumnos a la clase siempre y cuando este  no estén previamente en la clase..
        /// </summary>
        /// <returns></returns>
        public static Jornada operator + (Jornada j,Alumno a)
        {
            if ( j != a)
            {
                j.alumnos.Add(a);
            }
            return j;
        }
        #endregion
    }
}
