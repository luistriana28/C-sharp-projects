using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fig_Triangulo
{
    class Triangulo
    {
        private double Altura;
        private double Base;
        private double Perimetro;
        private double Area;

    //Setters
        public void SetAltura(double h)
        {
            Altura = h;
        }
        public void SetBase(double b)
        {
            Base = b;
        }
        


    //Getters
        public double GetAltura()
        {
            return Altura;
        }
        public double GetBase()
        {
            return Base;
        }
        public double GetPerimetro()
        {
            return Perimetro;
        }
        public double GetArea()
        {
            return Area;
        }



    //Operacion
        public void Limpiar()
        {
            Perimetro = 0;
            Area = 0;
            Base = 0;
            Altura = 0;
        }
        
        public void CalcPerimetro()
        {
            Perimetro = Base + Base + Base;
        }
        
        public void CalcArea()
        {
            Area = (Base * Altura) / 2;
        }
    }
}
