using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_2_Cuenta
{
    class CuentaCredito:Cuenta
    {
        private double LimitCredit;

    //Setters
        public void SetLimitCredit(double Lc)
        {
            LimitCredit = Lc;
        }

    //Getters
        public double GetLimitCredit()
        {
            return LimitCredit;
        }


    //Metodos
        public override void RealizaRetiro(double Cantidad)
        {
            if ((Saldo - Cantidad) >= LimitCredit)
            {
                Retiro = Cantidad;
                Saldo = Saldo - Cantidad;
            }
            else
                Console.WriteLine("¡¡¡ERROR PUTO!!! El Limite de Credito es insuficiente... Ingrese una cantidad menor.");
        }

        public void CobraInteres()
        {
            Interes = (Saldo * 0.010);
            Saldo = Saldo + (Saldo * 0.010);
        }
    }
}
