using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_29
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double Imp, x;
            int col;

        //Lectura de datos
            Console.WriteLine("Ingresa tu importe:");
            Imp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el color de la pelota." + "\nAzul, 1ra opcion.  Rojo, 2da opcion.  Blanco, 3ra opcion (Solo puedes poner del 1 al 3):");
            col = Convert.ToInt16(Console.ReadLine());

        //Multiple
            switch (col)
            {
                case 1:
                    {
                        x = Imp * .80;
                        Console.WriteLine("Tu total con descuento es de " + x +" $");
                    } break;
                case 2:
                    {
                        x = Imp * .70;
                        Console.WriteLine("Tu total con descuento es de " + x + " $");
                    } break;
                case 3:
                    {
                        x = Imp;
                        Console.WriteLine("Tu total con descuento es de " + x + " $");
                    } break;
                default:
                    {
                        Console.WriteLine("Tu total no valido");
                    } break;
            }

        //Imprimir
            Console.ReadLine();
        }
    }
}
