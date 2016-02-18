using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form2 : Form
    {
        operacion obj = new operacion();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, suma;
            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);
            suma = obj.sumar(numero1,numero2);

            textBox3.Text = suma.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void restar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, RESTA;
            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);
            RESTA = obj.RESTA(numero1, numero2);

            textBox4.Text = RESTA.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero1, numero2, MULTIPLICACION1;
            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);
            MULTIPLICACION1 = obj.MULTIPLICACION(numero1, numero2);

            textBox5.Text = MULTIPLICACION1.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double numero1, numero2, DIVICION1;
            numero1 = Convert.ToDouble(textBox1.Text);
            numero2 = Convert.ToDouble(textBox2.Text);
            DIVICION1 = obj.DIVICION(numero1, numero2);

            textBox6.Text = DIVICION1.ToString();


        }
    }
}
