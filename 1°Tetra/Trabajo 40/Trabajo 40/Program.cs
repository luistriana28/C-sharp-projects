using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_40
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int Ttotalventa = 0, Ttotalboleto1 = 0, Ttotalboleto2 = 0, Ttotalboleto3 = 0, Ccantidaddeboleto = 0, Vventa, Llocalidad1 = 0, Llocalidad2 = 0, Llocalidad3 = 0, Boleto;
            double N = 0;

            Console.WriteLine("El precio del 1er boleto, es de 1000 $, sabiendo que son los mejores asientos. \nEl precio del 2do boleto, es de 500 $, sabiendo que son asientos regulares. \nEl precio del 3er boleto, es de 250 $, sabiendo que los asientos son absolutamente los peores.");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
        //Funcion While
            while (N <= 0)
            {
                Console.WriteLine("Escriba el tipo de venta, ya sea por 1ra localidad (1), 2da lovalidad (2) y 3ra localidad (3):");
                Vventa = Convert.ToInt32(Console.ReadLine());

                switch (Vventa)
                {
                    case 1:
                        {
                            Llocalidad1 = Llocalidad1 + 1;
                        } break;
                    case 2:
                        {
                            Llocalidad2 = Llocalidad2 + 1;
                        } break;
                    case 3:
                        {
                            Llocalidad3 = Llocalidad3 + 1;
                        } break;
                    default:
                        {
                            Console.WriteLine("La localidad que usted eligio, no es valido. Regrese pronto.");
                            Console.ReadLine();
                        } break;
                }

                Console.WriteLine("Deseas dejar de vender. Dejarlo (1 o más), Seguir (0):");
                N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
            Ttotalboleto1 = Llocalidad1 * 1000;
            Ttotalboleto2 = Llocalidad2 * 500;
            Ttotalboleto3 = Llocalidad3 * 250;

            Ttotalventa = Ttotalboleto1 + Ttotalboleto2 + Ttotalboleto3;
            Ccantidaddeboleto = Llocalidad1 + Llocalidad2 + Llocalidad3;

            Console.WriteLine("");
            Console.WriteLine("Los boletos de la 1ra localidad, se vendio " + Llocalidad1 + " Veces, la venta es de " + Ttotalboleto1 + " $\nLa 2da localidad, se vendio " + Llocalidad2 + " Veces, la venta es de " + Ttotalboleto2 + " $\nLa 3ra localidad, se vendio " + Llocalidad3 + " Veces, la venta es de " + Ttotalboleto3 + " $");
            Console.WriteLine("La cantidad de boletos que se vendio, fueron de " + Ccantidaddeboleto + " veces, y la venta total es de " + Ttotalventa + " $");
            Console.ReadLine();
            
        }
    }
}
