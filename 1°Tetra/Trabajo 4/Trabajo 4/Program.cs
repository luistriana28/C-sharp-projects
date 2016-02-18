using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_4
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double A, b, h;

        //Lectura de datos;
            Console.WriteLine("Escriba el valor de la b (Base):");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la h (Altura):");
            h = Convert.ToDouble(Console.ReadLine());

        //Proceso;
            A = (b * h) / 2;

        //Imprimir;
            Console.WriteLine("El valor de la A, que es el Area; el resultado es: "+ A);
            Console.ReadLine();
            
        }
    }
}
