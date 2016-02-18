using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Super_Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Total_Click(object sender, EventArgs e)
        {
            try
            {
                double Pprecio, Ootro, Iiva, Ttotal;

                Pprecio = Convert.ToDouble(textBox_Articulo.Text);

                if (Pprecio < 300)
                {
                    Ootro = Pprecio * .05;
                    textBox_Descuento.Text = ("5 %  " + Ootro);

                }
                else
                {
                    Ootro = Pprecio * .10;
                    textBox_Descuento.Text = ("10 %  " + Ootro);

                }

                Iiva = Pprecio * .16;
                textBox_Iva.Text = ("16 %  " + Iiva);

                Ttotal = Pprecio + Iiva - Ootro;

                textBox_Total.Text = ("Total " + Ttotal + " $");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. NO se puede utilizar letras, eres tonto oh ¡¡¡QUE!!!");

            }
        }
        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button_Borrar_Click(object sender, EventArgs e)
        {
            textBox_Articulo.Text = ("");
            textBox_Descuento.Text = ("");
            textBox_Iva.Text = ("");
            textBox_Total.Text = ("");

        }
    }
}
