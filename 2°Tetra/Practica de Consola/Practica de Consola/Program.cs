using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_de_Consola
{
    class articulo
    {
        private String Nombre;
        private String Marca;
        private String Capacidad;
        private String Descricion;
        private double Precio;
        private double Iva;
        private double Descuento;
        private double Total;
        


        public void SetNombre(String nom)
        {
            Nombre = nom;
        }
        public void SetMarca(String mar)
        {
            Marca = mar;
        }
        public void SetPrecio(double pre)
        {
            Precio = pre;
        }
        public void SetIva(double iv)
        {
            Iva = iv;
        }
        public void SetDescuento(double De)
        {
            Descuento = De;
        }
        public void SetDescripcion(String Des)
        {
            Descricion = Des;
        }
        public void SetCapacidad(String Cap)
        {
            Capacidad = Cap;
        }



        public String GetNombre()
        {
            return Nombre;
        }
        public String GetMarca()
        {
            return Marca;
        }
        public double GetPrecio()
        {
            return Precio;
        }
        public double GetIva()
        {
            return Iva;
        }
        public String GetDescripcion()
        {
            return Descricion;
        }
        public double GetDescuento()
        {
            return Descuento;
        }
        public String GetCapacidad()
        {
            return Capacidad;
        }
        public double GetTotal()
        {
            return Total;
        }


        public void CalculaDescuento()
        {
            Descuento = Precio * 0.05;
        }
        public void CalcularIva()
        {
            Iva = Precio * 0.16;
        }
        public double CalculaTotal()
        {
            double total;
            total = Precio - Descuento + Iva;
            return total;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        //Declaración de variabre
            String Nnombre, Mmarca,Ddescri;
            double Pprecio = 0;

        //Lectura de datos
            articulo articulo1 = new articulo();
            articulo articulo2 = new articulo();
            Console.WriteLine("\n                            ¡¡¡TIENDA DEL PODEROSO MELGEM!!!\n");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("1)\nMenciona el nombre del 1er articulo:");
            Nnombre = Console.ReadLine();
            articulo1.SetNombre(Nnombre);
            Console.WriteLine("\nMenciona su tipo de Marca:");
            Mmarca = Console.ReadLine();
            articulo1.SetMarca(Mmarca);
            Console.WriteLine("\nDescriba el articulo:");
            Ddescri = Console.ReadLine();
            articulo1.SetDescripcion(Ddescri);
            Console.WriteLine("\nMenciona el precio del articulo:");
            Pprecio = Convert.ToDouble(Console.ReadLine());
            articulo1.SetPrecio(Pprecio);


            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("2)\nMenciona el nombre del 2do articulo:");
            Nnombre = Console.ReadLine();
            articulo2.SetNombre(Nnombre);
            Console.WriteLine("\nMeciona su tipo de Marca:");
            Mmarca = Console.ReadLine();
            articulo2.SetMarca(Mmarca);
            Console.WriteLine("\nDescriba el articulo:");
            Ddescri = Console.ReadLine();
            articulo2.SetDescripcion(Ddescri);
            Console.WriteLine("\nMenciona el precio del articulo:");
            Pprecio = Convert.ToDouble(Console.ReadLine());
            articulo2.SetPrecio(Pprecio);


            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  No. ART. |  1)");
            Console.WriteLine("  Articulo | " + articulo1.GetNombre());
            Console.WriteLine("   Marca   | " + articulo1.GetMarca());
            Console.WriteLine("   Precio  | $ " + articulo1.GetPrecio());
            Console.WriteLine("    Iva    | " + articulo1.GetIva());
            Console.WriteLine("Descripcion| " + articulo1.GetDescripcion());

            Console.WriteLine(" \n\n  No. Art. |  2)");
            Console.WriteLine("  Articulo | " + articulo2.GetNombre());
            Console.WriteLine("   Marca   | " + articulo2.GetMarca());
            Console.WriteLine("   Precio  | $ " + articulo2.GetPrecio());
            Console.WriteLine("    Iva    | " + articulo2.GetIva());
            Console.WriteLine("Descripcion| " + articulo2.GetDescripcion());

            Console.WriteLine("\n\n¡¡¡ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
