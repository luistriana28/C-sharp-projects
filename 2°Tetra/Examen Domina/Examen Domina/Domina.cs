using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_Domina
{
    class Domina
    {
        private String Nombre, Domicilio, TipodeEmpleado;
        private double SueldoNeto, SueldoBruto, ISR;
        private int Telefono, Horas, HorasEx = 0;

    //Setters
        public void SetNombre(String Name)
        {
            Nombre = Name;
        }
        public void SetDomicilio(String Domi)
        {
            Domicilio = Domi;
        }
        public void SetTelefono(int Tel)
        {
            Telefono = Tel;
        }
        public void SetTipodeEmpleado(String TE)
        {
            TipodeEmpleado = TE;
        }
        public void SetHoras(int Hr)
        {
            Horas = Hr;
        }
        public void SetHorasEx(int Ex)
        {
            HorasEx = Ex;
        }



    //Getters
        public double GetSueldoNeto()
        {
            return SueldoNeto;
        }
        public String GetNombre()
        {
            return Nombre;
        }
        public String GetDomicilio()
        {
            return Domicilio;
        }
        public int GetTelefono()
        {
            return Telefono;
        }
        public int GetHoras()
        {
            return Horas;
        }
        public double GetISR()
        {
            return ISR;
        }
        public double GetSueldoBruto()
        {
            return SueldoBruto;
        }
        public int GetHorasEx()
        {
            return HorasEx;
        }
        public String GetTipodeEmpleado()
        {
            return TipodeEmpleado;
        }

    //Operacion
        public void calculaISR()
        {
            if (SueldoBruto < 1000)
            {
                ISR = SueldoBruto * .05;
            }
            else if (SueldoBruto > 2000)
            {
                ISR = SueldoBruto * .12;
            }
            else
            {
                ISR = SueldoBruto * .08;
            }
        }


        public void calculasueldoneto()
        {
            SueldoNeto = SueldoBruto - ISR;
        }


        public void calculasueldobruto()
        {
            switch (TipodeEmpleado)
            {
                case "Obrero":
                    {
                        SueldoBruto = (Horas * 20) + (HorasEx * 20) * 2;
                    } break;
                case "Supervisor":
                    {
                        SueldoBruto = (Horas * 30) + (HorasEx * 30) * 2;
                    } break;

                case "Administrativo":
                    {
                        SueldoBruto = (Horas * 45) + (HorasEx * 45) * 2;
                    } break;
            }
        }
    
    
    }
}
