using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arismendy.Herik._2A.TP3;

namespace TestEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aux = new Random();
            int enumint = -1;
            for (int i=0; i<2; i++)
            {

                Console.WriteLine("{0}", (EClases)aux.Next(0,3));
                Console.WriteLine("{0}", (EClases)aux.Next(0, 3));
                Console.ReadLine();
            }
        }
    }
}
