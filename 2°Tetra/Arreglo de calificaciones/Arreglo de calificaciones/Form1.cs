using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglo_de_calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int [] numeros =new int[20];
        int n = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                listBox1.Items.Add(numeros[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (n == 20)
            {
                MessageBox.Show("Arreglo lleno");
            }
            else
            {
                numeros[n] = Convert.ToInt32(textBox1.Text);
                n++;
                textBox1.Clear();
                textBox1.Focus();
            }
            
            label1.Text = n.ToString();
            
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s = 0,r=0; 

            for (int i = 0; i < n; i++)
            {
                s = s + numeros[i];
                r=s/n;
            }
            textBox2.Text = r.ToString();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion=0;
            posicion = Int32.Parse(textBox3.Text);
            if (posicion < n)
            {
                
                textBox4.Text = numeros[posicion].ToString();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
