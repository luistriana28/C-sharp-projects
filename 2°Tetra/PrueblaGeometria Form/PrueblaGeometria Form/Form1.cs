using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaGeometria;

namespace PrueblaGeometria_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Text_FormulaCilindro.Text = ("");
            Text_FormulaCirculo.Text = ("");
            Text_FormulaCuadrado.Text = ("");
            Text_FormulaEsfera.Text = ("");

            Text_NAlturaCilindro.Text = ("");
            Text_NCirculo.Text = ("");
            Text_NCuadrado.Text = ("");
            Text_NEsfera.Text = ("");
            Text_NRadioCilindro.Text = ("");
        }

        private void Bttn_AreaCiculo_Click(object sender, EventArgs e)
        {
            Text_FormulaCirculo.Text = ("" + Circulo.CalcArea(double.Parse(Text_NCirculo.Text)));
        }

        private void Bttn_PerimetroCirculo_Click(object sender, EventArgs e)
        {
            Text_FormulaCirculo.Text = ("" + Circulo.CalcPerimetro(double.Parse(Text_NCirculo.Text)));
        }

        private void Bttn_AreaCuadrado_Click(object sender, EventArgs e)
        {
            Text_FormulaCuadrado.Text = ("" + Cuadrado.CalcArea(double.Parse(Text_NCuadrado.Text)));
        }

        private void Bttn_PerimetroCuadrado_Click(object sender, EventArgs e)
        {
            Text_FormulaCuadrado.Text = ("" + Cuadrado.CalcPerimetro(double.Parse(Text_NCuadrado.Text)));
        }

        private void Bttn_VolumenEsfera_Click(object sender, EventArgs e)
        {
            Text_FormulaEsfera.Text = ("" + Esfera.CalcVolumen(double.Parse(Text_NEsfera.Text)));
        }

        private void Bttn_VolumenCilindro_Click(object sender, EventArgs e)
        {
            Text_FormulaCilindro.Text = ("" + Cilindro.CalcVolumen(double.Parse(Text_NRadioCilindro.Text), double.Parse(Text_NAlturaCilindro.Text)));
        }
    }
}
