using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodo2_triana
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, x, y;
            x= altura();
            y= lado();
            r = area(x,y);
            impri(r);
            Console.ReadKey();
           
        }
        public static double altura()
        {
            double x;
            Console.WriteLine("Base del triangulo:");
            x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        public static double lado()
        {
            double y;
            Console.WriteLine("Altura del triangulo:");
            y = Convert.ToDouble(Console.ReadLine());
            return y;
        }
        public static double area(double x, double y)
        {
            double result;
            result = (x * y) / 2;
            return result;
        }
        public static void impri(double r)
        {
            Console.WriteLine("Area del triangulo:    "       + r);
        }

    }
}
