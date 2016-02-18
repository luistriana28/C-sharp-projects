using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fig_Circulo
{
    class Circulo
    {
        private double Radio;
        private double Perimetro;
        private double Area;

    //Setters
        public void SetRadio(double R)
        {
            Radio = R;
        }
            


    //Getters
        public double GetRadio()
        {
            return Radio;
        }
        public double GetPerimetro()
        {
            return Perimetro;
        }
        public double GetArea()
        {
            return Area;
        }



    //Probremas
        public void Limpiar()
        {
            Perimetro = 0;
            Area = 0;
            Radio = 0;
        }

        public void CalcPerimetro()
        {
            Perimetro = 2 * Radio * 3.14;
        }

        public void CalcArea()
        {
            Area = 3.14 * Math.Pow(Radio, 2);
        }
    }
}
