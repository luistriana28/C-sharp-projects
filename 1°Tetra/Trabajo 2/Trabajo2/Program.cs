using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo2
{
    class Program
    {
        static void Main(string[] args)
        {
       //Declaracion de variable
            double Cu, Cub, A;

       //Lectura de datos
            Console.WriteLine("Escriba el valor de A");
            A = Convert.ToDouble(Console.ReadLine ());

       //Proceso
            Cu = A * A;
            Cub = A * A * A;

       //Impromir
            Console.WriteLine("El valor de la expresion de Cu es: "+ Cu + ", y el valor de la expresion de Cub es: "+ Cub);
            Console.ReadLine();

        }
    }
}
