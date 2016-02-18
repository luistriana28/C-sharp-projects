using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Libreria_examen;

namespace Examen
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        int loc1, loc2, loc3, loc4, loc5, s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0, st=0, v1 = 0, v2 = 0, v3 = 0, v4 = 0, v5 = 0, vt = 0;
        string localidad;

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                loc1 = Convert.ToInt16(textBox1.Text);
                loc2= Convert.ToInt16(textBox2.Text);
                loc3 = Convert.ToInt16(textBox3.Text);
                loc4 = Convert.ToInt16(textBox4.Text);
                loc5 = Convert.ToInt16(textBox5.Text);

                
                if (button1.Enabled == false)
                {
                    this.Size = new Size(239, 322);
                }
                else
                {
                    this.Size = new Size(462, 322);
                    groupBox1.Enabled = false;

                }
            }
            catch 
            {
                MessageBox.Show("Verificar datos");
            }
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(239, 322);
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            comboBox1.Focus();
            textBox7.Clear();
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            
            try
            {
                int cxv, Vol;
                localidad = comboBox1.Text;
                Vol = Convert.ToInt16(textBox7.Text);

                switch (localidad)
                {

                    case "Localidad 1":
                        {
                            if (Vol <= 5)
                            {
                                Class1 x = new Class1();
                                label8.Text =  x.Localidad1(loc1, Vol).ToString(); 
                                cxv=Convert.ToInt16(label8.Text);
                                s1 = s1 + cxv;
                                v1 = v1 + Vol;
                            }
                            else
                            {
                                MessageBox.Show("Solo pueden ser 5 voletos por venta");
                                textBox7.Clear();
                            }
                        } break;

                    case "Localidad 2":
                        {
                            if (Vol <= 5)
                            {
                                Class1 x = new Class1();
                                label8.Text = x.Localidad1(loc2, Vol).ToString();
                                cxv = Convert.ToInt16(label8.Text);
                                s2 = s2 + cxv;
                                v2 = v2 + Vol;
                            }
                            else
                            {
                                MessageBox.Show("Solo pueden ser 5 voletos por venta");
                                textBox7.Clear();
                            }
                        } break;

                    case "Localidad 3":
                        {
                            if (Vol <= 5)
                            {
                                Class1 x = new Class1();
                                label8.Text = x.Localidad1(loc3, Vol).ToString();
                                cxv = Convert.ToInt16(label8.Text);
                                s3 = s3 + cxv;
                                v3 = v3 + Vol;

                            }
                            else
                            {
                                MessageBox.Show("Solo pueden ser 5 voletos por venta");
                                textBox7.Clear();
                            }
                        } break;

                    case "Localidad 4":
                        {
                            if (Vol <= 5)
                            {
                                Class1 x = new Class1();
                                label8.Text = x.Localidad1(loc4, Vol).ToString();
                                cxv = Convert.ToInt16(label8.Text);
                                s4 = s4 + cxv;
                                v4 = v4 + Vol;
                            }
                            else
                            {
                                MessageBox.Show("Solo pueden ser 5 voletos por venta");
                                textBox7.Clear();
                            }
                        } break;

                    case "Localidad 5":
                        {
                            if (Vol <= 5)
                            {
                                Class1 x = new Class1();
                                label8.Text = x.Localidad1(loc5, Vol).ToString();
                                cxv = Convert.ToInt16(label8.Text);
                                s5 = s5 + cxv;
                                v5 = v5 + Vol;
                            }
                            else
                            {
                                MessageBox.Show("Solo pueden ser 5 voletos por venta");
                                textBox7.Clear();
                            }
                        } break;

                }
                st = s1 + s2 + s3 + s4 + s5;
                vt = v1 + v2 + v3 + v4 + v5;
                textBox7.Clear();

                
            }
            catch
            {
                MessageBox.Show("verificar datos");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            localidad = comboBox1.Text;
        }

        private void verReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte obj = new Reporte(v1, v2, v3, v4, v5, s1, s2, s3 ,s4, s5, st, vt);
            obj.ShowDialog();
        }
    }
}
