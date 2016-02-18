using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_13
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de Variable;
            double R, A, V, S;

        //Lectura de datos;
            Console.WriteLine("Sacar el Area y el volumen de un cilindro.");
            Console.WriteLine("Ingresa el valor de la Altura");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el valor del Radio");
            R = Convert.ToDouble(Console.ReadLine());

        //Procedimiento;
            V = 3.1416 * (R * R) * A;
            S = (2 * 3.1416) * R * A;

        //Imprimir;
            Console.WriteLine("El resultado del Volumen es de " + V);
            Console.WriteLine("El resultado del Area es de " + S);
            Console.WriteLine("Gracias por poner atencion, Bye.");
            Console.ReadLine();

        }
    }
}
