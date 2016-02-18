using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Articulos_a_objetos
{
    public partial class Form1 : Form
    {

        Articulo art = new Articulo();

        public Form1()
        {
            InitializeComponent();
            IniciaArt();
        }

        public void IniciaArt()
        {
            art.SetNombre("Leche");
            art.SetMarca("LALA");
            art.SetPrecio(17.50);
            art.SetCaracteristicas("Descremada");
            art.SetCapacidad("Un Litro");

        }

        public class Articulo
        {
            private String nombre;
            private String marca;
            private String capacidad;
            private String caracteristicas;
            private double precio;
            private double iva;
            private double descuento;

            public void SetNombre(String n)
            {
                nombre = n;
            }

            public void SetMarca(String m)
            {
                marca = m;
            }

            public void SetCapacidad(String c)
            {
                capacidad = c;
            }

            public void SetCaracteristicas(String ca)
            {
                caracteristicas = ca;
            }

            public void SetPrecio(double p)
            {
                precio = p;
            }



            public double GetPrecio()
            {
                return precio;
            }

            public String GetNombre()
            {
                return nombre;
            }

            public String GetMarca()
            {
                return marca;
            }

            public String GetCapacidad()
            {
                return capacidad;
            }

            public String GetCaracteristicas()
            {
                return caracteristicas;
            }

            public double GetIva()
            {
                return iva;
            }

            public double GetDescuento()
            {
                return descuento;
            }

            public void CalculaIva()
            {
                iva = precio * 0.16;
            }

            public void CalculaDescuento()
            {
                descuento = precio * 0.05;
            }

            public double CalculaTotal()
            {
                double total;
                total = precio + iva - descuento;
                return total;
            }
        }

        private void bttn_Salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    *COMPANY MELGEM*\n\nGracias por usarme. Y ¡¡¡DAAAAAAAAA!!!");

            Close();

        }

        private void button_Registrar_Click(object sender, EventArgs e)
        {
            art.SetNombre(textBox_Articulo.Text);
            art.SetCapacidad(textBox_Capacidad.Text);
            art.SetCaracteristicas(textBox_Caracteristica.Text);
            art.SetMarca(textBox_Marca.Text);

            art.SetPrecio(double.Parse(textBox_Precio.Text));
        }

        private void button_Obtener_Click(object sender, EventArgs e)
        {
            art.CalculaIva();
            art.CalculaDescuento();
            
            double precio,iva,descuento;
            
            precio = art.GetPrecio();
            iva = art.GetIva();
            descuento = art.GetDescuento();

            textBox_Precio.Text = ("" + precio);
            textBox_Articulo.Text = art.GetNombre();
            textBox_Capacidad.Text = art.GetCapacidad();
            textBox_Caracteristica.Text = art.GetCaracteristicas();
            textBox_Marca.Text = art.GetMarca();
            textBox_Iva.Text = ("" + iva);
            textBox_Descuento.Text = ("" + descuento);

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_Articulo.Text = ("");
            textBox_Capacidad.Text = ("");
            textBox_Caracteristica.Text = ("");
            textBox_Marca.Text = ("");
            textBox_Precio.Text = ("");
            textBox_Iva.Text = ("");
            textBox_Descuento.Text = ("");
            textBox_Total.Text = ("");

        }

        private void bttn_Calcular_Click(object sender, EventArgs e)
        {
            double total;

            total = art.CalculaTotal();

            textBox_Total.Text = ("" + total);
        }
    }
}
