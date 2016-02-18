using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaGeometria
{
//----- Circulo ---------------------------------------
    public class Circulo
    {
    //Metodos
        public static double CalcArea(double Radio)
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
        public static double CalcPerimetro(double Radio)
        {
            return 2 * Radio * Math.PI;
        }
    }

//----- Cuadrado --------------------------------------
    public class Cuadrado
    {
    //Metodos
        public static double CalcArea(double Lado)
        {
            return Math.Pow(Lado, 2);
        }
        public static double CalcPerimetro(double Lado)
        {
            return Lado * 4;
        }
    }

//----- Cilindro ------------------------------------
    public class Cilindro
    {
        public static double CalcVolumen(double Radio, double Altura)
        {
            double AreaBase = Circulo.CalcArea(Radio);
            return AreaBase * Altura;
        }
    }

//----- Triangulo -----------------------------------
    public class Triangulo
    {
        public static double CalcArea(double Base, double Altura)
        {
            return (Base * Altura) / 2;
        }
        public static double CalcPerimetro(double Base)
        {
            return Base * 3;
        }
    }
//----- Rectangulo ----------------------------------
    public class Rectangulo
    {
        public static double CalcArea(double Base, double Altura)
        {
            return Base * Altura;
        }
        public static double CalcPerimetro(double Base, double Altura)
        {
            return 2 * (Base * Altura);
        }
    }
//----- Esfera -------------------------------------
    public class Esfera
    {
        public static double CalcVolumen(double Radio)
        {
            return (4.0 / 3.0 )*( Math.PI * Math.Pow(Radio, 3));
        }
    }
}
