using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{               /*       Clase Universidad:
                            • Atributos Alumnos (lista de inscriptos), Profesores (lista de quienes pueden dar clases) y Jornadas.
                            • Se accederá a una Jornada específica a través de un indexador.
                            • Un Universidad será igual a un Alumno si el mismo está inscripto en él.
                            • Un Universidad será igual a un Profesor si el mismo está dando clases en él.
                            • Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la
                            clase, un Profesor que pueda darla (según su atributo ClasesDelDia) y la lista de alumnos que la
                            toman (todos los que coincidan en su campo ClaseQueToma).
                            • Se agregarán Alumnos y Profesores mediante el operador +, validando que no estén previamente
                            cargados.

                            • La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
                            Sino, lanzará la Excepción SinProfesorException. El distinto retornará el primer Profesor que no
                            pueda dar la clase.
                            • Si al querer agregar alumnos este ya figura en la lista, lanzar la excepción AlumnoRepetidoException.
                            • MostrarDatos será privado y de clase. Los datos del Universidad se harán públicos mediante
                            ToString.
                            • Guardar de clase serializará los datos del Universidad en un XML, incluyendo todos los datos de sus Profesores, Alumnos y Jornadas.
                            • Leer de clase retornará un Universidad con todos los datos previamente serializados.*/
    public class Universidad
    {
        #region Atributos

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto que iniciliaza todas las listas. 
        /// </summary>
        public Universidad ()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        #endregion

        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura / escritura para la lista de alumnos. 
        /// </summary>
        public List<Alumno> Alumnos  { get {return this.alumnos; } set {this.alumnos = value; } }
        /// <summary>
        /// Propiedad de lectura / escritura para la lista de profesores. 
        /// </summary>
        public List<Profesor> Instructores { get { return this.profesores; } set { this.profesores = value; } }

        /// <summary>
        /// Propiedad de lectura / escritura para la lista de jornadas. 
        /// </summary>
        public List<Jornada> Jornadas { get { return this.jornada; } set { this.jornada = value; } }

        /// <summary>
        ///  Indexeador que permite acceder a una Jornada en especifico.. 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this [int i]
        {
            get
            {
                if ( i< 0 || i >= this.jornada.Count)
                {
                    return null;
                }
                else
                {
                    return this.jornada[i];
                }
            }
            set
            {
                if(i >= 0 && i < this.jornada.Count)
                {
                    this.jornada[i] = value;
                }else if ( i == this.jornada.Count)
                {
                    this.jornada.Add(value);
                }               
            }
        }



        #endregion

        #region METODOS 
        /// <summary>
        /// Hace publicos los  datos de la Universidad.
        /// </summary>
        private string MostrarDatos (Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            foreach (Jornada item in uni.jornada)
            {
                sb.Append(item.ToString());
                sb.AppendLine("<-------------------------------------------------->");
            }
            
            return sb.ToString();

        }

        /// <summary>
        /// Hace publicos los datos de la universidad. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        /// <summary>
        /// permite serializar los dato de una universidad y guardarlos en en un archivo xml.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xU = new Xml<Universidad>();
            return xU.Guardar("Universidad.xml", uni);
        }

        /// <summary>
        /// Deserializa un archivo xml y lo retorna como una universidad.
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer ()
        {
            Xml<Universidad> xU = new Xml<Universidad>();
            xU.Leer("Universidad.xml", out Universidad UniversidadReturn);
            return UniversidadReturn;

        }
        #endregion

        #region SOBRECARGAS PREGUNTAR POR LAS DE UNIVERSIDAD - CLASE
        /// <summary>
        ///  Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada indicando la
        ///clase, un Profesor que pueda darla(según su atributo ClasesDelDia) y la lista de alumnos que la
        ///toman(todos los que coincidan en su campo ClaseQueToma).
        /// </summary>
        /// <returns></returns>
        public static  Universidad operator + (Universidad g, EClases clase) // revisar
        {
            Jornada auxJornada = new Jornada(clase, g == clase );
            foreach (Alumno item in g.alumnos)
            {
                if (item == clase)
                {
                    auxJornada += item;
                }
            }
            g.jornada.Add(auxJornada);
            return g;
        }

        /// <summary>
        /// • Se agregarán Alumnos validando que no estén previamentecargados. y si lo estan lanzo exepcion. 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator + (Universidad u,Alumno a) 
        {

            if (u != a)
            {
                u.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }

        /// <summary>
        /// • Se agregarán Profesores validando que no estén previamente cargados. y si lo estan lanzo exepcion. 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator + (Universidad u,Profesor i)
        {
            if (u != i)
            {
                u.profesores.Add(i); 
            } 
            return u;
        }

        /// <summary>
        /// • Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <returns></returns>
        public static bool operator == (Universidad g, Alumno a)
        {
            bool rta = false;
            foreach (Alumno item in g.alumnos)
            {
                rta = item.Equals(a);
            }

            return rta;
        }

        /// <summary>
        ///  Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator == (Universidad g,Profesor p)
        {
            bool rta = false;
            foreach (Profesor item in g.profesores)
            {
                rta = item.Equals(p);
            }

            return rta;
        }

        /// <summary>
        /// La igualación entre una Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
        /// Sino, lanzará la Excepción SinProfesorException.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator == (Universidad u, EClases clase) //CONFIRMAR 
        {
            Profesor rta = null; //new Profesor();
                foreach (Profesor item in u.profesores)
                {
                    if (item == clase)
                    {
                        rta = item;
                        break;
                    }else
                    {
                        throw new SinProfesorException();
                    }
                }
            return rta;
        }

        public static bool operator != (Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator != (Universidad g, Profesor p)
        {
            return !(g == p);
        }
        /// <summary>
        /// El distinto retornará el primer Profesor que no pueda dar la clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator != (Universidad u, EClases clase)
        {
            Profesor rta = new Profesor();
            foreach (Profesor item in u.profesores)
            {
                if (item != clase)
                {
                    rta = item;
                    break;
                }
                
            }
            return rta;
        }
        #endregion

        #region ENUMERADOS

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        #endregion
    }
}
