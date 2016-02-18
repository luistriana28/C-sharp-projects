using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_switch_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double S, Ns, Sf, B;
            int cat;

        //Lectura de datos
            Console.WriteLine("Escribe el nuevo sueldo del trabajador:");
            S = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe la categoria del trabajador:");
            cat = Convert.ToInt32(Console.ReadLine());

        //Selector
            switch (cat)
            {
                case 1:
                    {
                        Ns = S * 1.20;
                    } break;
                case 2:
                    {
                        Ns = S * 1.15;
                    } break;
                case 3:
                    {
                        Ns = S * 1.10;
                    } break;
                case 4:
                    {
                        Ns = S * 1.05;
                    } break;
                default:
                    {
                        Ns = 0;
                        Console.WriteLine("Categoria no valida");
                    } break;
            }
         //Condicion
            if ( Ns > 5000)
            {
                B = Ns * 0.10;
                Sf = Ns + B;
            }
            else
            {
                B = 0;
                Sf = Ns + B;
            }

        //Imprimir
            Console.WriteLine("Categoria del trabajador es " + cat);
            Console.WriteLine("Sueldo del trabajador es de " + S);
            Console.WriteLine("El nuevo sueldo del trabajador es de " + Ns);
            Console.WriteLine("El bono asignado es de " + B);
            Console.ReadLine();
            
        }
    }
}
