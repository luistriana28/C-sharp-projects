using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_31
{
    class Program
    {
        static void Main(string[] args)
        {
         // Declaracion de Variable
            int N;
            double no = 0, Np, P;

         //Funcion For
            for (N = 1; N <= 10; N = N + 1)
            {
                Console.WriteLine("Escribe el numero que sea positivo:");
                Np = Convert.ToDouble(Console.ReadLine());

                if (Np >= 0)
                {
                    no = no + Np;
                }
                else
                {
                    no = Np;
                }
            }

        //Imprimir
            if (no >= 0)
            {
                P = no / 10;
                Console.WriteLine("El numero total es de " + P);
            }
            else
            {
                Console.WriteLine("El numero no es postivo, vuelva a intentarlo.");
            }

            Console.ReadLine();

        }
    }
}
