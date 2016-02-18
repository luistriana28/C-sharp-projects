using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_7
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double A, B, X;

        //Lectura de datos;
            Console.WriteLine("Escribe el valor de A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de B:");
            B = Convert.ToDouble(Console.ReadLine());
        //Proceso;
            X = (A + B) * (A + B) / 3;

        //Imprimir;
            Console.WriteLine("El valor de X es igual a " + X);
            Console.ReadLine();

        }
    }
}
