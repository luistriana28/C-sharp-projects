using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_41
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int N=0,Vvoto=0, Vvoto1=0, Vvoto2=0,Vvoto3=0,Vvoto4=0;
            double Pporciento1, Pporciento2, Pporciento3, Pporciento4;

        //Funcion while
            while (N <= 0)
            {
                Console.WriteLine("Los que votaran comienzan del 1 al 4, siguiendo ejecutivamente:");
                Vvoto = Convert.ToInt32(Console.ReadLine());

                switch (Vvoto)
                {
                    case 1:
                        {
                            Vvoto1 = Vvoto1 + 1;

                        } break;
                    case 2:
                        {
                            Vvoto2 = Vvoto2 + 1;

                        } break;
                    case 3:
                        {
                            Vvoto3 = Vvoto3 + 1;

                        } break;
                    case 4:
                        {
                            Vvoto4 = Vvoto4 + 1;

                        } break;
                    default:
                        {
                            Console.WriteLine("Este voto no es valido, vuelva a intentarlo.");
                        } break;
                }
                Console.WriteLine("Quieres seguir (0) o deseas terminar (1).");
                N = Convert.ToInt32(Console.ReadLine());

            }

        //Imprimir
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");

                double Total = Vvoto1 + Vvoto2 + Vvoto3 + Vvoto4;

                Pporciento1 = (Vvoto1 * 100) / Total;
                Pporciento2 = (Vvoto2 * 100) / Total;
                Pporciento3 = (Vvoto3 * 100) / Total;
                Pporciento4 = (Vvoto4 * 100) / Total;

                Console.WriteLine("El prociento del 1er voto, es de " + Pporciento1 + " %\nEl porciento del 2do voto, es de " + Pporciento2 + " %\nEl porciento del 3er voto, es de " + Pporciento3 + " %\nEl porcentaje del 4to voto, es de " + Pporciento4 + " %");

            Console.ReadLine();

        }
    }
}
