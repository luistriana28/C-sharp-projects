using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cosotdecamion;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string name, tipo;
        double h, t, costo;
       
       
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
         
       
                name = Convert.ToString(textBox1.Text);

                tipo = Convert.ToString(comboBox1.Text);
                h = Convert.ToDouble(textBox2.Text);
                t = Convert.ToDouble(textBox3.Text);

                switch (tipo)
                {

                    case "camion de personas":
                        {

                            personas costopersonas = new personas();

                            costo = costopersonas.Cpersonas(tipo, h);

                            label6.Text = costo.ToString();


                        } break;
                    case "camion de mercancia":
                        {
                            textBox3.Visible = true;
                            camion_de_quimicos_y_mercancias costocamiones = new camion_de_quimicos_y_mercancias();
                          
                            costo = costocamiones.camiones(tipo, h, t);

                            label6.Text = costo.ToString();
                        } break;
                    case "camion de quimicos":
                        {
                            textBox3.Visible = true;
                            camion_de_quimicos_y_mercancias costocamiones = new camion_de_quimicos_y_mercancias();
                            costo = costocamiones.camiones(tipo, h, t);

                            label6.Text = costo.ToString();
                        } break;


                }
            }
            catch
            {
                MessageBox.Show("ERROR DE LA CAPTURA", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
                       
                            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "camion de personas")
            {
                textBox3.Enabled = false;

            }
            else
            {
                textBox3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

