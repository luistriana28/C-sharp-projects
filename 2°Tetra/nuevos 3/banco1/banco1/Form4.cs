using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace banco1
{
    public partial class Form4 : Form
    {
        public double saldoini, monto;
        public string nombre;
        public double acc;
        public Form4(string name, double cuenta, double sald)
        {
            InitializeComponent();
            label3.Text = name;
            label4.Text = cuenta.ToString();
            saldoini = sald;
            nombre = name;
            acc = cuenta;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("$" + saldoini);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("ERROR","Faltan Datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                monto = Convert.ToDouble(textBox3.Text);
                if (comboBox1.Text == "Deposito")
                {
                    Deposito x = new Deposito();
                    saldoini = x.calcular(saldoini, monto);
                    listBox1.Items.Add("Deposito" + "$" + monto);
                }
                if (comboBox1.Text == "Pago")
                {
                    if (monto > saldoini)
                    {
                        MessageBox.Show("Saldo Insuficiente","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    }
                    else
                    {
                        Pago y = new Pago();
                        saldoini = y.calcular(saldoini, monto);
                        listBox1.Items.Add("Pago" + "$" + monto);
                    }
                }
                if (comboBox1.Text == "Consulta")
                {
                    MessageBox.Show("Nombre:     " + nombre + "     Cuenta:     " + acc + "     Saldo:     " + saldoini);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Consulta")
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
            else
            {
                textBox3.Enabled=true;
            }
        }
    }
}
