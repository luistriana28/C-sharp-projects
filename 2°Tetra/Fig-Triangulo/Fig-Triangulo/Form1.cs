using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fig_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Triangulo Tri = new Triangulo();

        private void bttn_Registrar_Click(object sender, EventArgs e)
        {
            Tri.SetAltura(double.Parse(txt_Altura.Text));
            Tri.SetBase(double.Parse(txt_Base.Text));
        }

        private void bttn_ObtPerimetro_Click(object sender, EventArgs e)
        {
            Tri.CalcPerimetro();
            txt_Perimetro.Text = ("" + Tri.GetPerimetro());
        }

        private void bttn_ObtArea_Click(object sender, EventArgs e)
        {
            Tri.CalcArea();
            txt_Area.Text = ("" + Tri.GetArea());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tri.Limpiar();
            txt_Altura.Text = ("");
            txt_Area.Text = ("");
            txt_Base.Text = ("");
            txt_Perimetro.Text = ("");
        }

        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                ¡¡Gracias por usarme!!\n\nQue tenga un buen Día. Mi cliente   :D");
            Close();
        }
    }
}
