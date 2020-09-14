using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadess
{
    public class Numero
    {
        #region ATRIBUTOS

        private double numero;

        #endregion

        #region PROPIEDADES
        private void SetNumero(string srtNumero)
        {
            double valor;
            valor = ValidarNumero(srtNumero);
            if (valor != 0)
            {
                numero = valor;
            }
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Convierte un binario a decimal. de no lograrlo retornara "Valor invalido"
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>        
        public static string BinarioDecimal(string binario)
        {
            bool isBinario = EsBinario(binario);
            int auxValor = 0;
            if (isBinario)
            {
                double binDoub = Convert.ToDouble(binario);
                double binAbsol = Math.Abs(binDoub);
                string binString = Convert.ToString(binAbsol);
                auxValor = Convert.ToInt32(binString, 2);
                return Convert.ToString(auxValor);
            }
            else
            {
                return "Valor Invalido";

            }
        }

        /// <summary>
        /// Convierte un numero decimal en binario, de no poder retornara "valor invalido" 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            double numAbs = Math.Abs(numero);
            int valorI = Convert.ToInt32(numAbs);
            string binario = Convert.ToString(valorI, 2);
            bool isBinario = EsBinario(binario);
            if (isBinario)
            {
                return binario;
            }
            else
            {
                return "Valor Invalido";
            }
        }
        /// <summary>
        /// Convierte un numero decimal recibido como (string) en binario, de no poder retornara "valor invalido" 
        /// </summary>
        /// <param name="srnumero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string srnumero)
        {
            double numValidado;
            double.TryParse(srnumero, out numValidado);
            if (numValidado != 0)
            {
                double numAbs = Math.Abs(numValidado);
                return DecimalBinario(numAbs);
            }
            else
            {
                return "Valor Invalido";
            }


        }
      
        /// <summary>
        /// Valida que la cadena recibida solo contenga (0/1).
        /// </summary>
        public static bool EsBinario(string strNumero)
        {
            bool check = false;
            for (int i = 0; i < strNumero.Length; i++)
            {
                
                if(strNumero.Substring(i,1) == "0" || strNumero.Substring(i,1) == "1") /// 011
                {
                    check = true; 
                }else
                {
                    return false;
                }   
            }
            return check;
        }

        /// <summary>
        /// Comprueba que el valor recibido sea numerico y lo retornara , de lo contrario retorna 0 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public static double ValidarNumero(string strNumero)
        {
            double numDouble;
            if (double.TryParse(strNumero, out numDouble))
            {
                return numDouble;
            }
            else
            {
                return 0;
            }
        }


        #endregion

        #region CONTRUCTORES

        public Numero ()
        {
            numero = 0; 
        }

        public Numero(double numeroD)
        {
            numero = numeroD;
        }

        public Numero(string srtnumero)
        {
            this.SetNumero(srtnumero);
        }

        #endregion

        #region SOBRECARGAS
        public static double operator + (Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator * (Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator / (Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }else
            {
                return n1.numero / n2.numero;
            }
            

        }

        #endregion
    }
}
