using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_14
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double s, ns;

        //Lectura de datos;
            Console.WriteLine("Escribe el sueldo:");
            s = Convert.ToDouble(Console.ReadLine());

            if (s < 1000)
            {
                ns = s * 1.15;

         //Imprimir;
                Console.WriteLine("Su nuevo sueldo es de " + ns);
                Console.ReadLine();
            }
        }
    }
}
