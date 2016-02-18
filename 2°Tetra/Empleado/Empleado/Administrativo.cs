using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empleado
{
    class Administrativo:Empleado
    {
    //Metodos
        public void CalcSueldo()
        {
            SueldoBruto = (Horas + (HorasExtras * 2)) * TarifaXHora;
        }

        public void CalcImpuesto()
        {
            Impuesto = SueldoBruto * .10;
        }
    }
}
