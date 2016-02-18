using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void eNTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 IR = new Form1();
            IR.ShowDialog();

        }

        private void sALIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
