using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora_completa
{
    class Calculadora
    {
        private double x = 0, y = 0, resultado = 0;
        private String opAct, opPent;

        public Calculadora()
        {
            x = 0.0;
            y = 0.0;
            resultado = 0.0;
            
            opAct = "";
            opPent = "";
        }

            public void SetX(double x)
            {
                this.x = x;
            }
            public void SetY(double y)
            {
                this.y = y;
            }
            public void SetResultado(double re)
            {
                resultado = re;
            }
            public void SetopAct(String act)
            {
                opAct = act;
            }
            public void SetopPent(String pen)
            {
                opPent = pen;
            }


            public double GetX()
            {
                return x;
            }
            public double GetY()
            {
                return y;
            }
            public String GetopAct()
            {
                return opAct;
            }
            public String GetopPen()
            {
                return opPent;
            }
            public double GetResultado()
            {
                return resultado;
            }


            public void Limpiar()
            {
                x = 0;
                y = 0;
            }


            public void Realizaop()
            {
                switch (opAct)
                {
                    case "Suma":
                        {
                            resultado = x + y;
                        } break;
                    case "Resta":
                        {
                            resultado = x - y;
                        } break;
                    case "Multiplica":
                        {
                            resultado = x * y;
                        } break;
                    case "Divide":
                        {
                            resultado = x / y;
                        } break;
                }

                SetX(resultado);
                SetopAct(GetopPen());
                SetopPent("");
            }
    }
}
