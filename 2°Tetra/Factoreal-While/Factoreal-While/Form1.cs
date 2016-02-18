using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factoreal_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            textBox_No.Text = ("");
            textBox_Resultado.Text = ("");

        }

        private void button_Factorizar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0, No, Rresultado = 1;
                
                No = Convert.ToInt16(textBox_No.Text);

                while (No > 1)
                {
                    i = No;

                    Rresultado = Rresultado * i;

                    No = No - 1;

                }
                
                textBox_Resultado.Text = ("Es: " + Rresultado);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. ¡¡¡ESTUPIDO BASTARDO!!! ¡¡¡SOLO LETRA PUTO!!!");

            }
        }
    }
}
