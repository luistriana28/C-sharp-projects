using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clases_banco;

namespace banco1
{
    public partial class Form4 : Form
    {
        
        double monto,saldoiniciall;
        string tipo;
        public Form4(string name, double cuenta, double saldoinicial)
        {
            InitializeComponent();
            textBox1.Text = name;
            textBox2.Text =cuenta.ToString();
            textBox4.Text = saldoinicial.ToString();
            listBox1.Items.Add(saldoinicial);
            saldoiniciall = saldoinicial;

            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            tipo = comboBox1.Text;
            
            monto = Convert.ToDouble(textBox3.Text);
            
            if (comboBox1.Text =="Deposito")
            {
                Class1 obj1=new Class1();
                saldoiniciall = obj1.banco(saldoiniciall,monto,tipo);
                listBox1.Items.Add("deposito" + monto);
            }
            else if (comboBox1.Text=="Pago")
            {
                Class1 obj1 = new Class1();
                saldoiniciall = obj1.banco(saldoiniciall, monto, tipo);
                listBox1.Items.Add("pago" + monto);   
            }
        }
    }
}
