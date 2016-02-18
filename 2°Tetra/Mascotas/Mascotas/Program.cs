using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro Cerberus = new Perro();
            Perro Elperrodemijo = new Perro();

            Cerberus.SetNombre("Solo vino");
            Cerberus.SetRaza("Rot Wailer");
            Cerberus.SetTamañodelPelo("Corto");
            
            Elperrodemijo.SetNombre("Bobba");
            Elperrodemijo.SetRaza("Chihuahua");
            Elperrodemijo.SetSexo("Hembra");

            Console.WriteLine("¡¡COSAS QUE HACEN NUESTRAS MASCOTAS!!");
            Console.WriteLine("\n\nCosas que hace mi Perro:\n");
            Console.WriteLine("Nombre: " + Cerberus.GetNombre()+"\nCosas que hace mi Perro:");
            Cerberus.Come();
            Cerberus.Ladra();

            Console.WriteLine("\n\nCosas que hace el perro de mi hijo:");
            Console.WriteLine("Nombre: " + Elperrodemijo.GetNombre()+"\nCosas que hace el Perro de mi hijo:");
            Elperrodemijo.Come();
            Elperrodemijo.Ladra();

        //---------------------------------------------------------
            Gato Gatodemivieja = new Gato();

            Gatodemivieja.SetNombre("Bola de Nieve");
            Gatodemivieja.SetSexo("Hembra");
            Gatodemivieja.SetColor("Balnco");

            Console.WriteLine("\n\nCosas que hace el gato de mi vieja:\n");
            Console.WriteLine("Nombre: " + Gatodemivieja.GetNombre()+"\nCosas que hace el gato de mi vieja:");
            Gatodemivieja.Come();
            Gatodemivieja.Maulla();
            Gatodemivieja.Sueltapelo();


            Console.ReadKey();
        }
    }
}
