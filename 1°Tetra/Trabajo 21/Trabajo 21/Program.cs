using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_21
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double jg, jp, je, x;
            String n;

        //Lectura de datos
            Console.WriteLine("Escribe el nombre del equipo");
            n=Console.ReadLine();
            Console.WriteLine("Escribe los puntos del 1er partido");
            jg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe los puntos del 2do partido");
            jp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe los puntos del 3er partido");
            je = Convert.ToDouble(Console.ReadLine());

        //Proceso
            x = (jg * 3) + (je * 1) + (jp * 0);

        //Condicion
            if (x >= 30)
            {
                Console.WriteLine("Clasificado, " + n);
            }
            else if (x <= 30)
            {
                Console.WriteLine("Eliminado, " + n);
            }
            Console.ReadLine();

        }
    }
}
