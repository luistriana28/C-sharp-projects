using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classcarlitos;

namespace practica_transportes
{
    public partial class Form1 : Form
    {
        string nombre,tipotransporte;
        int horasviajee;
        double tons;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenido");
            textBox3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            try
            {

                nombre = textBox1.Text;

                tipotransporte = comboBox1.Text;

                horasviajee = Convert.ToInt32(textBox2.Text);

                tons = Convert.ToDouble(textBox3.Text);

                
                switch (tipotransporte)
                {
                    case "personas":
                        {
                            personas obj = new personas();
                            MessageBox.Show("nombre del chofer: " + nombre + "\n\ntotal a pagar: $" + obj.costofinal(horasviajee).ToString());
                            

                        } break;

                    case "mercancias":
                        {
                            carga obj = new carga();
                            MessageBox.Show("nombre del chofer: " + nombre + "\n\ntotal a pagar: $"+ obj.costofinall(tipotransporte, horasviajee, tons).ToString());


                        } break;

                    case "quimicos":
                        {
                            carga obj = new carga();
                            MessageBox.Show("nombre del chofer: " + nombre + "\n\ntotal a pagar: $" + obj.costofinall(tipotransporte, horasviajee, tons).ToString());


                        } break;

                }

            }

            catch
            {
                MessageBox.Show("error por favor verifica los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "personas")
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";

            }

            else
            {
                textBox3.Enabled = true;
            
            
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "0";
            textBox3.Enabled = false;
        }
    }
}
