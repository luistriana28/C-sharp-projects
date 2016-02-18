using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_6_winform
{
    public partial class Form3 : Form
    {
       
        
        public Form3( double llamadact1,double llamadact2,double llamadact3,double llamadact4,double llamadact5,double llamadact6,double llamadact7,double llamadactfinal,int contadorr1,int contadorr2,int contadorr3, int contadorr4, int contadorr5, int contadorr6, int contadorr7, int totalcalls)
        {
            
            
            InitializeComponent();
            
            label8xxx.Text = contadorr1.ToString();
            label8xxx.Refresh();
            label9xxx.Text = contadorr2.ToString();
            label10xxx.Text = contadorr3.ToString();
            label11xxx.Text = contadorr4.ToString();
            label12xxx.Text = contadorr5.ToString();
            label13xxx.Text = contadorr6.ToString();
            label14xxx.Text = contadorr7.ToString();
            label9zzz.Text = totalcalls.ToString();




            llamadact1 = llamadact1 * contadorr1;
            label9sumador1.Text = llamadact1.ToString();

            llamadact2 = llamadact2 * contadorr2;
            label15sumador2.Text = llamadact2.ToString();

            llamadact3 = llamadact3 * contadorr3;
            label16sumador3.Text = llamadact3.ToString();

            llamadact4 = llamadact4 * contadorr4;
            label17sumador4.Text = llamadact4.ToString();

            llamadact5 = llamadact5 * contadorr5;
            label18sumador5.Text = llamadact5.ToString();

            llamadact6 = llamadact6 * contadorr6;
            label19sumador6.Text = llamadact6.ToString();

            llamadact7 = llamadact7 * contadorr7;
            label20sumador7.Text = llamadact7.ToString();

            llamadactfinal = llamadact1 + llamadact2 + llamadact3 + llamadact4 + llamadact5 + llamadact6 + llamadact7;
            label21sumadortotal.Text = llamadactfinal.ToString();

           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 llamadactt = new Form1();
            
            
            label9xxx.Refresh();
            label9xxx.ToString();


        }
    }
}
