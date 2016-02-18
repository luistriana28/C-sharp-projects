using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_2_Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro CAho = new CuentaAhorro();
            CuentaCredito CCre = new CuentaCredito();

            Console.WriteLine("               ¡¡¡EL BANCO DEL BAÑO ME HABLA Y DEL PEND-SATIVO!!!");

            //Declaracion de variable
            String Nnombre;
            int NnoCata;
            double Ddeposito, Rretiro, LlimitCredit, Ccantidad;

            //
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("CUENTA:\n¿Cual es su nombre?");
            Nnombre = Convert.ToString(Console.ReadLine());
            CAho.SetNombre(Nnombre);
            Console.WriteLine("¿Cual es el num de cuenta?");
            NnoCata = Convert.ToInt16(Console.ReadLine());
            CAho.SetNocata(NnoCata);
            Console.WriteLine("¿Cuanto es su Deposito Inicial?");
            Ddeposito = Convert.ToDouble(Console.ReadLine());
            CAho.RealizaDeposito(Ddeposito);
            Console.WriteLine("Cuanto es su retiro:");
            Rretiro = Convert.ToDouble(Console.ReadLine());
            CAho.RealizaRetiro(Rretiro);
            Console.WriteLine("su saldo nuevo es :" + CAho.GetSaldo());

            Console.WriteLine("________________________________________________________");
            Console.WriteLine("¿Cuanto es su Limite de Credito para la Cuenta Credito?");
            LlimitCredit = Convert.ToDouble(Console.ReadLine());
            
            if (LlimitCredit == (LlimitCredit * 1))
            {
                LlimitCredit = LlimitCredit * -1;
            }
            else
            {
                LlimitCredit = LlimitCredit * 1;
            }

            CCre.SetLimitCredit(LlimitCredit);
            Console.WriteLine("Di la Cantidad para su Retiro :");
            Ccantidad = Convert.ToDouble(Console.ReadLine());
            
            CCre.RealizaRetiro(Ccantidad);

            //Imprimir
            Console.WriteLine("\n----------------- Ahorro ---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("* Nombre: " + CAho.GetNombre());
            Console.WriteLine("* Su num Cuenta es: " + CAho.GetNocata());

            Console.WriteLine("\n* Su retiro es: " + CAho.GetRetiro() + " $");
            Console.WriteLine("* Su deposito es: " + CAho.GetDeposito() + " $");
            CCre.CobraInteres();
            Console.WriteLine("\n* De la Cuenta Ahorro el interes es: " + CCre.GetInteres() + " $");

            Console.WriteLine("\n----------------- Credito --------------------------------------------------------------------------------------------------------------------------------------");

            CCre.CobraInteres();
            Console.WriteLine("\n* De la Cuenta Credito, el interes cobrado es: " + CCre.GetInteres() + " $");
            Console.WriteLine("* Su Retiro es: " + CCre.GetRetiro() + " $");

            Console.WriteLine("* Su Saldo es: " + CCre.GetSaldo() + " $");

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
