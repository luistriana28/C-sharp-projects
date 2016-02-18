using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fig_Circulo_y_Cilindro
{
    class Circulo
    {
        protected double Radio, Area;

     //Setters
        public void SetRadio(double r)
        {
            Radio = r;
        }

    //Getters
        public double GetRadio()
        {
            return Radio;
        }
        public double GetArea()
        {
            return Area;
        }

    //Metodos
        public void CalcArea()
        {
            Area = 3.14 * Math.Pow(Radio, 2);
        }
    }
}
