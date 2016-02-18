using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hospital
{
    class calcular
    {
         double resultado,aumento;
        
        public double calcularlo(int dias,string costo,int edad)
        {
            switch (costo)
            {
                case "A":
                    {

                        if (edad >= 18 && edad <= 40)
                        {

                            aumento = (dias * 600) * .10;
                            resultado = dias * 600 + aumento;
                        }
                        else
                        {
                            
                            resultado = dias * 600;
                        }

                }break;
                case "B":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            aumento = (dias * 800) * .10;
                            resultado = dias * 800 + aumento;
                            
                        }
                        else
                        {

                            resultado = dias * 800;
                        }

                    } break;
                case "C":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            aumento = (dias * 1000) * .10;
                            resultado = dias * 1000 + aumento;
                            
                        }
                        else
                        {
                           
                            resultado = dias * 1000 ;
                        }

                    } break;
                case "D":
                    {

                        if (edad >= 18 && edad <= 40)
                        {
                            aumento = (dias * 1000) * .10;
                            resultado = dias * 1000 + aumento;
                        }
                        else
                        {
                            
                            resultado = dias * 1200 ;
                        }

                    } break;
            }
            return resultado;
            
        }

    }
}

    

