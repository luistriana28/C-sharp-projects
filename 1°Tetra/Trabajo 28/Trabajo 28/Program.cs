using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_28
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int Tm, M;
            double R;

        //Lectura de datos
           Console.WriteLine("Escoge de estos de los tres tipos de madera, que solo son 1, 2 y 3:");
            Tm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantos metros de madera complara:");
            M = Convert.ToInt32(Console.ReadLine());
            
        //Selector
            switch (Tm)
            {
                case 1:
                    {
                        if (M > 30)
                        {
                            R = (M *320) * .96;
                        }
                        else 
                        {
                            R = M * 320;
                        }

                    } break;

                case 2:
                    {
                        if (M > 30)
                        {
                            R = (M *250) * .92;
                        }
                        else 
                        {
                            R = M * 250;
                        }

                    } break;

                case 3:
                    {
                        if (M > 30)
                        {
                            R = (M * 120) * .90;
                        }
                        else 
                        {
                            R = M * 120;
                        }

                    } break;

                default:
                    {
                        R = 0;
                        Console.WriteLine("El numero que usted eligio no es valido.");
                    } break;
            }
            
        //Imprimir
            Console.WriteLine("Su pago seria de " + R + " $");
            Console.ReadLine();

        }
    }
}
