using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_20
{
    class Program
    {
        static void Main(string[] args)
        {//Declaracion de variable
            double C1, C2, C3, P;

        //Lectura de datos
            Console.WriteLine("Escribe la 1ra calificacion");
            C1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la 2da calificacion");
            C2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la 3ra calificacion");
            C3 = Convert.ToDouble(Console.ReadLine());

        //Proceso
            P = (C1 + C2 + C3) / 3;

        //Condicion
            if (P<50)
            {
                Console.WriteLine ("Pesimo");
            }
            else if (P<70)
            {
                Console.WriteLine ("Malo");
            }
            else if (P<80)
            {
                Console.WriteLine ("Regular");
            }
            else if (P<95)
            {
                Console.WriteLine ("Bueno");
            }
            else if (P<=100)
            {
                Console.WriteLine ("Excelente");
            }
            Console.ReadLine();

        }
    }
}
