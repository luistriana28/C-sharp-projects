using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_8
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double Ns, Nd;

        //Lectura de datos;
            Console.WriteLine("Escribe el numero de días, declarando que Nd se refiera e eso:");
            Nd = Convert.ToDouble(Console.ReadLine());

        //Proceso;
            Ns = Nd * 86400;

        //imprimir;
            Console.WriteLine("Los numeros de los días que aclarastes son los siguienes segundos: " + Ns);
            Console.ReadLine();

        }
    }
}
