using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arismendy.Herik.tp4;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Sneakers s1 = new Sneakers ("JORDAN AJ1 ", 10,200, EProcedencia.Afganistan);
            Sneakers s2 = new Sneakers("OZZWEGO ", 10, 2000, EProcedencia.EstadosUnidos);
            Sneakers s3 = new Sneakers("OZZWEGO ", 10, 2000, EProcedencia.EstadosUnidos);

            Botines b1 = new Botines("ADIDAS F50", 9 , 500, true);
            Botines b2 = new Botines("PUMA RXT", 8, 1000, false);

            Cliente cliente = new Cliente("Prueba", 958893, "salta654", 500, EMetodoPago.Efectivo);

            Carrito c1 = new Carrito();
            Carrito c2 = new Carrito();

            c1 += s1;
            c1 += s2;

            c1 += b1;
            c1 += b2;

            if(s2 == s3)
            {
                Console.WriteLine("Son iguales");
            }

            Console.WriteLine(c1.ToString());
            Console.ReadLine();
            Console.WriteLine(c2.ToString()); // no deberia mostrar
            Console.ReadLine();

            EMetodoPago auxMetodo =  cliente.StringaMetodoPago("Efectivo");
            if (auxMetodo == EMetodoPago.Efectivo)
            {
                Console.WriteLine("EXITO!!");
            }
            Console.ReadLine();

        }
    }
}
