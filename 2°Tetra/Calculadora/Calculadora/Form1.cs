using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("");
            textBox2.Text = ("");
            textBox3.Text = ("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, resultado;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);

                resultado = a + b;

                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El programa no puede leer tipo vocal. Vuelve a intentarlo.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, resultado;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);

                resultado = a - b;

                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El programa no puede leer tipo vocal. Vuelve a intentarlo.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, resultado;

                a = Convert.ToInt16(textBox1.Text);
                b = Convert.ToInt16(textBox2.Text);

                resultado = a * b;

                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El programa no puede leer tipo vocal. Vuelve a intentarlo.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, resultado;

                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);

                resultado = a / b;

                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error. El programa no puede leer tipo vocal. Vuelve a intentarlo.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usarme. Vuelva pronto.\n\n                              :D");

            Close();

        }
    }
}
