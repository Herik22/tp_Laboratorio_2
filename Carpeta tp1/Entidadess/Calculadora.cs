using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadess
{
    public  class Calculadora
    {
        //static int numero;
        #region METODOS

        /// <summary>
        /// Valida y realiza la operacion a hacer. 
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double returnn = 0;
            if(string.IsNullOrEmpty(operador))
            {
                operador = "+";
            }
            
            switch (Calculadora.ValidarOperador(Convert.ToChar(operador)))
            {
                case "+":
                    returnn = numero1 + numero2;
                    break;
                case "-":
                    returnn = numero1 - numero2;
                    break;
                case "*":
                    returnn = numero1 * numero2;
                    break;
                case "/":
                    returnn = numero1 / numero2;
                    break;              
            }
            return returnn;
        }

        /// <summary>
        /// Valida que el operador recibido sea uno de estos 4 operadores ( + , - , * , / ) en caso contrario retorna +.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>
        private static string ValidarOperador(char operador)//recibia string 
        {

            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return Convert.ToString(operador);
            }
            if ( char.IsWhiteSpace(operador) )
            {
                return "+";
            }else
            { return "das"; }
            //return operador;
        }

        #endregion

        #region CONSTRUCTORES

        public Calculadora()
        {

        }

        #endregion


        #region SOBRECARGAS


        #endregion

    }
}


