using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_Promedio
{
    class Alumno:Persona
    {
        private String Matricula;
        private double Calf1, Calf2, Calf3, Promedio;

    //Setters
        public void SetMatricula(String m)
        {
            Matricula=m;
        }
        public void SetCalf1(double c)
        {
            Calf1 = c;
        }
        public void SetCalf2(double c)
        {
            Calf2 = c;
        }
        public void SetCalf3(double c)
        {
            Calf3 = c;
        }
        public void SetPromedio(double p)
        {
            Promedio = p;
        }

    //Getters
        public double GetCalf1()
        {
            return Calf1;
        }
        public double GetCalf2()
        {
            return Calf2;
        }
        public double GetCalf3()
        {
            return Calf3;
        }
        public String GetMatricula()
        {
            return Matricula;
        }
        public double GetPromedio()
        {
            return Promedio;
        }
    }
}
