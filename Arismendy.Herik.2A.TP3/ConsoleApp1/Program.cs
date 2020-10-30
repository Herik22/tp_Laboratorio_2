using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Clases_Instanciables;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor prueba = new Profesor(1, "herik", "uribe", "95889316", Persona.ENacionalidad.Extranjero);
            Console.WriteLine("{0}", prueba.ToString());
            Console.ReadLine();
        }
    }
}
