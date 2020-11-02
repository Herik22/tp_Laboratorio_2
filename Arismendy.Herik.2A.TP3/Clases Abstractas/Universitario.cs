using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// COnstructor por defecto de tipo Persona
        /// </summary>
        public Universitario() : this (default,default,default,default,default)
        { }

        /// <summary>
        /// Constructor parametrizado que invoca al constructor base. 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }



        #endregion

        #region METODOS 

        /// <summary>
        /// retorna todos los datos del universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("LEGAJO NUMERO: {0}", this.legajo);
            sb.AppendLine();

            return sb.ToString();
        }
        /// <summary>
        /// metodo protegido y asbtracto para participar en clase
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Metodo Equals que compara por tipo y legajo o dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is Universitario)
            {
                rta = this == (Universitario)obj;
            }
            return rta;
        }
        #endregion

        #region SOBRECARGAS 
        /// <summary>
        /// TRUE: si son del mismo tipo y  legajo o dni son iguales.
        /// FALSE: lo contrario. 
        /// </summary>
        /// <param name="u1"></param>
        /// <param name="u2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario u1, Universitario u2)
        {         
            return (u1.GetType() == u2.GetType() && (u1.legajo == u2.legajo || u1.Dni == u2.Dni) );
        }

        public static bool operator !=(Universitario u1, Universitario u2)
        {
            return !(u1 == u2);
        }

        #endregion
    }
}
