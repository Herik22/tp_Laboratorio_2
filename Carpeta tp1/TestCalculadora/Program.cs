using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidadess;

namespace TestCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<7;i++)
            {
                Console.WriteLine("Ingrese un numero ");
                double v1 = double.Parse(Console.ReadLine());
                Numero n1 = new Numero(v1);

                Console.WriteLine("Ingrese el otro  numero ");
                double v2 = double.Parse(Console.ReadLine());
                Numero n2 = new Numero(v2);

                Console.WriteLine("Ingrese un el operador  ");
                char operador = char.Parse(Console.ReadLine());

                double result = Calculadora.Operar(n1, n2, Convert.ToString(operador));

                Console.WriteLine(" {0}  {1}   {2}  =  {3:##} ", v1, operador, v2, result);
                //Console.ReadLine();
            }
           

            /*for (int i=0;i<6;i++)
            {
                Console.WriteLine("Ingrese un  numero  ");
                string numero = Console.ReadLine();

                double numeroDouble = Numero.ValidarNumero(numero);

                Console.WriteLine("Numero convertido {0}  ", numeroDouble);
                Console.ReadLine();
            }*/

            /*for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un  numero  ");
                string numero = Console.ReadLine();
                numero.
                double buffer;
                Numero n1 = new Numero(numero);
                buffer = n1.GetNumero();
                Console.WriteLine("Numero= {0}", buffer);
                Console.ReadLine();
            }*/

            /*for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un  numero  ");
                string numero = Console.ReadLine();
                bool esBinario = Numero.EsBinario(numero);
                //Console.WriteLine("{0}", numero.Substring(i,1));
                if (esBinario)
                { 
                    Console.WriteLine("ES BINARIO");
                }
                else { Console.WriteLine("NO ES BINARIO"); }
            }*/

            /*for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un  numero binario  ");
                string numero = Console.ReadLine();
                bool esBinario = Numero.EsBinario(numero);
                //Console.WriteLine("{0}", numero.Substring(i,1));
                if (esBinario)
                {
                  string decumal =  Numero.BinarioDecimal(numero);
                  Console.WriteLine("el binario {0} en decimal es {1}",numero,decumal);
                }
                else { Console.WriteLine("NO ES BINARIO"); }
            }*/

            /*for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un  numero decimal  ");
                double numero = double.Parse(Console.ReadLine());
                //bool esBinario = Numero.EsBinario(numero);
                //Console.WriteLine("{0}", numero.Substring(i,1));

                string binario = Numero.DecimalBinario(numero);
                 Console.WriteLine("el decimal {0} en binario es {1}", numero,binario);
            }*/

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese un  numero decimal  ");
                string numero = Console.ReadLine();
               
                string binario = Numero.DecimalBinario(numero);
                Console.WriteLine("el decimal {0} en binario es {1}", numero, binario);
            }
        }
    }
}
