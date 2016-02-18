using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodo3
{
    class Program
    {
        public static double tri(double a,double b)
        {
            return (a * b) / 2;
        }
        public static double cir(double r)
        {
            double p=3.1416;
            return (p * r) / 2;
        }
        public static double cua(double l)
        {
            return Math.Pow(l, 2);
        }
        public static double rect(double a, double b)
        {
            return a * b;
        }
        public static void imp(double x)
        {
            Console.WriteLine("Area:   " + x);
        }
        static void Main(string[] args)
        {
            string tipo;
            double ba, alt,ra, r,la;
            Console.WriteLine("Selecciona el la figura" + "\na)Triangulo" + "\nb)Circulo"+"\nc)Cuadrado"+"\nd)Rectangulo"+"\ne)Salir");
            tipo=Console.ReadLine();
            while (tipo != "e")
            {
                switch (tipo)
                {
                    case "a":
                        {
                            Console.WriteLine("base del triangulo");
                            ba = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("altura del triangulo");
                            alt = Convert.ToDouble(Console.ReadLine());
                            r = tri(ba, alt);
                            imp(r);
                        }break;
                    case "b":
                        {
                            Console.WriteLine("radio del circulo");
                            ra = Convert.ToDouble(Console.ReadLine());
                            r = cir(ra);
                            imp(r);
                        }break;
                    case "c":
                        {
                            Console.WriteLine("lado del cuadrado");
                            la = Convert.ToDouble(Console.ReadLine());
                            r = cua(la);
                            imp(r);

                        } break;
                    case "d":
                        {
                            Console.WriteLine("base del rectangulo:");
                            ba = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("altura del rectangulo:");
                            alt = Convert.ToDouble(Console.ReadLine());
                            r = rect(ba, alt);
                            imp(r);
                        } break;

                }
                Console.WriteLine("Selecciona el la figura" + "\na)Triangulo" + "\nb)Circulo" + "\nc)Cuadrado" + "\nd)Rectangulo" + "\ne)Salir");
                tipo = Console.ReadLine();
            }
        }
    }
}
