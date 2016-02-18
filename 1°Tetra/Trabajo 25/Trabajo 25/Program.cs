using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_25
{
    class Program
    {
        static void Main(string[] args)
        {
        //declaracion de variable
            double c;

        //lectura de datos
            Console.WriteLine("Escibe tu calificacion:");
            c = Convert.ToDouble(Console.ReadLine());

        //condicion
            if (c > 8)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
            Console.ReadLine();

                    
        }
    }
}
