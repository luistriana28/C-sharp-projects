using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bancote
{
    public partial class Form1 : Form
    {
        Bancote Ba = new Bancote();


        public Form1()
        {
            InitializeComponent();
            IniciaBanco();
        }

        public void IniciaBanco()
        {
            Ba.SetNoCuenta(12345);
            Ba.SetNombre("Melgem Facio Reyes");
            Ba.SetSaldo(2000);
            Ba.SetTipoCuentaAhorro(radioButton_Ahorro.Checked = true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usarme... :D La Cuenta del Sistema Bancaria del Bancote.\n\nGOODBYE MI SERVIDOR");
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_Comision.Text = ("");
            txt_Deposito.Text = ("");
            txt_Interes.Text = ("");
            txt_Nocuenta.Text = ("");
            txt_Nombre.Text = ("");
            txt_Retiro.Text = ("");
            txt_Saldo.Text = ("");

            radioButton_Ahorro.Checked = false;
            radioButton_Inversion.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_Ahorro.Checked = false;
            radioButton_Inversion.Checked = false;
        }

        private void bttn_Leer_Click(object sender, EventArgs e)
        {
            int Ccuenta;
            double Ssaldo;
            bool Aahorro;
            Aahorro = Ba.GettipoCuentaAhorro();

            Ccuenta = Ba.GetNoCuenta();
            Ssaldo = Ba.GetSaldo();

            txt_Saldo.Text = ("" + Ssaldo);
            txt_Nocuenta.Text = ("" + Ccuenta);
            txt_Nombre.Text = Ba.GetNombre();
            
            radioButton_Inversion.Checked = !Aahorro;
            radioButton_Ahorro.Checked = Aahorro;
        }

        private void bttn_Registrar_Click(object sender, EventArgs e)
        {
            bool Aahorro;
            Aahorro = radioButton_Ahorro.Checked;
            
            Ba.SetNombre(txt_Nombre.Text);
            
            Ba.SetNoCuenta(int.Parse(txt_Nocuenta.Text));
            Ba.SetSaldo(double.Parse(txt_Saldo.Text));

            Ba.SetTipoCuentaAhorro(!Aahorro);
            Ba.SetTipoCuentaAhorro(Aahorro);
        }

        private void bttn_Obtener_Click(object sender, EventArgs e)
        {
        //Comision
            Ba.SetComision(double.Parse(txt_Saldo.Text));
            Ba.RealizaComision();
            txt_Comision.Text = ("" + Ba.GetComision());

        //Interes
            Ba.SetTipoCuentaAhorro(radioButton_Ahorro.Checked);
            Ba.RealizaInteres();
            txt_Interes.Text = ("" + Ba.GetInteres());
        }

        private void bttn_ObtenerRetiro_Click(object sender, EventArgs e)
        {
            Ba.SetRetiro(double.Parse(txt_Retiro.Text));
            Ba.RealizaRetiro();
            txt_Saldo.Text = ("" + Ba.GetSaldo());
            txt_Retiro.Text = ("");

        }

        private void bttn_Deposito_Click(object sender, EventArgs e)
        {
            Ba.SetDeposito(double.Parse(txt_Deposito.Text));
            Ba.RealizaDeposito();
            txt_Saldo.Text=(""+Ba.GetSaldo());
            txt_Deposito.Text = ("");
        }
    }
}
