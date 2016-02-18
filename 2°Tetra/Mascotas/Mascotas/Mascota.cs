using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mascotas
{
    class Mascota
    {
        private String Raza, Color, Tamaño, Sexo, Nombre;

    //Setters
        public void SetRaza(String raza)
        {
            Raza = raza;
        }
        public void SetColor(String co)
        {
            Color = co;
        }
        public void SetTamaño(String Ta)
        {
            Tamaño = Ta;
        }
        public void SetSexo(String Se)
        {
            Sexo = Se;
        }
        public void SetNombre(String No)
        {
            Nombre = No;
        }

    //Getters
        public String GetRaza()
        {
            return Raza;
        }
        public String GetColor()
        {
            return Color;
        }
        public String GetTamaño()
        {
            return Tamaño;
        }
        public String GetSexo()
        {
            return Sexo;
        }
        public String GetNombre()
        {
            return Nombre;
        }

    //Metodos
        public void Come()
        {
            Console.WriteLine("Estoy Comiendo, Imbecil.");
        }
        public void VaalBaño()
        {
            Console.WriteLine("Estoy Cagando. (Sonido de un pedo grande)");
        }
        public void Juega()
        {
            Console.WriteLine("Juega conmigo, maldito bastardo");
        }

    }

    class Perro : Mascota
    {
        private String TamañodelPelo;

    //Setters
        public void SetTamañodelPelo(String Tp)
        {
            TamañodelPelo = Tp;
        }

    //Getters
        public String GetTamañodelPelo()
        {
            return TamañodelPelo;
        }

    //Metodos
        public void Ladra()
        {
            Console.WriteLine("¡¡¡No pos Guau!!! (Con ojos de borracho)");
        }
        public void Babea()
        {
            Console.WriteLine("No pienses que tengo rabia");
        }
        public void Besa()
        {
            Console.WriteLine("Te doy uno grande ¡¡¡Muaa!!");
        }
    }

    class Gato : Mascota
    {
        private String TamañodelPelo;
        private bool  Agil;

        //Setters
        public void SetTamañodelPelo(String Tp)
        {
            TamañodelPelo = Tp;
        }
        public void SetAgil(bool Ag)
        {
            Agil = Ag;
        }

        //Getters
        public String GetTamañodelPelo()
        {
            return TamañodelPelo;
        }
        public bool GetAgil()
        {
            return Agil;
        }

        //Metodos
        public void Ronronea()
        {
            Console.WriteLine("Ronroneo de estar Feliz (Sonido del ronroneo).");
        }
        public void Duermeexceso()
        {
            Console.WriteLine("No me despiertes pinche Amo, o pagaras las consecuencia.");
        }
        public void Sueltapelo()
        {
            Console.WriteLine("Me estoy quedando calvo del trasero pichi geton.");
        }
        public void Maulla()
        {
            Console.WriteLine("Yo Maullo como se me de la gana.");
        }
    }

    class Pez : Mascota
    {
        private bool Agresividd;
        private String TipodeAgua;

        //Setters
        public void SetAgresividad(bool Ag)
        {
            Agresividd = Ag;
        }
        public void SetTipodeAgua(String Ta)
        {
            TipodeAgua = Ta;
        }

        //Getters
        public bool GetAgresividad()
        {
            return Agresividd;
        }
        public String GetTipodeAgua()
        {
            return TipodeAgua;
        }

        //Metodos
        public void Nada()
        {
            Console.WriteLine("Nado y Nado y vuelves a chingar.");
        }
    }
}
