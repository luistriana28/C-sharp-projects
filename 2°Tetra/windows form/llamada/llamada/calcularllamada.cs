using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace llamada
{
    class calcularllamada
    {
       public double costototal;
      
        public double llamada(int ELIGEZONA, int minutos)
        {

            switch (ELIGEZONA)
            {
                case 1:
                    {
                        costototal = (minutos * 2);
                        
                       

                    } break;
                case 2:
                    {
                        costototal = (minutos * 2.2);
                        
                    } break;
                case 3:
                    {
                        costototal = (minutos * 4.5);
                        

                    } break;
                case 4:
                    {
                        costototal = (minutos * 3.5);
                        
                    } break;
                case 5:
                    {
                        costototal = (minutos * 6);
                       
                    } break;
                case 6:
                    {
                        costototal = (minutos * 6);
                       
                    } break;
                case 7:
                    {
                        costototal = (minutos * 5);
                        
                    } break;
            }
            return costototal;
           
          
            }
        }
    }


