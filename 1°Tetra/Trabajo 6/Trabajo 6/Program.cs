using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_6
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double g, L, P;

        //Lectura de datos;
            Console.WriteLine("Escribe el valor de g:");
            g = Convert.ToDouble(Console.ReadLine ());

        //Proceso;
            L = g * 3.785;
            P = L * 11.20;
        //Imprimir;
            Console.WriteLine("El resultado de L es: "+ L);
            Console.WriteLine("El resultado de P es: "+ P);
            Console.ReadLine();

        }
    }
}
