using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3metodos;
namespace dinamicestatic
{
    public partial class Form1 : Form
    {
        int[] arreglo;
        Class1 x = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] numeros=new int [10];
            listBox1.Items.Clear();
            numeros = x.generar(numeros);
            for (int i = 0; i <numeros.Length;i++ )
            {
                listBox1.Items.Add(numeros[i]);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int lon = Convert.ToInt32(textBox1.Text);
            int[] numeros = new int[lon];
            numeros = x.generar(numeros);
            for (int i = 0; i < lon;i++ )
            {
                listBox1.Items.Add(numeros[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos=0,posicion=0;
            int[] numeros = new int[10];
            
            pos = Convert.ToInt32(textBox2.Text);
            posicion = x.posicion(numeros, posicion);

            if (pos >=arreglo.Length)
            {
                
                MessageBox.Show("tu dato es:");
           
            }
            else
            {
               
                MessageBox.Show("fuera de rango", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
