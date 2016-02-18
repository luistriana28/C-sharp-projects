using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseArreglos;

namespace Prac4
{
    public partial class Form1 : Form
    {
        Class1 x = new Class1();
        int[] sueldos = new int[10];
        int s = 0;
        string[] nombres = new string[10];
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Llena los campos");
            }
            else
            {
                if (s < sueldos.Length)
                {
                    try
                    {
                        sueldos[s] = Convert.ToInt32(textBox2.Text);
                        nombres[n] = Convert.ToString(textBox1.Text);
                        listBox1.Items.Add(nombres[n]+"   $"+ sueldos[s].ToString());
                        s++;
                        n++;
                    }
                    catch
                    {
                        MessageBox.Show("Datos Incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("LLENO");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x.Mayor(sueldos, nombres);
            label4.Text = "Sueldo Mayor:  " + x.NomMayor.ToString() + " $" + x.Sueldo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}