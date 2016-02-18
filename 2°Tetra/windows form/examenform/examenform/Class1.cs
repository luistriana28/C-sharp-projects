using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenform
{
    class Class1
    {
        double CostoTArticulo;



        public double Costofinal(string formadepago, double costoArticulo, string tipo)
        {

            {
                switch (tipo)
                {
                    case "A":
                        {
                            if (formadepago == "Credito" )
                            {
                                CostoTArticulo = costoArticulo * .04;
                            }
                            else
                            {
                                CostoTArticulo = costoArticulo * .05;
                            }
                        } break;
                    case "B":
                        {
                            if (formadepago == "Credito")
                            {
                                CostoTArticulo = costoArticulo * .06;
                            }
                            else
                            {

                                CostoTArticulo = costoArticulo * .07;
                            }

                        } break;
                    case "C":
                        {
                            if (formadepago == "Credito")
                            {

                                CostoTArticulo = costoArticulo * .08;
                            }
                            else
                            {
                                CostoTArticulo = costoArticulo * .10;
                            }
                        } break;
                    case "D":
                        {
                            if (formadepago == "Credito")
                            {
                                CostoTArticulo = costoArticulo * .10;
                            }
                            else
                            {
                                CostoTArticulo = costoArticulo * .12;
                            }
                        } break;
                }
            }



            return CostoTArticulo;


        }
    }
}

