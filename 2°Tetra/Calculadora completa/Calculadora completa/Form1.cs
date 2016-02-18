using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora_completa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        bool newno;
        Calculadora Micalculadora = new Calculadora();

        private void txt_Calcular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_1_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
               
            txt_Calcular.Text = txt_Calcular.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
                       
            txt_Calcular.Text = txt_Calcular.Text + 2;
        }

        private void bttn_0_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }

            txt_Calcular.Text = txt_Calcular.Text + 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 8;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (newno)
            {
                newno = false;
                txt_Calcular.Text = "";

            }
            
            txt_Calcular.Text = txt_Calcular.Text + 9;
        }

        private void bttn_Suma_Click(object sender, EventArgs e)
        {
            newno = true;
            if (Micalculadora.GetopAct() == "")
            {
                Micalculadora.SetX(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopAct("Suma");
            }
            else
            {
                Micalculadora.SetY(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopPent("Suma");
                Micalculadora.Realizaop();
                txt_Calcular.Text = Micalculadora.GetX().ToString();
            }
        }

        private void bttn_Punto_Click(object sender, EventArgs e)
        {
            int X;

            X = txt_Calcular.Text.IndexOf(".");

            if (X == -1)
            {
                txt_Calcular.Text = txt_Calcular.Text + ".";
            }
        }

        private void bttn_Resta_Click(object sender, EventArgs e)
        {
            newno = true;
            if (Micalculadora.GetopAct() == "")
            {
                Micalculadora.SetX(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopAct("Resta");
            }
            else
            {
                Micalculadora.SetY(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopPent("Resta");
                Micalculadora.Realizaop();
                txt_Calcular.Text = Micalculadora.GetX().ToString();
            }
        }

        private void bttn_Multiplicacion_Click(object sender, EventArgs e)
        {
            newno = true;
            if (Micalculadora.GetopAct() == "")
            {
                Micalculadora.SetX(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopAct("Multiplica");
            }
            else
            {
                Micalculadora.SetY(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopPent("Multiplica");
                Micalculadora.Realizaop();
                txt_Calcular.Text = Micalculadora.GetX().ToString();
            }
        }

        private void bttn_Division_Click(object sender, EventArgs e)
        {
            newno = true;
            if (Micalculadora.GetopAct() == "")
            {
                Micalculadora.SetX(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopAct("Divide");
            }
            else
            {
                Micalculadora.SetY(double.Parse(txt_Calcular.Text));
                Micalculadora.SetopPent("Divide");
                Micalculadora.Realizaop();
                txt_Calcular.Text = Micalculadora.GetX().ToString();
            }
        }

        private void bttn_C_Click(object sender, EventArgs e)
        {
            newno = true;
            
            Micalculadora.Limpiar();
                double X, Y;

                X = Micalculadora.GetX();
                Y = Micalculadora.GetY();

                txt_Calcular.Text = ("" + X);
                txt_Calcular.Text = ("" + Y);

        }

        private void bttn_Ce_Click(object sender, EventArgs e)
        {
            newno = true;
            txt_Calcular.Text = "" + 0;            
            
        }

        private void bttn_Igual_Click(object sender, EventArgs e)
        {
            newno = true;
            Micalculadora.SetY(double.Parse(txt_Calcular.Text));
            Micalculadora.GetopAct();
            Micalculadora.Realizaop();
            txt_Calcular.Text = Micalculadora.GetResultado().ToString();

        }

        private void bttn_Masmenos_Click(object sender, EventArgs e)
        {
            double Mame;

            Mame = double.Parse(txt_Calcular.Text);
            Mame = Mame * -1;
            txt_Calcular.Text = Mame.ToString();

        }
    }
}
