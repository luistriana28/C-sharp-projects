using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examengaraybiblioteca
{
    public partial class Form2 : Form
    {
        int contadorv, contadorb, localidad;
        public Form2(int capturadeventas, int totaldeboletos)
        {
            InitializeComponent();
            contadorv = capturadeventas;


            contadorb = totaldeboletos;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (localidad)
            {
                case 1:
                    {
                        contadorv++;
                        contadorb++;

                       
                    } break;
                case 2:
                    {
                        contadorv++;
                        contadorb++;

                    } break;
                case 3:
                    {
                        contadorv++;
                        contadorb++;
                       


                    } break;
                case 4:
                    {
                        contadorv++;
                        contadorb++;
                        
                    } break;
                case 5:
                    {
                        contadorv++;
                        contadorb++;
                        

                    } break;
            }
            textBox1.Text = contadorv.ToString();
            textBox2.Text = contadorb.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
