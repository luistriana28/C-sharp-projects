using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using costolocalidades;
namespace examengaraybiblioteca
{
    public partial class Form1 : Form
    {
        int capturadeventas, boletos, totaldeboletos;
        int loca1, loca2, loca3, loca4, loca5,saldodeboletos,costoingresado;
        int localidad;
        Class1 devuelve = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                boletos = Convert.ToInt32(textBox7.Text);
                if (boletos > 5)
                {
                    MessageBox.Show("tus boletos tienes que ser menores que 5");
                }


                localidad = Convert.ToInt32(textBox6.Text);
                switch (localidad)
                {
                    case 1:
                        {
                            totaldeboletos++;
                            
                            costoingresado = loca1;

                            saldodeboletos = devuelve.valor(localidad, costoingresado, boletos);
                            textBox8.Text = saldodeboletos.ToString();
                            capturadeventas++;
                        } break;
                    case 2:
                        {
                            totaldeboletos++;
                            
                            costoingresado = loca2;


                            saldodeboletos = devuelve.valor(localidad, costoingresado, boletos);
                            textBox8.Text = saldodeboletos.ToString();
                            capturadeventas++;
                        } break;
                    case 3:
                        {
                            totaldeboletos++;
                           
                            costoingresado = loca3;

                            saldodeboletos = devuelve.valor(localidad, costoingresado, boletos);
                            textBox8.Text = saldodeboletos.ToString();
                            capturadeventas++;
                        } break;
                    case 4:
                        {
                           
                            costoingresado = loca4;

                            saldodeboletos = devuelve.valor(localidad, costoingresado, boletos);
                            textBox8.Text = saldodeboletos.ToString();
                            capturadeventas++; 
                        } break;
                    case 5:
                        {
                            totaldeboletos++;
                            
                            costoingresado = loca5;

                            saldodeboletos = devuelve.valor(localidad, costoingresado, boletos);
                            textBox8.Text = saldodeboletos.ToString();
                            capturadeventas++;
                        } break;

                }
                
                capturadeventas=capturadeventas+saldodeboletos;
                
            }
            catch
            {
                MessageBox.Show("error","llena tus datos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                loca1 = Convert.ToInt32(textBox1.Text);
                loca2 = Convert.ToInt32(textBox2.Text);
                loca3 = Convert.ToInt32(textBox3.Text);
                loca4 = Convert.ToInt32(textBox4.Text);
                loca5 = Convert.ToInt32(textBox5.Text);

                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "")
                {
                    MessageBox.Show("error", "llena todos tus campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
                else
                {
                    groupBox2.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("error", "llena todos tus campos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox6.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 reporte = new Form2(capturadeventas,totaldeboletos);
            reporte.ShowDialog();
        }
    }
}
