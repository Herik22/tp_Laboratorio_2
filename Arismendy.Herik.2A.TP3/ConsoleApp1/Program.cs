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
            Profesor prueba = new Profesor(1, "rick", "sanchez", "95889316", Persona.ENacionalidad.Extranjero);
            

            Alumno a1 = new Alumno(1, "dirty", "man", "123456", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            Alumno a2 = new Alumno(2, "pepsi", "man", "987567", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Alumno a3 = new Alumno(3, "spider", "man", "9876543", Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            Alumno a4 = new Alumno(4, "caza", "man", "23245", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Jornada j1 = new Jornada(Universidad.EClases.Programacion, prueba);

            j1 += a1;
            j1 += a2;
            j1 += a3;
            j1 += a4;

            Console.WriteLine(j1.ToString());
            Console.ReadLine();
        }
    }
}
