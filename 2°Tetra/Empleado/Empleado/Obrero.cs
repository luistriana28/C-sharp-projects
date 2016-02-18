using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empleado
{
    class Obrero:Empleado
    {
        private bool Puntualidad, Asistencia;
        
    //Setters
        public void SetAsistencia(bool As)
        {
            Asistencia = As;
        }
        public void SetPuntualidad(bool P)
        {
            Puntualidad = P;
        }

    //Getters
        public bool GetAsistencia()
        {
            return Asistencia;
        }
        public bool GetPuntualidad()
        {
            return Puntualidad;
        }

    //Metodos
        public void CalcSueldo()
        {
            SueldoBruto = (Horas + (HorasExtras * 2)) * TarifaXHora;
        }

        public void CalcImpuesto()
        {
            Impuesto = SueldoBruto * .05;
        }

        public void CalcAsistencia_Puntualidad()
        {
            if (Asistencia == true && Puntualidad == true)
                SueldoNeto = (SueldoBruto * 1.20) - Impuesto;
            else
            {
                Console.WriteLine("¡¡Hahaha!! Eres Un tonto no te daremos nada.");
            }
        }
    }
}
