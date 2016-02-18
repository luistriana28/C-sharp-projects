using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adivinarNumero
{
    public partial class Form1 : Form
    {
       int i,intentos=6;
       int n;
       int numeroaleatorio1 = 0;
        adivina nadiv = new adivina();
        Random r = new Random();
         
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;

           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            i++;



            try
            {

                n = Convert.ToInt32(textBox1.Text);


                do
                {



                    if (i >= intentos)
                    {
                        MessageBox.Show("acabaron tus intentos en el inteto:" + i);

                    }

                    else if (numeroaleatorio1 == n)
                    {
                        MessageBox.Show("felicidades, has ganado en el lugar" + i);
                        button1.Enabled = false;
                        button2.Enabled = false;
                    }
                    else
                    {
                        if (n < numeroaleatorio1)
                        {

                            MessageBox.Show("intenta de nuevo");
                            MessageBox.Show("tu numero es mayor, llevas " + i + "intento");
                        }
                        else if (n > numeroaleatorio1)
                        {
                            MessageBox.Show("intenta de nuevo");
                            MessageBox.Show("tu numero es menor,llevas" + i + "intento");
                        }
                    }




                } while (i == 5 && i == 0);
            }

            catch
            {
                MessageBox.Show("error verifica tus datos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
            numeroaleatorio1 = r.Next(1, 100);
            label2.Text = numeroaleatorio1.ToString();
           
               

                }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 abreN = new Form1();
            abreN.ShowDialog();
            
        }

           
        }
    }

