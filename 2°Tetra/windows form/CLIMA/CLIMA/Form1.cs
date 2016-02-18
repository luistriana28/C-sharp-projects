using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLIMA
{
    public partial class Form1 : Form
    {
        grados ce = new grados();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grados, resultado;

            grados = Convert.ToDouble(textBox1.Text);
            resultado = ce.centigrados(grados);

            textBox2.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double grados, resultado;

            grados = Convert.ToDouble(textBox1.Text);
            resultado = ce.farenheit(grados);

            textBox2.Text = resultado.ToString();
        }
    }
}
