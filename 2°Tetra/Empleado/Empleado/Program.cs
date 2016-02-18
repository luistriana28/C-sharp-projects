using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empleado
{
    class Program
    {
        static void Main(string[] args)
        {
        //Declaracion de Variable
            Obrero Obr = new Obrero();
            Administrativo Adm = new Administrativo();

            String Swch_Opcion = "";

        //Lectura de Datos

            Console.WriteLine("                  *Bienvenido a Este Lugar que no de Como se Llame*");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Escribe tu nombre raza:");
            Adm.SetNombre(Console.ReadLine());
            Console.WriteLine("Escribe tu numero de Empleado:");
            Adm.SetNoEmpleado(Console.ReadLine());
            Console.WriteLine("Anota tus horas semanal trabajadas al día:");
            Adm.SetHoras(Convert.ToInt16(Console.ReadLine()));
            

            while (Swch_Opcion != "S" && Swch_Opcion != "N")
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("\nTrabajas horas extras, S/N:\n");
                Swch_Opcion = Console.ReadLine();

                switch (Swch_Opcion)
                {
                    case "S":
                        {
                            Console.Write("\nAnota tus horas Extras trabajadas en la semana:\n");
                            Adm.SetHorasExtra(Convert.ToInt16(Console.ReadLine()));
                            
                            
                        }break;

                    case "N":
                        {
                           
                        }break;

                    default:
                        {
                            Console.WriteLine("\nLo siento pero lo que escribio no es valido. Intente de Nuevo, pero esta vez use mayuscula.\n\n¡¡¡De Enter para Continuar!!!");
                            Console.ReadLine();
                            Console.WriteLine("___________________________________");
            
                        }break;
                }
            }

        //Imprimir
            Console.WriteLine("\n\n---------------- Verificación de Datos Administrativo ----------------------------------------------------------------------------------------------------------");
            
            Adm.CalcSueldo();
            Adm.CalcImpuesto();
            Adm.CalcTotal();
            
            Console.WriteLine("Nombre:                 " + Adm.GetNombre());
            Console.WriteLine("No. de Empleado:        " + Adm.GetNoEmpleado());
            Console.WriteLine("Horas Trabajadas:       " + Adm.GetHoras() + " hrs");
            Console.WriteLine("Horas Extras:           " + Adm.GetHorasExtra() + " hrs");
            Console.WriteLine("Sueldo Bruto:           " + Adm.GetSueldoBruto() + " $");
            Console.WriteLine("Impuesto:               " + Adm.GetImpuesto() + " $");
            Console.WriteLine("Sueldo Neto:            " + Adm.GetSueldoNeto() + " $");

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA CONTINUAR!!!");
            Console.ReadLine();
            


        //Lectura de Datos
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                          El Turno del Obrero");
            Console.WriteLine("                  ___________________________________");

            Console.WriteLine("\n\nEscribe tu nombre raza:");
            Obr.SetNombre(Console.ReadLine());
            Console.WriteLine("Escribe tu numero de Empleado:");
            Obr.SetNoEmpleado(Console.ReadLine());
            Console.WriteLine("Anota tus horas semanal trabajadas al día:");
            Obr.SetHoras(Convert.ToInt16(Console.ReadLine()));

            Swch_Opcion = "";

            while (Swch_Opcion != "S" && Swch_Opcion != "N")
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("\nTrabajas horas extras, S/N:\n");
                Swch_Opcion = Console.ReadLine();

                switch (Swch_Opcion)
                {
                    case "S":
                        {
                            Console.Write("\nAnota tus horas Extras trabajadas en la semana:\n");
                            Obr.SetHorasExtra(Convert.ToInt16(Console.ReadLine()));
                        } break;

                    case "N":
                        {
                        } break;

                    default:
                        {
                            Console.WriteLine("\nLo siento pero lo que escribio no es valido. Intente de Nuevo, pero esta vez use mayuscula.\n\n¡¡¡De Enter para Continuar!!!");
                            Console.ReadLine();
                            Console.WriteLine("___________________________________");
                        } break;
                }
            }

            Swch_Opcion = "";

            while (Swch_Opcion != "S" && Swch_Opcion != "N")
            {
                Console.WriteLine("\n\n___________________________________");
                Console.Write("\nTienes puntualidad, S/N:\n");
                Swch_Opcion = Console.ReadLine();

                switch (Swch_Opcion)
                {
                    case "S":
                        {
                            Obr.SetAsistencia(Convert.ToBoolean(true));
                        } break;

                    case "N":
                        {
                            Obr.SetAsistencia(Convert.ToBoolean(false));
                        } break;

                    default:
                        {
                            Console.WriteLine("\nLo siento pero lo que escribio no es valido. Intente de Nuevo, pero esta vez use mayuscula.\n\n¡¡¡De Enter para Continuar!!!");
                            Console.ReadLine();
                            Console.WriteLine("___________________________________");
                        } break;
                }
            }

            Swch_Opcion = "";

            while (Swch_Opcion != "S" && Swch_Opcion != "N")
            {
                Console.WriteLine("\n\n___________________________________");
                Console.Write("\nTienes Todas las asistencias, S/N:\n");
                Swch_Opcion = Console.ReadLine();
                
                switch (Swch_Opcion)
                {
                    case "S":
                        {
                            Obr.SetPuntualidad(Convert.ToBoolean(true));
                        } break;

                    case "N":
                        {
                            Obr.SetPuntualidad(Convert.ToBoolean(false));
                        } break;

                    default:
                        {
                            Console.WriteLine("\nLo siento pero lo que escribio no es valido. Intente de Nuevo, pero esta vez use mayuscula.\n\n¡¡¡De Enter para Continuar!!!");
                            Console.ReadLine();
                            Console.WriteLine("___________________________________");
                        } break;
                }
            }
            
       //Imprimir
            Console.WriteLine("\n\n---------------- Verificación de Datos del Obrero --------------------------------------------------------------------------------------------------------------\n");

            Obr.CalcSueldo();
            Obr.CalcImpuesto();
            Obr.CalcTotal();
            Obr.CalcAsistencia_Puntualidad();

            Console.WriteLine("\nNombre:                 " + Obr.GetNombre());
            Console.WriteLine("No. de Empleado:        " + Obr.GetNoEmpleado());
            Console.WriteLine("Horas Trabajadas:       " + Obr.GetHoras() + " hrs");
            Console.WriteLine("Horas Extras:           " + Obr.GetHorasExtra() + " hrs");
            Console.WriteLine("Sueldo Bruto:           " + Obr.GetSueldoBruto() + " $");
            Console.WriteLine("Impuesto:               " + Obr.GetImpuesto() + " $");
            Console.WriteLine("Sueldo Neto:            " + Obr.GetSueldoNeto() + " $");
            Console.WriteLine("Puntualidad:            " + Obr.GetPuntualidad());
            Console.WriteLine("Asistencia:             " + Obr.GetAsistencia());

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
