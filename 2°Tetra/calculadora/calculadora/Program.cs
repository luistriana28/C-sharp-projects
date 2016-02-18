using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            int opc;
            Console.WriteLine("Escribe numero:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribe numero:");
            n2 = Convert.ToDouble(Console.ReadLine());
            operacion calcu = new operacion(n1, n2);
            do
            {
                Console.WriteLine("1)Suma" + "\n" + "2)Resta" + "\n" + "3)Multiplicacion" + "\n" + "4)Division" + "\n" + "5)Potencia" + "\n" + "6)Salir");
                opc = Convert.ToInt16(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        {
                            calcu.suma();
                        }break;
                    case 2:
                        {
                            calcu.resta();
                        } break;
                    case 3:
                        {
                            calcu.multi();
                        } break;
                    case 4:
                        {
                            calcu.div();
                        } break;
                    case 5:
                        {
                            calcu.potencia();
                        } break;
                }
                calcu.print();
            } 
            while (opc != 6);
            }
        }
    }
    class operacion
    {
        double n1, n2, r;
        public operacion(double x, double y)
        {
            n1 = x;
            n2 = y;
        }
        public void suma()
        {
            r = n1 + n2;
        }
        public void resta()
        {
            r = n1 - n2;
        }
        public void multi()
        {
            r = n1 * n2;
        }
        public void div()
        {
            r = n1 / n2;
        }
        public void potencia()
        {
            r = Math.Pow(n1, n2);
        }
        public void print()
        {
            Console.WriteLine("Resultado:" + r);
        }
    }