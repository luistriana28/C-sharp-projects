using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo Ci = new Circulo();
            Cuadrado Cu = new Cuadrado();
            Triangulo Tri = new Triangulo();
            Rectangulo Rec = new Rectangulo();

            Console.WriteLine("                              ¡¡¡FIGURAS!!!\n\n");

            double r;
            Console.WriteLine("Figura. Circulo:\nEscribe el radio del circulo:");
            r = Convert.ToDouble(Console.ReadLine());
            Ci.SetRadio(r);
            Ci.CalcArea();
            Ci.CalcPerimetro();
            Console.WriteLine("\nEntonces. El Area del circulo es: " + Ci.GetArea() + "\nEl Perimetro del circulo es: " + Ci.GetPerimetro());

            double l;
            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("Figura. Cuadrado:\nEscribe el Lado del cuadrado:");
            l = Convert.ToDouble(Console.ReadLine());
            Cu.SetLado(l);
            Cu.CalcArea();
            Cu.CalcPerimetro();
            Console.WriteLine("\nEntonces. El Area del cuadrado es: " + Cu.GetArea() + "\nEl Perimetro del cuadrado es: " + Cu.GetPerimetro());

            double b, h;
            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("Figura. Triangulo:\nEscribe la base del Triangulo:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora. Escribe la altura del Triangulo:");
            h = Convert.ToDouble(Console.ReadLine());
            Tri.SetAltura(h);
            Tri.SetBase(b);
            Tri.CalcArea();
            Tri.CalcPerimetro();
            Console.WriteLine("\nEntonces. El Area del Triangulo es: " + Tri.GetArea() + "\nEl Perimetro del Triangulo es: " + Tri.GetPerimetro());

            double br, hr;
            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("Figura. Rectangulo:\nEscribe la base del rectangulo:");
            br = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ahora.Escribe la altura del Rectangulo:");
            hr = Convert.ToDouble(Console.ReadLine());
            Rec.SetAltura(hr);
            Rec.SetBase(br);
            Rec.CalcArea();
            Rec.CalcPerimetro();
            Console.WriteLine("\nEntonces. El Area del Rectangulo es: " + Rec.GetArea() + "\nEl Perimetro del Rectangulo es: " + Rec.GetPerimetro());

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
