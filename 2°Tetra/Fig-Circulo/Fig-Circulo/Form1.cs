using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fig_Circulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Circulo Ci = new Circulo();

        private void bttn_Registrar_Click(object sender, EventArgs e)
        {
            Ci.SetRadio(double.Parse(txt_Radio.Text));
        }

        private void bttn_ObtPerimetro_Click(object sender, EventArgs e)
        {
            Ci.CalcPerimetro();
            txt_Perimetro.Text = ("" + Ci.GetPerimetro());
        }

        private void bttn_ObtArea_Click(object sender, EventArgs e)
        {
            Ci.CalcArea();
            txt_Area.Text = ("" + Ci.GetArea());
        }

        private void bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Ci.Limpiar();
            txt_Area.Text = ("");
            txt_Perimetro.Text = ("");
            txt_Radio.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("               ¡Gracias por visitarme!\n\nGoodBye Mi Cliente   :D");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
