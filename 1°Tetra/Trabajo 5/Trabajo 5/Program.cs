using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_5
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable;
            double C, Ca, Pc;

        //Lectura de datos;
            Console.WriteLine("Escriba el valor del Costo del articulo (Ca):");
            Ca = Convert.ToDouble(Console.ReadLine ());
            Console.WriteLine("Escriba el valor del pago del cliente (Pc):");
            Pc = Convert.ToDouble(Console.ReadLine());

        //Proceso;
            C = Pc - Ca;

        //Imprimir;
            Console.WriteLine("El cambio de dinero (C), te dan de efectivo como: "+ C);
            Console.ReadLine();

        }
    }
}
