using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_23
{
    class Program
    {
        static void Main(string[] args)
        {
       //Declaracion de variable
            double M, C;

        //Lectura de datos
            Console.WriteLine("Escribe el numero de monto:");
            M = Convert.ToDouble(Console.ReadLine());

        //Condicion
            if (M < 500)
            {
                Console.WriteLine("El monto es de " + M);

            }
            else if (M < 1000)
            {
                C = M * .15;
                Console.WriteLine("El monto es de " + C);
            }
            else if (M < 7000)
            {
                C = M * .11;
                Console.WriteLine("El monto es de " + C);
            }
            else if (M < 15000)
            {
                C = M * .18;
                Console.WriteLine("El monto es de " + C);
            }
            else if (M > 15000)
            {
                C = M * .25;
                Console.WriteLine("El monto es de " + C);
            }
            Console.ReadLine();

        }
    }
}
