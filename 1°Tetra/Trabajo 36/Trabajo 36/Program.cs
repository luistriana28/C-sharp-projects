using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_36
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int i;
            double Ffahenheit = 0;

            Console.ReadLine();

        //Funcion for
            for (i = 0; i <= 50; i = i + 2)
            {
                
                Console.WriteLine("");
                Console.WriteLine("Los grados Celcius es de " + i + ".");
                
                Ffahenheit = 9 / 5 * i + 32;

                Console.WriteLine("Entonces, los grados Fahenheit es de " + Ffahenheit + ".");
                
            }

        //Imprimir
            Console.WriteLine("");
            Console.WriteLine("Hasta aquí termina la tabla de conversion. Gracias por su atención.");
            Console.ReadLine();

        }
    }
}
