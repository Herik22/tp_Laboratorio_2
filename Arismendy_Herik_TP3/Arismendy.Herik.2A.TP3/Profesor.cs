using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arismendy.Herik._2A.TP3
{           /*
                                • Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
                                • Sobrescribir el método MostrarDatos con todos los datos del profesor.
                                • ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
                                • ToString hará públicos los datos del Profesor.
                                • Se inicializará a Random sólo en un constructor.
                                • En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor
                                mediante el método randomClases. Las dos clases pueden o no ser la misma.
                                • Un Profesor será igual a un EClase si da esa clase.*/
    sealed class Profesor : Universitario
    {
        #region Atributos

        private Queue<EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region CONSTRUCTORES PREGUNTAR !!!!!!!!!!!!!!!!!!

         static Profesor ()
        {
            Profesor.random = new Random();
        }
        
        private Profesor () 
        {
            this.clasesDelDia = new Queue<EClases>();
        }
        
        public Profesor ( int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad) 
            : base (id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia.Enqueue(EClases.Programacion);
        }
        #endregion

        #region PROPIEDADES
        #endregion

        #region METODOS 

        
        private void _randomClases ()
        {
            // debo obtener 2 numeros random y de acuerdo a ello escoger un enumerado.
            
            int auxRandom = -1;
            for (int i=0;i<2;i++)
            {
                auxRandom = Profesor.random.Next(0, 3);
                this.clasesDelDia.Enqueue((EClases)auxRandom);
            }

        }
        /// <summary>
        /// Retorna todos los datos del profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("TOMA CLASES DE: {0}", this.clasesDelDia);
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// retorna las clases que da el profesor. 
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.Append("CLASES DEL DIA:  ");
            
            foreach (EClases item in this.clasesDelDia )
            {
                sb.AppendFormat("{0}", item);
            }
            return sb.ToString();
        }
        #endregion

        #region SOBRECARGAS
        #endregion
    }
}
