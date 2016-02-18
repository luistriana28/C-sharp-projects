using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hospital
{
    class CALCULAR
    {
        double resultado;
        
        public double calcular(int dias,string costo,int edad)
        {
            switch (costo)
            {
                case "a":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            resultado = dias * 600;
                        }
                        else
                        {
                            resultado = (dias * 600)+(dias *0.10);
                        }

                }break;
                case "b":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            resultado = dias * 800;
                        }
                        else
                        {
                            resultado = (dias * 800) + (dias * 0.10);
                        }

                    } break;
                case "c":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            resultado = dias * 1000;
                        }
                        else
                        {
                            resultado = (dias * 1000) + (dias * 0.10);
                        }

                    } break;
                case "d":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            resultado = dias * 1200;
                        }
                        else
                        {
                            resultado = (dias * 1200) + (dias * 0.10);
                        }

                    } break;
            }
            return resultado;
            
        }

    }
}
