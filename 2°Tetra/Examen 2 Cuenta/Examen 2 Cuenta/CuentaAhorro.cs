using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_2_Cuenta
{
    class CuentaAhorro:Cuenta
    {
    //Metodo
        public void GeneraInteres()
        {
            Interes = Saldo * .05;
            Saldo = Saldo * 0.05;
        }
    }
}
