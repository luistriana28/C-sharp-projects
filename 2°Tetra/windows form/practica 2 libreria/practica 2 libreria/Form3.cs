using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_2_libreria
{
    public partial class Form3 : Form
    {
        string nombre;
        int cuenta;
        double saldoinicial;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            nombre = textBox1.Text;
            
            if(textBox1.Text!="")
            {
                
               
                Random r = new Random();
                cuenta = r.Next(0,1000000);
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

            if (textBox3.Text != "")
            {
                textBox2.Text = cuenta.ToString();

            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saldoinicial = Convert.ToDouble(textBox3.Text);
            this.Hide();
            Form4 a = new Form4(nombre,cuenta,saldoinicial);
            a.ShowDialog();

        }
    }
}
