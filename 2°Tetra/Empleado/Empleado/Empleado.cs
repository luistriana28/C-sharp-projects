using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empleado
{
    class Empleado
    {
        protected string Nombre, NoEmpleado;
        protected int Horas, HorasExtras;
        protected double SueldoBruto, Impuesto, SueldoNeto, TarifaXHora = 50;

    //Setters
        public void SetNombre(string n)
        {
            Nombre = n;
        }
        public void SetNoEmpleado(string Ne)
        {
            NoEmpleado = Ne;
        }
        public void SetHoras(int hrs)
        {
            Horas = hrs;
        }
        public void SetHorasExtra(int hrse)
        {
            HorasExtras = hrse;
        }

    //Getters
        public string GetNombre()
        {
            return Nombre;
        }
        public string GetNoEmpleado()
        {
            return NoEmpleado;
        }
        public int GetHoras()
        {
            return Horas;
        }
        public int GetHorasExtra()
        {
            return HorasExtras;
        }
        public double GetSueldoBruto()
        {
            return SueldoBruto;
        }
        public double GetImpuesto()
        {
            return Impuesto;
        }
        public double GetSueldoNeto()
        {
            return SueldoNeto;
        }
        public double GetTarifaXHora()
        {
            return TarifaXHora;
        }


    //Metodos
        public void CalcTotal()
        {
            SueldoNeto = SueldoBruto - Impuesto;
        }
    }
}

