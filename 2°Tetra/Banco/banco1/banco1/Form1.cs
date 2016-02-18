using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string usuario, password;
            usuario = textBox1.Text;
            password = textBox2.Text;

            if (usuario == "admin" && password == "1234")
            {
                this.Hide();
                Form2 obj = new Form2();
                obj.ShowDialog();
            }
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Faltan Datos");
            }
            else if (usuario != "admin" || password != "1234")
            {
                MessageBox.Show("Usuario o Contraseña no validos");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }

