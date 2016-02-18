using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

namespace suledo
{
    class CALCULAR
    {
        double sueldofinal;
        public double calcular(double sueldo, int categoria, double horasextra)
        {
            
            switch (categoria)
            {
                case 1:
                    {
                        if (horasextra > 30)
                        {
                            sueldofinal = sueldo + 30 * 30;
                           
                        }
                        else
                           {
                            sueldofinal = sueldo + horasextra * 30;
                            

                            }


                    }break;

                case 2:
                    {
                        if (horasextra > 30)
                        {
                            sueldofinal = sueldo + 30 *50 ;

                        }
                        else
                        {
                            sueldofinal = sueldo + horasextra * 50;


                        }


                    } break;
                case 3:
                    {
                        if (horasextra > 30)
                        {
                            sueldofinal = sueldo + 30 * 100;

                        }
                        else
                        {
                            sueldofinal = sueldo + horasextra * 100;


                        }


                    } break;
                case 4:
                    {
                        if (horasextra > 30)
                        {
                            sueldofinal = sueldo + 30 * 120;

                        }
                        else
                        {
                            sueldofinal = sueldo + horasextra * 120;


                        }


                    } break;

                   

            }
            return sueldofinal;

        }

    }
}
