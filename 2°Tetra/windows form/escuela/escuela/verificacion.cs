using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace escuela
{
    class verificacion
    {
        string aceptadoalumno;
        public string calcular(string carrera,int semestre,double promedio)
        {
            switch (carrera)
            {
                case "Economia":
                    {
                        if (semestre >= 6 && promedio >= 8.8)
                        {
                            aceptadoalumno = "aceptado";

                        }
                        else
                        {
                            aceptadoalumno = "rechazado";
                        }

                    }break;
                case "Computacion":
                    {
                        if (semestre >= 6 && promedio >= 8.5)
                        {
                            aceptadoalumno = "aceptado";

                        }
                        else
                        {
                            aceptadoalumno = "rechazado";
                        }

                    } break;
                case "Administracion":
                    {
                        if (semestre >= 5 && promedio >= 8.5)
                        {
                            aceptadoalumno = "aceptado";

                        }
                        else
                        {
                            aceptadoalumno = "rechazado";
                        }

                    } break;
                case "Contabilidad":
                    {
                        if (semestre >= 5 && promedio >= 8)
                        {
                            aceptadoalumno = "aceptado";

                        }
                        else
                        {
                            aceptadoalumno = "rechazado";
                        }

                    } break;
            }
            return aceptadoalumno;
            
        }
    }
}
