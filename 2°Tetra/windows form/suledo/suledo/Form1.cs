using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace suledo
{
    public partial class Form1 : Form
    {
        CALCULAR cal = new CALCULAR();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           textBox1.Focus();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sueldo,horasextra,sueldofinal;
            int categoria=0;

            sueldo = Convert.ToDouble(textBox1.Text);
            categoria = Convert.ToInt32(comboBox1.Text);
            horasextra = Convert.ToDouble(textBox2.Text);
            sueldofinal = cal.calcular(sueldo,categoria,horasextra);

            label5.Text = sueldofinal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 otro = new Form2();
            otro.ShowDialog();
        }
    }
}
