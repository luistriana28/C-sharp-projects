using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_38
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int Eentrada=0, Ttipodefuncion, Ffunciontarde=0, Ffuncionnoche=0, Ffunciontrasnoche=0;
            double R = 0, Ffuncion1 = 0, Ffuncion2 = 0, Ffuncion3 = 0, Bboleto1 = 0, Bboleto2 = 0, Bboleto3 = 0;

        //Funcion While
            while (Eentrada <= 0)
            {
                Console.WriteLine("Escribe la funcion la cual entrar, sabiendo que las funciones son de tarde (1), noche (2) y trasnoche (3):");
                Ttipodefuncion = Convert.ToInt32(Console.ReadLine());

                switch (Ttipodefuncion)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("Cuantos boletos deseas vender en la funcion de la tarde:");
                            Bboleto1 = Convert.ToDouble(Console.ReadLine());
                            
                        } break;

                    case 2:
                        {
                            Ffuncionnoche = Ffuncionnoche + 1;
                            Console.WriteLine("Cuantos boleto deseas vender en la funcion de la noche:");
                            Bboleto2 = Convert.ToDouble(Console.ReadLine());

                        } break;

                    case 3:
                        {
                            Ffunciontrasnoche = Ffunciontrasnoche + 1;
                            Console.WriteLine("Cuantos boletos deseas vender en la funcion de la noche:");
                            Bboleto3 = Convert.ToDouble(Console.ReadLine());

                        } break;
                    default:
                        {
                            Console.WriteLine("La funcion que usted desea entrar no existe, es mejor que vea el horario y no pregunte.");

                        } break;
                }

                Console.WriteLine("Si quieres seguir vendiendo (0), pero si quieres terminar (1):");
                Eentrada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

            }
            
        //Proceso
            Ffuncion1 = Bboleto1 * 100;
            Ffuncion2 = Bboleto2 * 100;
            Ffuncion3 = Bboleto3 * 100;

            R = Ffuncion1 + Ffuncion2 + Ffuncion3;

        //Imprimir
            Console.WriteLine("");
            Console.WriteLine("Las funciones que se vendieron del día (s), fueron: Tarde, " + Bboleto1 + " veces, la Noche, " + Bboleto2 + " veces, y la Trasnoche " + Bboleto3 + " veces.");
            Console.WriteLine("El costo de las funciones del dia es de " + R + " $" + ". Gracias por venir.");
            Console.ReadLine();
            
        }
    }
}
