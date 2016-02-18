using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo__18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable;
            double r, L, A, Ac;

            //lectura de datos;
            Console.WriteLine("Escribe el valor del radio:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor del lado del cuadrado:");
            L = Convert.ToDouble(Console.ReadLine());

            //Proceso;
            A = 3.14 * (r * r);
            Ac = L * L;

            //Condicion;
            if (A < Ac)
            {
                Console.WriteLine("El area del circulo es menor que el area del cuadrado, ¡¡¡EXCELENTE!!! :D");
            }
            else
            {
                Console.WriteLine("El area del circulo es mas grande que el del cuadrado, ¡¡¡PERDEDOR!!! D:");

            }
            Console.ReadLine();

        }
    }
}
