using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_17
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            int A, B, C2, C3;

            do
            {
                //Lectura de datos;
                Console.WriteLine("Escribe el primer valor:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escribe el segundo valor:");
                B = Convert.ToInt32(Console.ReadLine());

                //Proceso;
                C2 = A * A;
                C3 = B * B * B;

                //Condicion;
                if (C2 > C3)
                {
                    Console.WriteLine("El cuadrado de " + C2 + " es mayor que el valor de " + C3 );
                }
                else
                {
                    Console.WriteLine ("Vuelve a intentarlo.");

                }
            }
            while (C2 < C3);
            Console.ReadKey();

        }
    }
}
