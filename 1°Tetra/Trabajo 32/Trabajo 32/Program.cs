using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_32
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int N;
            double Nn=0, No;

        //Funcion For
            for (N = 1; N <= 20; N = N + 1)
            {
                Console.WriteLine("Escribe un numero:");
                No = Convert.ToDouble(Console.ReadLine());

                if (No == 0)
                {
                    Nn = Nn + 1;
                }

            }
            Console.WriteLine("La cantidad de numeros nulos son: " + Nn);
            Console.ReadLine();

        }
    }
}
