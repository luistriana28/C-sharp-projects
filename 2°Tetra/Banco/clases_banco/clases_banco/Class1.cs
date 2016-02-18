using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases_banco
{
    public class Class1
    {
        double st;
        public double banco(double saldo, double monto, string tipo)
        {
            
            switch (tipo)
            {
                case "Deposito":
                    {
                        st = saldo + monto;
                    }break;
                case "Pago":
                    {
                        st = saldo - monto;
                    }break;
                
            }
            return st;
        }
    }
}
