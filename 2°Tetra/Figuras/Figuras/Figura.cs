using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Figura
    {
        protected double Area, Perimetro;
        
    //Getters
        public double GetArea()
        {
            return Area;
        }
        public double GetPerimetro()
        {
            return Perimetro;
        }
    }

    class Circulo : Figura
    {
        private double Radio;

    //Setters
        public void SetRadio(double Ra)
        {
            Radio = Ra;
        }

    //Getters
        public double GetRadio()
        {
            return Radio;
        }

    //Metodos
        public void CalcArea()
        {
            Area = 3.14 * Math.Pow(Radio, 2);
        }
        public void CalcPerimetro()
        {
            Perimetro = 3.14 * (Radio * 2);
        }
    }

    class Cuadrado : Figura
    {
        private double Lado;

    //Setters
        public void SetLado(double L)
        {
            Lado = L;
        }

    //Getters
        public double GetLado()
        {
            return Lado;
        }

    //Metodos
        public void CalcArea()
        {
            Area = Lado * Lado;
        }
        public void CalcPerimetro()
        {
            Perimetro = Lado * 4;
        }
    }

    class Triangulo : Figura
    {
        private double Base, Altura;

    //Setters
        public void SetBase(double b)
        {
            Base = b;
        }
        public void SetAltura(double h)
        {
            Altura = h;
        }

    //Getters
        public double GetBase()
        {
            return Base;
        }
        public double GetAltura()
        {
            return Altura;
        }

    //Metodos
        public void CalcArea()
        {
            Area = (Base * Altura) / 2;
        }
        public void CalcPerimetro()
        {
            Perimetro = Base * 3;
        }
    }

    class Rectangulo : Figura
    {
        private double Base, Altura;

    //Setters
        public void SetBase(double b)
        {
            Base = b;
        }
        public void SetAltura(double h)
        {
            Altura = h;
        }

    //Getters
        public double GetBase()
        {
            return Base;
        }
        public double GetAltura()
        {
            return Altura;
        }
 
    //Metodos
        public void CalcArea()
        {
            Area = Base * Altura;
        }
        public void CalcPerimetro()
        {
            Perimetro = (Base * 2) + (Altura * 2);
        }
    }
}
