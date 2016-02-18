using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fig_Circulo_y_Cilindro
{
    class Cilindro:Circulo
    {
        private double Altura, Volumen;
    
    //Setters
        public void SetAltura(double h)
        {
            Altura = h;
        }
                                                                                                                                                                                                                                   
    //Getters
        public double GetAltura()
        {
            return Altura;
        }
        public double GetVolumen()
        {
            return Volumen;
        }

    //Metodos
        public void CalcVolumen()
        {
            Volumen = Area * Altura;
        }
    }
}
