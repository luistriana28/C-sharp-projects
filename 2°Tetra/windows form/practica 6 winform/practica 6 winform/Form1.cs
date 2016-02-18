using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace practica_6_winform
{
    public partial class Form1 : Form
    {

       public int contador1,contador2,contador3,contador4,contador5,contador6,contador7,totalllamadas;
       double llamadact1, llamadact2, llamadact3, llamadact4, llamadact5, llamadact6, llamadact7, llamadactfinal;
        
        costollamada obj1 = new costollamada();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //seleccionar lugar al que se llamo
            
            string lugar;

            if (radioButton1.Checked == true)
            {
                lugar = "America del norte";

                label8.Text = lugar;

                label10.Text = "$2";
                
            }

            else if (radioButton2.Checked == true)
            {
                lugar = "America central";
                label8.Text = lugar;
                label10.Text = "$2.2";
            
            }

            else if (radioButton3.Checked == true)
            {
                lugar = "America del sur";
                label8.Text = lugar;
                label10.Text = "$4.50";
            
            }

            else if(radioButton4.Checked==true)
            {
                lugar = "Europa";
                label8.Text = lugar;
                label10.Text = "$3.50";
            
            
            }

            else if (radioButton5.Checked == true)
            {
                lugar = "Asia";
                label8.Text = lugar;
                label10.Text = "$6";
            
            
            }

            else if (radioButton6.Checked == true)
            {
                lugar = "Africa";
                label8.Text = lugar;
                label10.Text = "$6";
            
            
            }

            else if (radioButton7.Checked == true)
            {
                lugar = "Oceania";
                label8.Text = lugar;
                label10.Text = "$5";
            
            
            }
            
            
            //imprimir los minutos en el campo desplegable
            
            label9.Text = textBox1.Text+" minutos";

          

            
            //convertir los radiobutons a INT para poder usarlos como parametros
            
            int zona = 0;

            if (radioButton1.Checked == true)
            {
                zona = 1;
            
            }

            else if (radioButton2.Checked == true)
            {
                zona = 2;
            
            }

            else if (radioButton3.Checked == true)
            {
                zona = 3;
            
            }

            else if (radioButton4.Checked == true)
            {
                zona = 4;
            
            }

            else if (radioButton5.Checked == true)
            {
                zona = 5;
            
            }

            else if (radioButton6.Checked == true)
            {
                zona = 6;
            
            }

            else if (radioButton7.Checked == true)
            {
                zona = 7;
            
            
            }

           
            // calcular costo final e imprimirlo y mostrar mensaje de error
            double costofinal=0;
            int minutos;


            if (textBox1.Text == "")
            {
               
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                
                label8.Text = String.Empty;
                label9.Text = String.Empty;
                label10.Text = String.Empty;
                label12.Text = String.Empty;
                
                
                SystemSounds.Beep.Play();
                MessageBox.Show("Por favor llena todos los campos.");
                

            }

            else
            {
                //redimencionar formulario para mostrar datos de la llamada
                this.Size = new Size(552, 442);

                labeldivisor.Visible = true;
                labeldivisor.AutoSize = false;
                labeldivisor.Height = 385;
                labeldivisor.Width = 2;
                labeldivisor.BorderStyle = BorderStyle.Fixed3D;
                
                
                minutos = Convert.ToInt32(textBox1.Text);

                costofinal = obj1.llamada(minutos, zona);
                label12.Text = costofinal.ToString();
            
            
            }

            

            
            // contador de llamadas y monto total


            if (radioButton1.Checked == true)
            {
                contador1++;
                
                
                llamadact1 = costofinal;
            }

            else if (radioButton2.Checked == true)
            {
                contador2++;
                llamadact2 = costofinal;
            
            }

            else if (radioButton3.Checked == true)
            {
                contador3++;
                llamadact3 = costofinal;
            
            }

            else if (radioButton4.Checked == true)
            {
                contador4++;
                llamadact4 = costofinal;
            
            }

            else if (radioButton5.Checked == true)
            {
                contador5++;
                llamadact5 = costofinal;
            
            
            }

            else if (radioButton6.Checked == true)
            {
                contador6++;
                llamadact6 = costofinal;
            
            
            }

            else if (radioButton7.Checked == true)
            {
                contador7++;
                llamadact7 = costofinal;
            
            
            }

           
            //total de llamadas

            totalllamadas = contador1 + contador2 + contador3 + contador4 + contador5 + contador6 + contador7;
         
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //boton clear

            this.Size = new Size(269, 445);
            
            textBox1.Clear();
            
            label8.Text = String.Empty;
            label9.Text = String.Empty;
            label10.Text = String.Empty;
            label12.Text = String.Empty;
            labeldivisor.Visible = false;

            textBox1.Focus();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //imprime el reporte de llamadas

            Form3 x = new Form3(llamadact1, llamadact2, llamadact3, llamadact4, llamadact5, llamadact6, llamadact7, llamadactfinal, contador1, contador2, contador3, contador4, contador5, contador6, contador7, totalllamadas);
         
            x.ShowDialog();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show(); 
            textBox1.Focus();
        }
    }
}
