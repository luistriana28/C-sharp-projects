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

namespace Prac5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numero = new int [10];
        int n = 0;
        double[] cuad = new double[10];
        double[] sum = new double[10];
        Class1 H = new Class1();

        private void textBox1_PreviewKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    numero[n] = Convert.ToInt16(textBox1.Text);
                    listBox1.Items.Add(numero[n]);
                    cuad[n] = H.Cuadrado2(numero[n]);
                    listBox2.Items.Add(cuad[n]);
                    sum[n] = H.Suma(numero[n], cuad[n]);
                    listBox3.Items.Add(sum[n]);
                    n++;
                    textBox1.Clear();                                    
                }
                catch
                {
                    MessageBox.Show("ERROR", "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                try
                {
                    int pos = Convert.ToInt32(textBox2.Text);
                    if (pos > 9)
                        MessageBox.Show("Encontraste el limite del arreglo.");
                    else
                        MessageBox.Show("La suma de la posición seleccionada es igual a: " + H.posicion2(numero, cuad, sum, pos));
                }
                catch
                {
                    MessageBox.Show("Se necesitan datos para calcular la suma, gracias.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
