using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_33
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int i, N, Ccontadornegativo = 0, Ssumadepositivo = 0, Ccontadorpositivo = 0, Ccontadornulo = 0, Ppromediopositivo=0;

        //Funcion for
            for (i = 1; i < 50; i = i + 1)
            {
                Console.WriteLine("Escribe el numero que sea:");
                N = Convert.ToInt32(Console.ReadLine());

                if (N > 0)
                {
                    Ccontadorpositivo = Ccontadorpositivo + 1;
                    Ssumadepositivo = Ssumadepositivo + N;
                }
                else if (N < 0)
                {
                    Ccontadornegativo = Ccontadornegativo + 1;
                }
                else
                {
                    Ccontadornulo = Ccontadornulo + 1;
                }
            }

                //Imprimir
                Ppromediopositivo = Ssumadepositivo / Ccontadorpositivo;

                Console.WriteLine("El resultado del Promedio de los positivos es de " + Ppromediopositivo + "." + "\nEl resultado de los numeros negativos es de " + Ccontadornegativo + "." + "\nEl resultado de los numeros nulos es de " + Ccontadornulo + ".");
                Console.ReadLine();
            
        }
    }
}
