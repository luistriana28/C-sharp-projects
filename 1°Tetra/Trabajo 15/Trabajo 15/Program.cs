using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_15
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double c1, c2, c3, c4, c5, R;
            string M;

        //Lectura de datos;
            Console.WriteLine("Escribe la matricula");
            M=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Escribe la 1ra calificacion:");
            c1= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Escribe la 2da calificacion:");
            c2= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Escribe la 3ra calificacion:");
            c3= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Escribe la 4ta calificacion:");
            c4= Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Escribe 5ta 1ra calificacion:");
            c5= Convert.ToDouble (Console.ReadLine());

        //Prolema;
            R= (c1+c2+c3+c4+c5) /5;

        //Imprimir;
            if (R >=70)
            {
                Console.WriteLine("Matricula: " + M + "\nPromedio: " + R + "\nAPROBADO");
            }
            else
            {
                Console.WriteLine("Matricula: " + M + "\nPromedio: " + R + "\nREPROBADO");
            }
            {
                Console.ReadLine();

        }
        }
    }
}
