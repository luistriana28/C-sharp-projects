using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriadeCaracteres
{
    public class Caracteres
    {
        public char Letra(String Nombre, int Power)
        {
            char result = 'X';
            for (int i = 0; i < Nombre.Length; i++)
            {
                if (i == (Power - 1))
                {
                    result = Nombre[1];
                }
            }
            return result;
        }


        public static String QuitarEspacios(String Nombre)
        {
            int a, i;
            
            String CadenaFinal = "";
            a = Nombre.Length;

            for (i = 0; i < a; i++)
            {
                if (Nombre[i] != ' ')
                {
                    CadenaFinal = CadenaFinal + Nombre[i];
                }
            }
            return CadenaFinal;
        }


        public static String Invertir(String Invertir)
        {
            String b = "";
            for (int i = 0; i < Invertir.Length; i++)
            {
                b = Invertir[i] + b;
            }
            return b;
        }
    }
}
