using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace costolocalidades
{
    public class Class1
    {

        double l1, l2, l3, l4, l5;
        public Class1(double a, double b, double c, double d, double e)
        {
            l1 = a;
            l2 = b;
            l3 = c;
            l4 = d;
            l5 = e;



        }
        public double calcular(string a, double b)
        {
            double resultado = 0;

            switch (a)
            {

                case "1":

                    resultado = l1 * b;


                    break;

                case "2":

                    resultado = l2 * b;
                    break;
                case "3":


                    resultado = l3 * b;
                    break;

                case "4":

                    resultado = l4 * b;

                    break;
                case "5":

                    resultado = l5 * b;
                    break;

            }

            return resultado;


        }

    }
}
