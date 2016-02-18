using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_10
{
    class Program
    {
        static void Main(string[] args)
        {
         //Declaracion de variable;
            double P, D;

        //Lectura de datos;
            Console.WriteLine("Escriba el valor del dinero en pesos, para después convertirlo en dolar:");
            P = Convert.ToDouble(Console.ReadLine ());

        //Procedimiento;
            D = P / 12.89;

        //Imprimir;
            Console.WriteLine("El valor que acaba de poner, su precio en dolar es de "+ D);
            Console.ReadLine();
            
        }
    }
}
