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
    public partial class Form3 : Form
    {
        
        public Form3(int contador1,int contador2,int contador3,int contador4,int contador5,int contador6,int contador7,int contador8,double suma1,double suma2,double suma3,double suma4,double suma5,double suma6,double suma7,double sumatotal)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            suma1 = calc.costototal * contador1;
            conteollamadas.label17.Text = suma1.ToString();
            suma2 = calc.costototal * contador2;
            conteollamadas.label18.Text = suma2.ToString();
            suma3 = calc.costototal * contador3;
            conteollamadas.label19.Text = suma3.ToString();
            suma4 = calc.costototal * contador4;
            conteollamadas.label20.Text = suma4.ToString();
            suma5 = calc.costototal * contador5;
            conteollamadas.label21.Text = suma5.ToString();
            suma6 = calc.costototal * contador6;
            conteollamadas.label22.Text = suma6.ToString();
            suma7 = calc.costototal * contador7;
            conteollamadas.label23.Text = suma7.ToString();


            sumatotal = suma1 + suma2 + suma3 + suma4 + suma5 + suma6 + suma7;
            conteollamadas.label24.Text = sumatotal.ToString();


            

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
