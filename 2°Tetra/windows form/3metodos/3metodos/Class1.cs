using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3metodos
{
    public class Class1
    {
        public int[] generar(int[] arreglo)
        {
            Random x = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = x.Next(50, 100);
            }
            return arreglo;

        }
        public int posicion(int[] arreglo, int pos)
        {
            return arreglo[pos];
        }
        public int suma(int[] arreglo)
        {
            int s = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                s = s + arreglo[i];
            }
            return s;
        }
    }
}
