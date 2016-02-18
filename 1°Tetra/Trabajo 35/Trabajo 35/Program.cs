using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_35
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de variable
            int i, Nnumeroempreadomayor=0, Nnumeroempreados=1;
            double Ssueldo, Ssueldomayor=0;

        //Funcion for
            for (i = 1; i <= 50; i = i + 1)
            {
                Console.WriteLine("Empleado " + Nnumeroempreados + ".");
                Console.WriteLine("Escribe el sueldo del empleado:");
                Ssueldo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                if (Ssueldo > Ssueldomayor)
                {
                    Ssueldomayor = Ssueldo;
                    Nnumeroempreadomayor = Nnumeroempreados;
                }
                else
                {

                }

                Nnumeroempreados = Nnumeroempreados + 1;

            }
            Console.WriteLine("El empleado con el sueldo mayor de tu empresa, es el numero " + "´" + Nnumeroempreadomayor + "´" + "." + "\nSu sueldo mayor es de " + Ssueldomayor + " $");
            Console.ReadLine();

        }
    }
}
