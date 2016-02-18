using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_34
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int i;
            double Ssumaspares=0;

        //Funcion for
            for (i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine("Escribe cualquier valor, la suma de pares:");
                Ssumaspares=Convert.ToDouble(Console.ReadLine());

                Ssumaspares=Ssumaspares+i;
            }

        //Imprimir
            Console.WriteLine("Su suma de positivos es de " + Ssumaspares);
            Console.ReadLine();

        }
    }
}
