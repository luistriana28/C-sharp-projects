using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_30
{
    class Program
    {
        static void Main(string[] args)
        {
        // Declaracion de Variable
            int i;
            double num=0, S;
            
        //Funcion For
            for (i = 1; i <= 5; i = i + 1)
            {
                Console.WriteLine("Escribe el numero de sueldo:");
                S = Convert.ToDouble(Console.ReadLine());

                num = num + S;
            }
            Console.WriteLine("El numero total es de $" + num + "Eres Millonario");
            Console.ReadLine();
        }
    }
}
