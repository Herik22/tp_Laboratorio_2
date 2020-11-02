using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{ /*
                                • Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
                                • Sobrescribir el método MostrarDatos con todos los datos del profesor.
                                • ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
                                • ToString hará públicos los datos del Profesor.
                                • Se inicializará a Random sólo en un constructor.
                                • En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
                                mediante el método randomClases. Las dos clases pueden o no ser la misma.
                                • Un Profesor será igual a un EClase si da esa clase.*/
    public sealed class Profesor : Universitario
    {
        #region Atributos

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region CONSTRUCTORES 
        
        /// <summary>
        /// constructor por defecto.
        /// </summary>
        public Profesor() : this (default,default,default,default,default) 
        {
            
            
        }

        /// <summary>
        /// Constructor estatico que iniciliza el random.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();

        }

        /// <summary>
        /// Constructor parametrizado que a su vez llama al constructor base. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
        }
        #endregion

        #region METODOS 

        /// <summary>
        /// Asigna de maner aleatoria dos clases al profesor.
        /// </summary>
        private void _randomClases()
        {
            
            
            int auxRandom = default;
            for (int i = 0; i < 2; i++)
            {
                auxRandom = Profesor.random.Next(0, 3);
                this.clasesDelDia.Enqueue((Universidad.EClases)auxRandom);
            }

        }
        /// <summary>
        /// Retorna todos los datos del profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// retorna las clases que da el profesor. 
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine("CLASES DEL DIA:");

            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendFormat("{0}", item.ToString());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        /// <summary>
        /// Hace publico los datos del profesor.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// TRUE= si el  Profesor da esa clase.
        /// FALSE= lo contrario.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator == (Profesor i, Universidad.EClases clase)
        {
            bool rta = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if(item == clase)
                {
                    rta = true;
                    break;
                }
            }
            return rta;
        }

        public static bool operator != (Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
            #endregion
        }
}
