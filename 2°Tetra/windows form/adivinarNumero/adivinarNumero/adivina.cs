using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adivinarNumero
{
    class adivina
    {
        public int e = 0;

        public int juego(int n, int naleatorio)
        {



            //while (i < 5)

            //{
            if (n < 100)
            {
               Console.WriteLine ("el numero debe ser menor que 100:"); 

            }
            if (n == naleatorio)
            {

                Console.WriteLine("felicidades haz adivinado el numero");
                e = 1;
                Console.ReadKey();

               

            }
            if (n < naleatorio)
            {
                Console.WriteLine("el numero debe ser mayor:");
            }
            if (n > naleatorio)
            {
              Console.WriteLine(" el numero debe ser menor");
            }
            return e;  
            //Console.WriteLine("terminaron sus intentos");
        }
    
    }
    
}
