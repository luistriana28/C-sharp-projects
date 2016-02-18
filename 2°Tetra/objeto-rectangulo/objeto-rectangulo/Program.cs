using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objeto_rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            rectangulo rec = new rectangulo();
            rec.largo();
            rec.ancho();
            rec.perimetro();
            rec.area();
            rec.print();
            Console.ReadKey();
        }
    }
    class rectangulo
    {
        double lad, anc,per,ar;
      
        public void largo()
        {
            Console.WriteLine("Valor del largo:");
            lad = Convert.ToDouble(Console.ReadLine());
        }
        public void ancho()
        {
            Console.WriteLine("Valor del ancho:");
            anc = Convert.ToDouble(Console.ReadLine());
        }
        public void perimetro()
        {
            if (lad > 0 & lad < 20 && anc > 0 & anc < 20)
            {
                per = ((2 * lad) + (2 * anc));
            }
            
        }
        public void area()
        {
            if (lad > 0 & lad < 20 && anc>0 & anc<20)
            {
                ar = lad * anc;
            }
        }
        public void print()
        {
            if (lad > 0 & lad < 20 && anc > 0 & anc < 20)
            {
                Console.WriteLine("Perimetro Total:" + per);
                Console.WriteLine("Area Total:" + ar);
                Console.WriteLine("FELICIDADES este es tu resultado");
            }
            else
            {
                Console.WriteLine("ERROR" +"\n"+"Los atributos deben estar entre 0 y 20");
            }
        }
    }
}
