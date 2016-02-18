using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace banco_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom, tipo,ncue;
            Console.WriteLine("Nombre del Titular:");
            nom = Console.ReadLine();
            Console.WriteLine("Numero de cuenta:");
            ncue = Console.ReadLine();
            banco trans = new banco(nom,ncue);
            do
            {
                Console.WriteLine("Escoge tu Transaccion" + "\na)Abonar" + "\nb)Retirar" + "\nc)Imprimir Saldo" + "\ne)Salir");
                tipo = Console.ReadLine();
                switch (tipo)
                {
                    case "a":
                        {
                            trans.abonar();
                            Console.WriteLine("---------------------");
                        } break;
                    case "b":
                        {
                            trans.retirar();
                            Console.WriteLine("---------------------");
                        } break;
                    case "c":
                        {
                            trans.print();
                            Console.WriteLine("----------------------");
                        } break;
                }
           
            } while (tipo != "e");
           
        
        }
    }
    class banco
    {
        double cant1=0,cant2=0,r=0;
        string nom, cuent;
        public banco (string x,string y)
        {
            nom = x;
            cuent = y;
        }
        public void abonar()
        {
            Console.WriteLine("Cuanto deseas abonar:");
            cant1 = Convert.ToDouble(Console.ReadLine());
            r = r + cant1;
            Console.WriteLine("ABONO EXITOSO!");
        }
        public void retirar()
        {
            Console.WriteLine("Cuanto Retiras:");
            cant2 = Convert.ToDouble(Console.ReadLine());
            if (cant2 <= r)
            {
                r = r - cant2;
                Console.WriteLine("RETIRO EXITOSO!");
            }
            else
            {
                Console.WriteLine("ERROR SALDO INSUFICIENTE PARA RETIRAR");
            }
            
        }
        public void print()
        {
            Console.WriteLine("Nombre del Titular:" + nom + "\n" + "Cuenta:" + cuent + "\n" + "Saldo:" + r);
        }
    }
}
