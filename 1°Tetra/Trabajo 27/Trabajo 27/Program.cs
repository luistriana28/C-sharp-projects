using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_27
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double Ct, Ca, D;
            int Te, E;

        //Lectura de datos
            Console.WriteLine("Mencione el tipo de enfermdad, del 1 al 4, que este registrado en la lista:");
            Te = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mencione cuantos enfermos ahí en el hospital:");
            E = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe los dias del pasiente (es):");
            D = Convert.ToDouble(Console.ReadLine());

        //Selector
            switch (Te)
            {
                case 1:
                    {
                        Ct = D * 2500;
                    } break;
                case 2:
                    {
                        Ct = D * 1600;
                    } break;
                case 3:
                    {
                        Ct = D * 2000;
                    } break;
                case 4:
                    {
                        Ct = D * 3200;
                    } break;
                default:
                    {
                        Ct = 0;
                        Console.WriteLine("Costo total no es valido. Vuelva a intentar.");
                    } break;
            }

        //Condicion
            if (E > 14)
            {
                Ca = Ct * 1.10;
                Console.WriteLine("El costo adicional es de " + Ca +" $");
            }
            else if (E < 22)
            {
                Console.WriteLine("El costo total es de " + Ct +" $");
            }

        //Imprimir
            Console.ReadLine();

        }
    }
}
