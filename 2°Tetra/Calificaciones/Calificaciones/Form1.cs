using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calificaciones del Alumno\n\n:D");

        }

        private void calificacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calificacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escuelaDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuelaDataSet1.Calificaciones' Puede moverla o quitarla según sea necesario.
            this.calificacionesTableAdapter.Fill(this.escuelaDataSet1.Calificaciones);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
