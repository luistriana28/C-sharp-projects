using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y,a,b;
            Console.WriteLine("Valor de x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor de b:");
            b = Convert.ToDouble(Console.ReadLine());
            suma obj1 = new suma(x,y);
            suma obj2 = new suma(a,b);
            obj1.sumando();
            obj1.print();
            obj2.sumando();
            obj2.print();
            Console.ReadKey();

        }
    }
    class suma
    {
        double n1, n2, r;

        public suma(double x, double y)
        {
            n1 = x;
            n2 = y;
        }
        public void sumando()
        {
            r = n1 + n2;
            
        }
        public void print()
        {
            Console.WriteLine("La suma es:"       + r);
        }
    }
}
