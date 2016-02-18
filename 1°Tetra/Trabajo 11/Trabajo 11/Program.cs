using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_11
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de valores;
            double M, E, C, R, A, B, T;

        //Lectura de datos;
            Console.WriteLine("Escribe el valor de la primera calificacion de un alumno:");
            M = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de la segunda calificacion de un alumno:");
            E = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe el valor de la tercera calificacion de un alumno:");
            C = Convert.ToDouble(Console.ReadLine());

        //Procedimiento;
            A = M * .30;
            B = E * .30;
            R = C * .40;
            T = A + B + R;

        //Imprimir;
            Console.WriteLine("El resultado de las tres calificaciones en el parcial es de "+ T);
            Console.ReadLine();

        }
    }
}
