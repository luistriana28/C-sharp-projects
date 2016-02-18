using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen_2_Cuenta
{
    class Cuenta
    {
        protected String Nombre;
        protected int Nocata;
        protected double Saldo, Deposito, Retiro, Interes;


        //Setters
        public void SetNombre(String N)
        {
            Nombre = N;
        }
        public void SetNocata(int N)
        {
            Nocata = N;
        }
        public void SetRetiro(double R)
        {
            Retiro = R;
        }
        public void SetInteres(double i)
        {
            Interes = i;
        }
        public void SetDeposito(double D)
        {
            Deposito = D;
        }

        //Getters
        public String GetNombre()
        {
            return Nombre;
        }
        public int GetNocata()
        {
            return Nocata;
        }
        public double GetSaldo()
        {
            return Saldo;
        }
        public double GetRetiro()
        {
            return Retiro;
        }
        public double GetDeposito()
        {
            return Deposito;
        }
        public double GetInteres()
        {
            return Interes;
        }

        //Metodos
        public void RealizaDeposito(double Cantidad)
        {
            Deposito = Cantidad;
            Saldo = Saldo + Deposito;
        }

        public virtual void RealizaRetiro(double Cantidad)
        {
            if (Saldo >= Cantidad)
            {
                Retiro = Cantidad;
                Saldo = Saldo - Cantidad;
            }
            else
                Console.WriteLine("¡¡¡ERROR PUTO!!! El Saldo es insuficiente... Ingrese una cantidad menor.");
        }
    }

}
