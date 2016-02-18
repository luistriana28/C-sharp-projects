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
    public partial class Form1 : Form
    {
        int intentos = 0;
        string nombre;
        int password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = textBox1.Text;
                password = Convert.ToInt32(textBox2.Text);
            
                if (nombre == "admin" && password == 1234)
                {

                    this.Hide();
                    Form2 y = new Form2();
                    y.ShowDialog();
                    this.Close();
                }
                else
                {
                    intentos++;
                    MessageBox.Show("verifica tus datos"+ intentos, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    if (intentos == 3)
                    {
                        MessageBox.Show("", "");
                        Application.Exit();
                    }
                }

            }
            catch
            {
                intentos++;
                MessageBox.Show("faltan datos " + intentos, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (intentos == 3)
                {
                    MessageBox.Show("aplicacion","cerrada");
                    Application.Exit();
                }
                }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
