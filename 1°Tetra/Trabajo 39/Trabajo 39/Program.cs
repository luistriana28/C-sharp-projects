using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_39
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            double Nnumero;

            Console.WriteLine("Escribe cualquier numero que te pase por la mente, pero que no sea bajo a 0:");
            Nnumero = Convert.ToDouble(Console.ReadLine());


            //Funcion while
            while (Nnumero > 1)
            {
                if (Nnumero % 2 == 0)
                {
                    Nnumero = Nnumero / 2;
                    Console.WriteLine(Nnumero);
                }
                else
                {
                    Nnumero = (Nnumero * 3) + 1;
                    Console.WriteLine(Nnumero);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Gracias por usarme. :D");
            Console.ReadLine();

        }
    }
}
