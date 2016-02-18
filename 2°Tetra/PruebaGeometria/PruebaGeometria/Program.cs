using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaGeometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
        //Lectura de Datos
            //Circulo
            Console.WriteLine("\n-------- Circulo ---------------------------------------------------------------");
            Console.WriteLine("El Area de su Circulo es:   " + Circulo.CalcArea(25));
            Console.WriteLine("El Perimetro de su Circulo es:   " + Circulo.CalcPerimetro(25));
            
            //Cuadrado
            Console.WriteLine("\n-------- Cuadrado --------------------------------------------------------------");
            Console.WriteLine("El Area de tu Cuadrado es:   " + Cuadrado.CalcArea(25));
            Console.WriteLine("El Perimetro de su Cuadrado es:   " + Cuadrado.CalcPerimetro(25));

            //Triangulo
            Console.WriteLine("\n-------- Triangulo -------------------------------------------------------------");
            Console.WriteLine("El Area de su Triangulo es:   " + Triangulo.CalcArea(5, 3));
            Console.WriteLine("El Perimetro de su Triangulo es:   " + Triangulo.CalcPerimetro(5));
            
            //Rectangulo
            Console.WriteLine("\n-------- Rectangulo ------------------------------------------------------------");
            Console.WriteLine("El Area de su Rectangulo es:   " + Rectangulo.CalcArea(5, 3));
            Console.WriteLine("El Perimetro de su Rectangulo es:   " + Rectangulo.CalcPerimetro(5, 3));

            //Cilindro
            Console.WriteLine("\n-------- Volumen ---------------------------------------------------------------");
            Console.WriteLine("El Volumen de su Cilindro es:  " + Cilindro.CalcVolumen(5, 3));

            //Esfera
            Console.WriteLine("\n-------- Esfera ---------------------------------------------------------------");
            Console.WriteLine("El Volumen de su Esfera es:   " + Esfera.CalcVolumen(25));
            Console.ReadKey();
        }
    }
}
