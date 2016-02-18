using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_Domina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IniciaDomina();
        
        }

        Domina Do = new Domina();

        public void IniciaDomina()
        {
            Do.SetNombre("Melgem Facio Reyes");
            Do.SetHoras(20);
            Do.SetTelefono(87113180);
            Do.SetDomicilio("Cda. Germanio #162 A");
            Do.SetTipodeEmpleado("Administrativo");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            radio_Supervisor.Checked = false;
            radio_Obrero.Checked = false;
            radio_Administrador.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Domicilio.Text = ("");
            txt_Hrs.Text = ("");
            txt_Nombre.Text = ("");
            txt_NoTelefono.Text = ("");
            txt_HrsEx.Text = ("");
            txt_ISR.Text = ("");
            txt_SaldoBruto.Text = ("");
            txt_SaldoNeto.Text = ("");

            radio_Supervisor.Checked = false;
            radio_Obrero.Checked = false;
            radio_Administrador.Checked = false;
        }

        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void bttn_Leer_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = ("" + Do.GetNombre());
            txt_NoTelefono.Text = ("" + Do.GetTelefono());
            txt_Hrs.Text = ("" + Do.GetHoras());
            txt_Domicilio.Text = ("" + Do.GetDomicilio());
            txt_HrsEx.Text = ("" + Do.GetHorasEx());

            switch(Do.GetTipodeEmpleado())
            {
                case "Obrero":
                    {
                        radio_Obrero.Checked = true;

                    }break;
                case "Administrativo":
                    {
                        radio_Administrador.Checked = true;

                    }break;
                case "Supervisor":
                    {
                        radio_Supervisor.Checked = true;

                    }break;
            }
        }

        private void bttn_Guardar_Click(object sender, EventArgs e)
        {
            Do.SetNombre(txt_Nombre.Text);
            Do.SetTelefono(int.Parse(txt_NoTelefono.Text));
            Do.SetHoras(int.Parse(txt_Hrs.Text));
            Do.SetDomicilio(txt_Domicilio.Text);
            Do.SetHorasEx(int.Parse(txt_HrsEx.Text));
            
            if (radio_Obrero.Checked)
            {
                Do.SetTipodeEmpleado("Obrero");
            }
            else if (radio_Administrador.Checked)
            {
                Do.SetTipodeEmpleado("Administrativo");
            }
            else
            {
                Do.SetTipodeEmpleado("Supervisor");
            }
        }

        private void radio_Obrero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bttn_Operar_Click(object sender, EventArgs e)
        {
        //Saldo Bruto
            Do.calculasueldobruto();

            if (radio_Obrero.Checked)
            {
                Do.SetTipodeEmpleado("Obrero");
            }
            else if (radio_Administrador.Checked)
            {
                Do.SetTipodeEmpleado("Administrativo");
            }
            else
            {
                Do.SetTipodeEmpleado("Supervisor");
            }
            
            txt_SaldoBruto.Text = ("" + Do.GetSueldoBruto());

        //Saldo ISR
            Do.calculaISR();

            txt_ISR.Text = ("" + Do.GetISR());

        //Saldo Neto
            Do.calculasueldoneto();

            txt_SaldoNeto.Text = ("" + Do.GetSueldoNeto());
        }
    }
}
