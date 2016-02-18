using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_16
{
    class Program
    {
        static void Main(string[] args)
        {
         //Declaracion de Variable;
            int n;

        //Lectura de Datos;
            Console.WriteLine("Escribe el numero positivo:");
            n = Convert.ToInt32(Console.ReadLine());

        //Imprimir;
            if (n > 0)
            {
                Console.WriteLine("Numero Positivo");
            }
            else if (n < 0)
            {
                Console.WriteLine("Numero Negativo");
            }
            else
            {
                Console.WriteLine("Numero Nulo");
            }
            
            Console.ReadKey();

        }
    }
}
