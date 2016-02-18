using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplo_switch
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int no;
            double val, v;

        //Lectura de datos
            Console.WriteLine("escribe el valor del numero:");
            no =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe el valor de la variable:");
            v = Convert.ToDouble(Console.ReadLine());

        //Selector
            switch(no)
            {
                case 1:
                    {
                        val=100*v;
                    } break;
                case 2:
                        {
                            val=Math.Pow(100,v);
                        }break;
                case 3:
                        {
                            val=100/v;
                        }break;
                default:
                        {
                            val=0;
                        }break;
            }

        //Imprimir
            Console.WriteLine("el valor de la funcion es "+ val);
            Console.ReadLine();

        }
    }
}
