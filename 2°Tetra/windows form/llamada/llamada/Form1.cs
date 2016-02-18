using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace llamada
{
    public partial class Form1 : Form
    {
        
        calcularllamada calc = new calcularllamada();

      public  int contador1, contador2, contador3, contador4, contador5, contador6, contador7, contador8;
      public double suma1, suma2, suma3, suma4, suma5, suma6, suma7, sumatotal;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                this.Size = new Size(381, 504);
            }
            else
            {
                this.Size = new Size(757, 504);
            }
            int minutos,zonaa;
           double costototal,costodeminutos;
            string lugar="";
            if (radioButton1.Checked == true)
            {
                lugar = "AMERICA DEL NORTE";
            }
            else if (radioButton2.Checked == true)
            {
                lugar = "AMERICA CENTRAL";
            }
            else if (radioButton3.Checked == true)
            {
                lugar = "AMERICA DEL SUR";
            }
            else if (radioButton4.Checked == true)
            {
                lugar = "EUROPA";
            }
            else if (radioButton5.Checked == true)
            {
                lugar = "ASIA";
            }
            else if (radioButton6.Checked == true)
            {
                lugar = "AFRICA";
            }
            else if (radioButton7.Checked == true)
            {
                lugar = "OCEANIA";
            }
            label8.Text = lugar.ToString();
            label9.Text = (textBox1.Text);
            
            int ELIGEZONA=0;
          
            
             if (radioButton1.Checked == true)
            {
                ELIGEZONA=1;
                
               
            }
            else if (radioButton2.Checked == true)
            {
                ELIGEZONA = 2;
                
                
                
            }
            else if (radioButton3.Checked == true)
            {
                ELIGEZONA = 3;
            }
            else if (radioButton4.Checked == true)
            {
                ELIGEZONA = 4;
            }
            else if (radioButton5.Checked == true)
            {
                ELIGEZONA = 5;
            }
            else if (radioButton6.Checked == true)
            {
                ELIGEZONA = 6;
            }
            else if (radioButton7.Checked == true)
            {
                ELIGEZONA = 7;
            }

             if (radioButton1.Checked == true)
             {
                 costodeminutos=2;
                 label10.Text = costodeminutos.ToString();

             }
             else if (radioButton2.Checked == true)
             {
                 costodeminutos = 2.2;

                 label10.Text = costodeminutos.ToString();

             }
             else if (radioButton3.Checked == true)
             {
                 costodeminutos = 4.5;
                 label10.Text = costodeminutos.ToString();
             }
             else if (radioButton4.Checked == true)
             {
                 costodeminutos = 3.5;
                 label10.Text = costodeminutos.ToString();
             }
             else if (radioButton5.Checked == true)
             {
                 costodeminutos = 6;
                 label10.Text = costodeminutos.ToString();
             }
             else if (radioButton6.Checked == true)
             {
                 costodeminutos = 6;
                 label10.Text = costodeminutos.ToString();
             }
             else if (radioButton7.Checked == true)
             {
                 costodeminutos = 5;
                 label10.Text = costodeminutos.ToString();
             }
            zonaa = Convert.ToInt32(ELIGEZONA);
            minutos =Convert.ToInt32 (textBox1.Text);
            
            costototal = calc.llamada(zonaa,minutos);
           
            label11.Text = costototal.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 conteollamadas = new Form3(contador1, contador2, contador3, contador4, contador5, contador6, contador7, contador8,suma1, suma2, suma3, suma4, suma5, suma6, suma7, sumatotal);
           

            if (radioButton1.Checked == true)
            {
                contador1++;
               
               

            }

            else if (radioButton2.Checked == true)
            {
                contador2++;
               
               
            }

            else if (radioButton3.Checked == true)
            {
                contador3++;
                
                
            }

            else if (radioButton4.Checked == true)
            {
                contador4++;
               

            }

            else if (radioButton5.Checked == true)
            {
                contador5++;
                


            }

            else if (radioButton6.Checked == true)
            {
                contador6++;
               
            }

            else if (radioButton7.Checked == true)
            {
                contador7++;
                


            }

            contador8 = contador1 + contador2 + contador3 + contador4 + contador5 + contador6 + contador7;
            conteollamadas.label9.Text = contador1.ToString();
           conteollamadas.label10.Text = contador2.ToString();
           conteollamadas.label11.Text = contador3.ToString();
           conteollamadas.label12.Text = contador4.ToString();
           conteollamadas.label13.Text = contador5.ToString();
           conteollamadas.label14.Text = contador6.ToString();
           conteollamadas.label15.Text = contador7.ToString();
           conteollamadas.label16.Text = contador8.ToString();

           
            conteollamadas.ShowDialog();







          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled == false)
            {
                this.Size = new Size(757, 504);
            }
            else
            {
                this.Size = new Size(304,496);
                
            }

            textBox1.Clear();
            label8.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label11.Text = String.Empty;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 COSTO = new Form2();

            COSTO.ShowDialog();
        }
    }
}