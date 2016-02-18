using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bancote
{
    class Bancote
    {
        private int NoCuenta;
        private String Nombre;
        private double Saldo;
        private double Retiro;
        private double Deposito;
        private bool TipoCuentaAhorro;
        private double Interes;
        private double Comision;

        //Setters
        public void SetTipoCuentaAhorro(bool A)
        {
            TipoCuentaAhorro = A;
        }
        public void SetNoCuenta(int Nc)
        {
            NoCuenta = Nc;
        }
        public void SetNombre(String No)
        {
            Nombre = No;
        }
        public void SetSaldo(double Sa)
        {
            Saldo = Sa;
        }
        public void SetRetiro(double Re)
        {
            Retiro = Re;
        }
        public void SetDeposito(double De)
        {
            Deposito = De;
        }
        public void SetInteres(double Int)
        {
            Interes = Int;
        }
        public void SetComision(double Com)
        {
            Comision = Com;
        }

        //Getters
        public bool GettipoCuentaAhorro()
        {
            return TipoCuentaAhorro;
        }
        public int GetNoCuenta()
        {
            return NoCuenta;
        }
        public String GetNombre()
        {
            return Nombre;
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
        public double GetComision()
        {
            return Comision;
        }


        //Operacion
        public void RealizaDeposito()
        {
            Saldo = Deposito + Saldo;
        }


        public void RealizaRetiro()
        {
            if (Saldo >= Retiro)
            {
                Saldo = Saldo - Retiro;

            }
            else
            {
                MessageBox.Show("¡¡¡ERROR PUTO!!! El Saldo es insuficiente... Ingrese una cantidad menor a su Saldo.");
            }
        }

        public void RealizaComision()
        {
            if (Saldo < 1000)
            {
                Comision = Saldo * 0.03;
            }
            else
            {
                if (Saldo > 3000)
                {
                    Comision = 0;
                }
                else
                {
                    Comision = Saldo * 0.01;
                }
            }
        }


        public void RealizaInteres()
        {
            if (TipoCuentaAhorro)
                Interes = 0;
            else
                Interes = Saldo * 0.05;
        }
    }
}