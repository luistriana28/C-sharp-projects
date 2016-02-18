using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLIMA
{
    class grados
    {
        public double centigrados(double n)
        {
            return (n-32)/1.8;
        }

        public double farenheit(double n)
        {
            return n*1.8+32;
        }

    }
}
