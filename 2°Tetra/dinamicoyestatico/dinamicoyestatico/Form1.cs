using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamicoyestatico
{
    public partial class Form1 : Form
    {
        int[] numero = new int[10];
        int n = 0;

        Class1 x=new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numero = new int[10];
            listBox1.Items.Clear();
            numero=x.generar(numero);
            for (int i = 0; i < numero.Length; i++)
            {
                listBox1.Items.Add(numero[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int lon;
            lon = Convert.ToInt32(textBox1.Text);
            int[] numero = new int[lon];
            numero = x.generar(numero);

            for (int i = 0; i < lon; i++)
            {
                listBox1.Items.Add(numero[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arreglo;
            int posicion;

            posicion = Convert.ToInt32(textBox2.Text);
            posicion = x.posicion(numero, posicion);
            if (posicion >= numero.Length)
            {
                MessageBox.Show("Dato " + numero[posicion]);
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

            
        }


    }
}
