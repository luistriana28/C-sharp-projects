using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1PRACTICAwindows_forms
{
    public partial class Form1 : Form
    {
        OPERACIONES figura = new OPERACIONES();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            button2.Enabled = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button5.Visible = true;
            textBox1.Focus();
            textBox2.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button5.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            textBox3.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label3.Visible = false;
            textBox3.Visible = false;
            button4.Visible = false;
            textBox4.Visible = false;

           
        }

        private void button4_Click(object sender, EventArgs e)
        {

           

            if (button1.Enabled == true)
            {
                 double numero1, numero2, areat;
                 numero1 = Convert.ToDouble(textBox1.Text);
                numero2 = Convert.ToDouble(textBox2.Text);
                areat = figura.triangulo(numero1, numero2);

                textBox4.Text = areat.ToString();
               
               
            }
            else
            {

                double area, radio;
                 radio = Convert.ToDouble(textBox3.Text);
                area = figura.circulo(radio);

                textBox4.Text = area.ToString();
               


            }
        }
    }
}
 