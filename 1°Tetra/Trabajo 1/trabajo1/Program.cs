using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace trabajo1
{
    class Program
    {
        static void Main(string[] args)
        {D:\Universidad\1er Cuatrimestre\Melgem 1 D\Trabajos de Visual\Trabajo 1\trabajo1\Program.cs
        //Declaracion de variable.
            double P, C1, C2, C3, C4, C5;
            string M;

            //Lectura de Datos
            Console.WriteLine("Escribe el valor de C1: ");
            C1 = Convert.ToDouble(Console.ReadLine ());
            Console.WriteLine("Escribe el valor de C2: ");
            C2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de C3: ");
            C3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de C4: ");
            C4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de C5: ");
            C5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pon tu nombre:");
            M = Console.ReadLine();

            //Proceso
            P = (C1 + C2 + C3 + C4 + C5) / 5;
        
            //Imprimir
            Console.WriteLine("El valor de la expresion es "+ P);
            Console.WriteLine("Hasta la vista "+ M);
            Console.ReadLine();

        }
    }
}
