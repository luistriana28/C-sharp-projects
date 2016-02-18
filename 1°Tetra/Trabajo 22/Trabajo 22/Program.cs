using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_22
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            double T, C, To;

        //Lectura de datos
            Console.WriteLine("Escribe el tiempo de la llama que tuvo:");
            T = Convert.ToDouble(Console.ReadLine());

        //Condicion
            if (T <= 3)
            {
                Console.WriteLine("Su tiempo de 3 minutos es de 1.20 centavos.");
            }
            else if (T >= 3)
            {
                C = T - 3;
                To = (C * .40) + 1.20;
                Console.WriteLine("su tiempo paso de los 3 minutos, entonces usted debe pagar " + To +" centavos.");
            }
            Console.ReadLine();

        }
    }
}
