using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace montoss
{
    public class Class1
    {
        double montoss;
        public double regresa(double monto,double saldoinicial,string acciones)
        {
            switch(acciones)
            {
                case "deposito":
                    {
                        montoss =(saldoinicial + monto);
                    }break;
                case "pago":
                    {
                        montoss =(saldoinicial - monto);
                    } break;
              
            
            }
            return montoss;
        }
    }
}
