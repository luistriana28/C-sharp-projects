using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenform
{
    public partial class Form1 : Form
    {
        Class1 calc = new Class1();
        
        string tipo, formadepago;
        double costoArticulo, tucostoes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (radioButton1.Checked == true)
            {
                tipo = "A";

            }

            else if (radioButton2.Checked == true)
            {
                tipo = "B";

            }

            else if (radioButton3.Checked == true)
            {
                tipo = "C";

            }
            else if (radioButton4.Checked == true)
            {
                tipo = "D";
            }



            if (textBox1.Text == "" || comboBox1.Text == "" || radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
                {
                    MessageBox.Show("llena todos tus campos");
                }
            
            else
                {
                    
                    costoArticulo = Convert.ToDouble(textBox1.Text);



                    if (costoArticulo >= 1000)
                    {

                        formadepago = comboBox1.Text;

                        tucostoes = calc.Costofinal(formadepago, costoArticulo, tipo);
                        textBox2.Text = tucostoes.ToString();
                    }
                    else
                    {
                        MessageBox.Show("tu articulo NO cumple para tener dinero alectronico");
                    }


                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

           
           

            
        }
    }

