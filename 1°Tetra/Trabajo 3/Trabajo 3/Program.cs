using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_3
{
    class Program
    {
        static void Main(string[] args)
        {
    //Declaracion de variable;
            double S, P, B, A;

    //Lectura de datos;
            Console.WriteLine("Escriba el valor de la B");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la A");
            A = Convert.ToDouble(Console.ReadLine());

    //Proceso;
            S = B * A;
            P = 2 * (B + A);

    //Imprimir
            Console.WriteLine ("El valor de la expresión S (Superficie), da ha "+ S);
            Console.WriteLine("El valor de la expresión P (Perimetro), da ha "+ P);
            Console.ReadLine();

        }
    }
}
