using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_37
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int i, N=0;
            double Vventa=0, Vventaconhecho=0, Vventamenor=0, Vventagrande=0;

        //Lectura de dato
            Console.WriteLine("Escribe la venta del comprador:");
            N=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

        //Funcion for
            for (i = 1; i <= N; i = i + 1)
            {
                Console.WriteLine("Escribe el valor de la venta:");
                Vventa = Convert.ToDouble(Console.ReadLine());

                if (Vventa < 200)
                {
                    Vventaconhecho = Vventaconhecho + 1;
                }
                else if (Vventa < 400)
                {
                    Vventamenor = Vventamenor + 1;
                }
                else
                {
                    Vventagrande = Vventagrande + 1;
                }
            }

        //Imprimir
            Console.WriteLine("Su proporcion al vender, de su venta con hecho es de " + Vventaconhecho + "." + "\nLa proporcion al vender, de su venta menor es de " + Vventamenor + "." + "\nLa proporcion al vender, de su venta grande es de " + Vventagrande);
            Console.ReadLine();

        }
    }
}
