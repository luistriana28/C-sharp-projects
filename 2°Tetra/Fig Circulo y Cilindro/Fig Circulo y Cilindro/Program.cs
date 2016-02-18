using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fig_Circulo_y_Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de Variable
            Cilindro Cln = new Cilindro();

        //Lectura de Datos
            Console.WriteLine("             ¡¡¡FIGURAS DEL CIRCULO Y CILINDRO!!!\n");

            Console.WriteLine("------------------- Circulo ------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Calcular el Area de Un circulo.\nCuanto es el Radio:");
            Cln.SetRadio(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("____________________________________\n");
            Cln.CalcArea();
            Console.WriteLine("Si el Radio es: " + Cln.GetRadio());
            Console.WriteLine("\nEntonces. El Area del circulo es: " + Cln.GetArea());

            Console.WriteLine("\n\n¡¡¡DE ENTER PARA CONTINUAR!!!");
            Console.ReadKey();

            Console.WriteLine("\n\n------------------- Cilindro -----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Con los mismos datos, sacaremos el Volumen de un Cilindro.\nCuanto es la Altura:");
            Cln.SetAltura(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("____________________________________\n");
            Cln.CalcVolumen();
            Console.WriteLine("Si el Radio es: " + Cln.GetRadio() + "\nY Si la Altura es: " + Cln.GetAltura());
            Console.WriteLine("\nEntonces. El Volumen del Cilindro es: "+Cln.GetVolumen());

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
