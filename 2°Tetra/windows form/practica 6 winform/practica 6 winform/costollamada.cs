using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_6_winform
{
    class costollamada
    {
        double costofinal;

        public double llamada(int minutoss, int zonaa)
        {
            switch (zonaa)
            {

                case 1:
                    {

                        costofinal = minutoss * 2;
                    
                    
                    }break;

                case 2:
                    {
                        costofinal = minutoss * 2.2;
                    
                    }break;

                case 3:
                    {
                        costofinal = minutoss * 4.5;
                    
                    }break;

                case 4:
                    {
                        costofinal = minutoss * 3.5;
                    
                    
                    }break;

                case 5:
                    {
                        costofinal = minutoss * 6;
                    
                    }break;

                case 6:
                    {
                        costofinal = minutoss * 6;
                    
                    
                    } break;

                case 7:
                    {
                        costofinal = minutoss * 5;
                    
                    
                    }break;
            
            
            }

            return costofinal;
        }
    }
}
