using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosotdecamion
{
    public class personas
    {
        public double Cpersonas(string tipo,double h) 
        {
            double costo = 0;
            switch (tipo)
            {
                case "camion de personas":
                    {
                        costo = costo + (h * (50 + 20));
                    }break;
            }
            return costo;
        }

    }
}