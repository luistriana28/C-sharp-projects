using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using montoss;
namespace practica_2_libreria
{
    public partial class Form4 : Form
    {
        
        string acciones;
        double saldo;
        double monto;
        string nombre1;

        public Form4(string nombre1,int cuenta1,double saldoinicial)
        {
            InitializeComponent();
            label3.Text = nombre1;
            label4.Text = cuenta1.ToString();
            saldo = saldoinicial;

            
        }
       

        private void Form4_Load(object sender,EventArgs e)
        {
            listBox1.Items.Add("$"+ saldo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acciones = comboBox1.Text;
            monto = Convert.ToDouble(textBox1);
           

            if (comboBox1.Text == "deposito")
            {
                Class1 raul = new Class1();
                saldo = raul.regresa(monto, saldo, acciones);

                listBox1.Items.Add("$"+ saldo);

            }
            if (comboBox1.Text == "pago")
            {
                Class1 raul = new Class1();
                saldo = raul.regresa(monto, saldo, acciones);
                listBox1.Items.Add("$"+ saldo);
            }
            else
            {
                Class1 raul = new Class1();
                saldo = raul.regresa(monto, saldo, acciones);


                listBox1.Items.Add("$"+ saldo);
            }
           
        }

    }
}
