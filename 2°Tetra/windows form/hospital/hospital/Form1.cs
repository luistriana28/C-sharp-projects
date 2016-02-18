using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
     
    public partial class Form1 : Form
    {
        calcular obj1 =new calcular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nueform2 = new Form2();
            nueform2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int diass, edadd;
            string costot;
            double resultadot;
            if (textBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("ERROR,FALTAN DATOS");
            }
            else
            {
                diass = Convert.ToInt16(textBox1.Text);
                costot = comboBox2.Text;
                edadd = Convert.ToInt16(textBox2.Text);
                
                resultadot = obj1.calcularlo(diass,costot,edadd);

                textBox3.Text = resultadot.ToString();
            }
        }
    }
}
