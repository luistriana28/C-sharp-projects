using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double Ccostodelarticulo, Ddineroelectronico = 0;
            int Ttipodearticulo, Fformadepago;

        //Lectura de datos
            Console.WriteLine("Escribe el tipo de arituco, del 1 al 4:");
            Ttipodearticulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual es la forma de pago que quiere hacer (Que Contado es (1), y Credito es (2):");
            Fformadepago = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte el costo del articulo:");
            Ccostodelarticulo = Convert.ToInt32(Console.ReadLine());

        //Switch
            if (Ccostodelarticulo>1000)
            {
                switch(Ttipodearticulo)
            {
                case 1:
                    {
                       switch (Fformadepago)
                       {
                           case 1:
                               {
                                   Ddineroelectronico = Ccostodelarticulo * .05;
                               }break;
                           case 2:
                               {
                                   Ddineroelectronico = Ccostodelarticulo * .07;
                               }break;
                           default:
                               {
                                   Console.WriteLine("La forma de paga no es valido. Entonces.");
                               }break;
                       }
                    } break;
                case 2:
                    {
                       switch (Fformadepago)
                       {
                           case 1:
                               {
                                   Ddineroelectronico = Ccostodelarticulo * .08;
                               }break;
                           case 2:
                               {
                                   Ddineroelectronico = Ccostodelarticulo * .10;
                               }break;
                           default:
                               {
                                   Console.WriteLine("La forma de paga no es valido. Entonces.");
                               } break;
                       }
                     } break;
                case 3:
                    {
                        switch (Fformadepago)
                        {
                            case 1:
                                {
                                    Ddineroelectronico = Ccostodelarticulo * .12;
                                } break;
                            case 2:
                                {
                                    Ddineroelectronico = Ccostodelarticulo * .15;
                                } break;
                            default:
                                {
                                    Console.WriteLine("La forma de paga no es valido. Entonces.");
                                } break;
                        }
                    } break;
                case 4:
                    {
                        switch (Fformadepago)
                        {
                            case 1:
                                {
                                    Ddineroelectronico = Ccostodelarticulo * .20;
                                } break;
                            case 2:
                                {
                                    Ddineroelectronico = Ccostodelarticulo * .20;
                                } break;
                            default:
                                {
                                    Console.WriteLine("La forma de paga no es valido. Entonces.");
                                } break;
                        }
                    } break;
                default:
                    {
                        Console.WriteLine("El tipo de articulo que usted eligio no es valido");
                    } break;

            }
            }
               else
                {
                 Console.WriteLine("Lo sentimos, no tiene derecho a su dinero electronico");

                }

        //Imprimir
            Console.WriteLine("Su dinero electronico es de " + Ddineroelectronico + " $" + "\nGracias por usarme");
            Console.ReadLine();

        }
    }
}
