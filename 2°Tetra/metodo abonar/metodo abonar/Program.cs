using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodo_abonar
{
    class Program
    {
        public static double abonar(double sal,double ab)
        {
            Console.WriteLine("Cuanto deseas abonar:");
            ab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ABONO EXITOSO!");
            return sal+ab;
          
        }
        public static double retirar(double sal,double ret)
        {
            Console.WriteLine("Cuanto Retiras:");
            ret = Convert.ToDouble(Console.ReadLine());
            if (ret < sal)
            {
                Console.WriteLine("RETIRO EXITOSO!");
            }
            else
            {
                Console.WriteLine("ERROR SALDO INSUFICIENTE PARA RETIRAR");
            }
            return sal-ret;
            
        }
        public static void impr(string x,double y,double z)
        {
            Console.WriteLine("Nombre del Titular:"+ x +"\n"+"Cuenta:"+ y +"\n"+ "Saldo:"+ z);
        }
        static void Main(string[] args)
        {
            double sal = 0, ncue, ab=0,ret=0;
            string nom,tipo;
            Console.WriteLine("Nombre del Titular:");
            nom = Console.ReadLine();
            Console.WriteLine("Numero de cuenta:");
            ncue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escoge tu Transaccion"+"\na)Abonar"+"\nb)Retirar"+"\nc)Imprimir Saldo"+"\ne)Salir");
            tipo=Console.ReadLine();
            while (tipo!="e")
            {
                switch (tipo)
                {
                    case "a":
                        {
                            sal= abonar(sal, ab);
                            Console.WriteLine("---------------------");
                        }break;
                    case "b":
                        {
                            sal=retirar(sal, ret);
                            Console.WriteLine("---------------------");
                        }break;
                    case "c":
                        {
                            impr(nom,ncue,sal);
                            Console.WriteLine("----------------------");
                        }break;
                }
                Console.WriteLine("Escoge tu Transaccion" + "\na)Abonar" + "\nb)Retirar" + "\nc)Imprimir Saldo" + "\ne)Salir");
                tipo = Console.ReadLine();
            }
           
        
        }
    }
}
