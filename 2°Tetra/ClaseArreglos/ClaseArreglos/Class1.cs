using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClaseArreglos
{
    public class Class1
    {
        string nomMayor;
        int mayor;
        
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
        public double posicion1(double[] arreglo, int pos)
        {
            return arreglo[pos];
        }
        public double posicion2(int[] arreglo1, double[] arreglo2, double[] arreglo3, int pos)
        {
            double suma = arreglo1[pos] + arreglo2[pos] + arreglo3[pos];
            return suma;
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
        public int[] ordenar(int[] arreglo)
        {
            Array.Sort(arreglo);
            return arreglo;
        }
        public void Mayor(int[] arreglo, string[] nombre)
        {
            mayor = arreglo[0];
            for (int i = 0; i < arreglo.Length; i++)
                if (arreglo[i] > mayor)
                {
                    mayor = arreglo[i];
                    nomMayor = nombre[i];
                }
        }
        public string NomMayor
        {
            get { return nomMayor; }
        }
        public int Sueldo
        {
            get { return mayor; }
        }
        
        public double Cuadrado2(int num)
        {
            double cuad = Math.Pow((double)num, 2);
            return cuad;
        }

        public double Suma(int num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
        public int menor(int[] arreglo)
        {
            int menor = arreglo[0];
            for (int i = 0; i < arreglo.Length; i++)
                if (arreglo[i] < menor)
                {
                    menor = arreglo[i];
                }
            return menor;
        }
        public int repeat(int[] arreglo)
        {
            int repetido = 0;
            for (int i = 0; i < arreglo.Length; i++)
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[i] == arreglo[j])
                        repetido = arreglo[i];
            return repetido;                      
        }

    }
}
