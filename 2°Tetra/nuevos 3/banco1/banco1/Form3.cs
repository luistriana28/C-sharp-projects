using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco1
{
    public partial class Form3 : Form
    {
        double cuenta,sald;
        string name;
        public Form3()
      
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            Random n = new Random();
            cuenta = n.Next(10000000);
            textBox2.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox2.Text = cuenta.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sald = Convert.ToDouble(textBox3.Text);
            this.Hide();
            Form4 x=new Form4(name,cuenta,sald);
            x.ShowDialog();
        }

    }
}
