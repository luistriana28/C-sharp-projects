using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace escuela
{
    using System.Media;
    public partial class Form1 : Form
    {
        
        verificacion obj1 = new verificacion();
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
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            if (button2.Enabled == false)
            {
                this.Size = new Size(757, 504);
            }
            else
            {
               
                this.Size = new Size(381, 504);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string carrera, resultado;
            string matricula;
            double promedioo;
            int semestre;




            if (textBox1.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox2.Text == "")
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("error.faltan datos");
               
            }
            else
            {





                matricula = Convert.ToString(textBox1.Text);

                carrera = Convert.ToString(comboBox1.Text);
                semestre = Convert.ToInt16(comboBox2.Text);
                promedioo = Convert.ToDouble(textBox2.Text);
                resultado = obj1.calcular(carrera, semestre, promedioo);

                label7.Text = resultado.ToString();

                if (resultado == "aceptado")
                {
                    label7.Font = new System.Drawing.Font(label7.Font, FontStyle.Bold); 

                    label7.ForeColor = Color.Blue;
                }
                else
                {
                    label7.Font = new System.Drawing.Font(label7.Font, FontStyle.Bold);
                    label7.ForeColor = Color.Red;

                }
                if (button1.Enabled == false)
                {
                    this.Size = new Size(381, 504);
                }
                else
                {
                    this.Size = new Size(757, 504);



                }
                
                label9.Text = (textBox1.Text);
                label10.Visible = true;
                label10.Text = (comboBox1.Text);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
