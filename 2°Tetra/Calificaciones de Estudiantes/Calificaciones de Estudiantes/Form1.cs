using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calificaciones_de_Estudiantes
{
    public partial class Form1 : Form
    {
        Calificacion Cal = new Calificacion();

        public Form1()
        {
            InitializeComponent();
            IniciaCali();
        }

        public void IniciaCali()
        {
            Cal.SetNombre("Melgem");
            Cal.SetMatricula(1330519);
            Cal.SetMateria1("Programación");
            Cal.SetMateria2("Desarrollo");
            Cal.SetMateria3("Redes");
            Cal.SetCalificacion1(10);
            Cal.SetCalificacion2(9);
            Cal.SetCalificacion3(10);

        }

        public class Calificacion
        {
            private String Nombre;
            private int Matricula;
            private String Materia1;
            private String Materia2;
            private String Materia3;
            private double Calificacion1;
            private double Calificacion2;
            private double Calificacion3;
            private double promedio;


            public void SetNombre(String n)
            {
                Nombre = n;
            }
            public void SetMatricula(int m)
            {
                Matricula = m;
            }
            public void SetMateria1(String mt1)
            {
                Materia1 = mt1;
            }
            public void SetMateria2(String mt2)
            {
                Materia2 = mt2;
            }
            public void SetMateria3(String mt3)
            {
                Materia3 = mt3;
            }
            public void SetCalificacion1(double Ca1)
            {
                Calificacion1 = Ca1;
            }
            public void SetCalificacion2(double Ca2)
            {
                Calificacion2 = Ca2;
            }
            public void SetCalificacion3(double Ca3)
            {
                Calificacion3 = Ca3;
            }
            public void SetPromedio(double Pr)
            {
                promedio = Pr;
            }




            public String GetNombre()
            {
                return Nombre;
            }
            public int GetMatricula()
            {
                return Matricula;
            }
            public String GetMateria1()
            {
                return Materia1;
            }
            public String GetMateria2()
            {
                return Materia2;
            }
            public String GetMateria3()
            {
                return Materia3;
            }
            public double GetCalificacion1()
            {
                return Calificacion1;
            }
            public double GetCalificacion2()
            {
                return Calificacion2;
            }
            public double GetCalificacion3()
            {
                return Calificacion3;
            }
            public double Promedio()
            {
                return promedio;
            }


            public double CalcularPromedio()
            {
                double Ppromedio;
                Ppromedio = (Calificacion1 + Calificacion2 + Calificacion3) / 3;
                return Ppromedio;
            }
        }


        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_1Cal.Text = ("");
            txt_1Mat.Text = ("");
            txt_2Cal.Text = ("");
            txt_2Mat.Text = ("");
            txt_3Cal.Text = ("");
            txt_3Mat.Text = ("");
            txt_Matricula.Text = ("");
            txt_Nombre.Text = ("");
            txt_Promedio.Text = ("");
        }

        private void bttn_Leer_Click(object sender, EventArgs e)
        {
            int Mmatricula;
            double Ccal1, Ccal2, Ccal3;

            Mmatricula = Cal.GetMatricula();
            Ccal1 = Cal.GetCalificacion1();
            Ccal2 = Cal.GetCalificacion2();
            Ccal3 = Cal.GetCalificacion3();

            txt_Nombre.Text = Cal.GetNombre();
            txt_1Mat.Text = Cal.GetMateria1();
            txt_2Mat.Text = Cal.GetMateria2();
            txt_3Mat.Text = Cal.GetMateria3();
            txt_Matricula.Text = ("" + Mmatricula);
            txt_1Cal.Text = ("" + Ccal1);
            txt_2Cal.Text = ("" + Ccal2);
            txt_3Cal.Text = ("" + Ccal3);

        }

        private void bttn_Registrar_Click(object sender, EventArgs e)
        {
            Cal.SetNombre(txt_Nombre.Text);
            Cal.SetMateria1(txt_1Mat.Text);
            Cal.SetMateria2(txt_2Mat.Text);
            Cal.SetMateria3(txt_3Mat.Text);

            Cal.SetMatricula(int.Parse(txt_Matricula.Text));
            Cal.SetCalificacion1(double.Parse(txt_1Cal.Text));
            Cal.SetCalificacion2(double.Parse(txt_2Cal.Text));
            Cal.SetCalificacion3(double.Parse(txt_3Cal.Text));
        }

        private void bttn_Calcular_Click(object sender, EventArgs e)
        {
            double Ppromedio;

            Ppromedio = Cal.CalcularPromedio();

            txt_Promedio.Text = ("" + Ppromedio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
