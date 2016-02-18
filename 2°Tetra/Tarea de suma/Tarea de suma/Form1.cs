using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tarea_de_suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bttn_Resultado_Click_1(object sender, EventArgs e)
        {
            int a;
            int b;
            int Resultado;

            a = Convert.ToInt16(txtBox_No1.Text);
            b = Convert.ToInt16(txtBox_No2.Text);

            Resultado = a + b;

            MessageBox.Show("El Resultado de los numeros es:\n\n                              " + Resultado + "\n\nGracias por usarme.  :D");
                        
        }

        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡¡¡SAYONARA!!!...");
            Close();
        }

        private void txtBox_No1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_No2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
