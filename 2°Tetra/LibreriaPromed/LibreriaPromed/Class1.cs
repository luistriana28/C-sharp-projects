using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaPromed
{
    public class Promed
    {
        public static double CalcularProm(double N1, double N2, double N3)
        {
            double Rrespuesta;
            Rrespuesta = (N1 + N2 + N3) / 3.0;
            
            return Rrespuesta;
        }
    }
}
