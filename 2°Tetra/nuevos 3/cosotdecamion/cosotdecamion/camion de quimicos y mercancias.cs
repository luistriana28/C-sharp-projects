using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosotdecamion
{
    public class camion_de_quimicos_y_mercancias
    {
        public double camiones(string tipo,double h,double t) 
        {
            double costo=0;
            switch(tipo)
            {
             case "camion de mercancias":
                        {
                          
                            costo = costo + ((h * 50) + (t * 40));
                            

                        } break;
                    case "camion de quimicos":
                        {
                           
                            costo = costo + ((h * 50) + (t * 40));
                           

                        } break;
                    default:
                        {
                            Environment.Exit(0);
                        } break;

            }
             return costo;
                }
               

            }
        }
    