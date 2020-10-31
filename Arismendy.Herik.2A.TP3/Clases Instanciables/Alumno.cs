using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno():this (default,default,default,default,default,default,default)
        { }

        /// <summary>
        /// Constructor parametrizado que invoca al contructor base.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor parametrizado para todos los atributos. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }


        #endregion

        #region PROPIEDADES
        #endregion

        #region METODOS 

        /// <summary>
        /// sobreescribe el metodo mostrarDatos con los datos del alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendFormat("ESTADO DE CUENTA: {0}", this.estadoCuenta);
            sb.AppendLine();
            sb.AppendFormat("TOMA CLASES DE : {0}", this.claseQueToma);
            sb.AppendLine();


            return sb.ToString();
        }

        /// <summary>
        /// Retorna la una cadena con la clase que toma.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASE DE:" + this.claseQueToma;
        }

        /// <summary>
        /// Hace publico los datos del alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


        #endregion

        #region SOBRECARGAS 

        /// <summary>
        /// Seran iguales si el alumno toma la clase y su estado de cuenta No es deudor.
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a1, Universidad.EClases clase) //PREGUNTAR QUE ONDA POR EL EQUALS 
        {

            return a1.claseQueToma == clase && a1.estadoCuenta != EEstadoCuenta.Deudor;
        }
        /// <summary>
        /// Sera distinto si no toma esa clase. 
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator != (Alumno a1, Universidad.EClases clase)
        {

            return a1.claseQueToma != clase;
        }
        #endregion

        #region ENUMERADOS

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #endregion
    }
}
