using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_16
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double p, q, x;

        //Lectura de datos;
            Console.WriteLine("Escribe el p:");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el q:");
            q = Convert.ToDouble(Console.ReadLine());

        //Proceso;
            x = (p * p * p) + (q * q * q * q) - 2 * (p * p);

        //Condicional;
            if (x < 680)
            {
                Console.WriteLine("El valor de x es: " + x);
                Console.WriteLine("Gracias por su atención :D");
            }
                        
                Console.ReadKey();
            
        }
    }
}
