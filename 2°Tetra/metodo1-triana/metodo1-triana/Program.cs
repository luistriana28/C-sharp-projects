using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodo1_triana
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, resultado;
            Console.WriteLine("Valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de d:");
            d = double.Parse(Console.ReadLine());
            resultado = operacion(a, b, c, d);
            Console.WriteLine("Operacion:" + resultado);
            Console.ReadKey();
        }

        public static double operacion(double x, double y, double z, double w)
        {
            double resultado;
            resultado = ((Math.Pow(x + y, 3)) - 2 * z) / (Math.Sqrt(z + w));
            return resultado;
        }
    }
}
