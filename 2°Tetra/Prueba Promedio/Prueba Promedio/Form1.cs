using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriaPromed;

namespace Prueba_Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Alumno Al = new Alumno();

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_1Califi.Text = ("");
            Txt_2Califi.Text = ("");
            Txt_3Califi.Text = ("");
            Txt_Direccion.Text = ("");
            Txt_Matricula.Text = ("");
            Txt_Nombre.Text = ("");
            Txt_Promedio.Text = ("");
        }

        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {
            Al.SetNombre(Txt_Nombre.Text);
            Al.SetDireccion(Txt_Direccion.Text);
            Al.SetMatricula(Txt_Matricula.Text);

            Al.SetCalf1(double.Parse(Txt_1Califi.Text));
            Al.SetCalf2(double.Parse(Txt_2Califi.Text));
            Al.SetCalf3(double.Parse(Txt_3Califi.Text));

            Al.SetPromedio(Promed.CalcularProm(double.Parse(Txt_1Califi.Text), double.Parse(Txt_2Califi.Text), double.Parse(Txt_3Califi.Text)));
        }

        private void Bttn_Leer_Click(object sender, EventArgs e)
        {
            Txt_Nombre.Text = ("" + Al.GetNombre());
            Txt_Direccion.Text = ("" + Al.GetDireccion());
            Txt_Matricula.Text = ("" + Al.GetMatricula());

            Txt_1Califi.Text = ("" + Al.GetCalf1());
            Txt_2Califi.Text = ("" + Al.GetCalf2());
            Txt_3Califi.Text = ("" + Al.GetCalf3());
        }

        private void Bttn_Calcular_Click(object sender, EventArgs e)
        {
            Txt_Promedio.Text = ("" + Al.GetPromedio());
        }
    }
}
