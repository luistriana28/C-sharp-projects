using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_9
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double A, B, C, Er, Do, Ro;

        //Lectura de datos;
            Console.WriteLine("Escriba el valor de A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de B:");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba el valor de C:");
            C = Convert.ToDouble(Console.ReadLine());

        //Proceso;
            Er = A * .10 + A;
            Do = B * .12 + B;
            Ro = C * .15 + C;

        //Imprimir;
            Console.WriteLine("El resultado de Er del primer aumento del empleado es: " + Er);
            Console.WriteLine("El resultado de Do del segundo aumento del empleado es: " + Do);
            Console.WriteLine("El resultado de Ro del tercero aumento del empleado es: " + Ro);
            Console.ReadLine();

        }
    }
}
