using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglos
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        int[] numeros = new int[20];
        int N = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (N == 20)
            {
                MessageBox.Show("ARREGLOS LLENOS");
            }
            else
            {
                numeros[N] = Convert.ToInt32(textBox1.Text);
                N++;
                textBox1.Clear();
                textBox1.Focus();
            }
            listBox1.Items.Clear();
            label1.Text = N.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           for(int i=0;i<N;i++)
            {
                listBox1.Items.Add(numeros[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s=0,resultad;
            for (int i = 0; i < N; i++)
            {
                s = s + numeros[i];
                resultad = s / N;

                textBox2.Text = resultad.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int posicion=0;
            posicion = int.Parse(textBox3.Text);
            if (posicion <= N)
            {

                textBox4.Text = numeros[posicion].ToString();
                
            }
            else
            {
                textBox4.Enabled = false;
                MessageBox.Show("error", "te pasaste del rango", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
    }
}
