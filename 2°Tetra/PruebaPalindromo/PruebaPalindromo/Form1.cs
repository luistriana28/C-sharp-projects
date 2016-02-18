using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibreriadeCaracteres;
namespace PruebaPalindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txt_Escribir.Text = ("");
            Txt_Inversion.Text = ("");
            Txt_SinEspacio.Text = ("");
        }

        private void Bttn_QuitarEspacios_Click(object sender, EventArgs e)
        {
            Txt_SinEspacio.Text = Caracteres.QuitarEspacios(Txt_Escribir.Text);

        }

        private void Bttn_InvertirCadena_Click(object sender, EventArgs e)
        {
            Txt_Inversion.Text = Caracteres.Invertir(Txt_SinEspacio.Text);

            if (Txt_SinEspacio.Text == Txt_Inversion.Text)
            {
                MessageBox.Show("Felicidades has encontrado un Palindromo. Te doy un abrazo :D");
            }
            else
            {
                MessageBox.Show("Pinch... Put... Sigue intentando, Menso.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
