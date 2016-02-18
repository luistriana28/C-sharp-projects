using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_12
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double R, cer, cdo, cro, crto, cto;
            string M;

        //Lectura de datos;
            Console.WriteLine("Escriba el valor de la Matricula:");
            M = Console.ReadLine();
            Console.WriteLine("Escriba el valor de la 1ra calificacion:");
            cer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la 2da calificacion:");
            cdo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la 3ra calificacion:");
            cro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la 4to calificacion:");
            crto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de la 5to calificacion:");
            cto = Convert.ToDouble(Console.ReadLine());

        //Procedimiento;
            R = (cer + cdo + cro + crto + cto) / 5;

        //Imprimir;
            Console.WriteLine ("El resultado de las 5 calificaciones, es "+ R);
            Console.WriteLine("Gracias por ver el resultado :D");
            Console.ReadLine ();

        }
    }
}
