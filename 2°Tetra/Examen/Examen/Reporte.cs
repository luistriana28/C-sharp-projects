using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class Reporte : Form
    {
        int uno, dos, tres, cuatro, cinco, totalv, A, B, C, D, E, F;

        public Reporte(int v1, int v2, int v3, int v4, int v5, int s1, int s2, int s3, int s4, int s5, int st, int vt )
        {
            InitializeComponent();
            uno = v1;
            dos = v2;
            tres = v3;
            cuatro = v4;
            cinco = v5;
            totalv = vt;
            A = s1;
            B= s2;
            C = s3;
            D = s4;
            E = s5;
            F = st;
            

        }

        private void Reporte_Load(object sender, EventArgs e)
        {

            label9.Text = "Localidad 1:                "  + uno + "                    " + "$" + A;
            label10.Text = "Localidad 2:                "  + dos + "                    " + "$" + B;
            label11.Text = "Localidad 3:                "  + tres + "                    " + "$" + C;
            label12.Text = "Localidad 4:                " + cuatro + "                    " + "$" + D;
            label13.Text = "Localidad 5:                "  + cinco + "                    " + "$" + E;
            label14.Text = "TOTALES:         " + totalv + "           " + "$" + F;
        }
    }
}