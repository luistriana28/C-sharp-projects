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
        int intentos=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = textBox1.Text;
            password = textBox2.Text;

            if (usuario == "juan" && password == "1234")
            {
                this.Hide();
                Form2 obj = new Form2();
                obj.ShowDialog();
            }
            if (textBox1.Text == "" || textBox2.Text == "")
                {
                    intentos++;
                    MessageBox.Show("Faltan Datos     " + "Intentos     " + intentos);
                }
            else if (usuario != "juan" || password != "1234")
            {
                intentos++;
                MessageBox.Show("Usuario o Contraseña no validos     " + "Intentos     " + intentos);
            }
            if (intentos == 3)
            {
                MessageBox.Show("Aplicacion Bloqueada");
                Application.Exit();
            }
        }

    }
}

