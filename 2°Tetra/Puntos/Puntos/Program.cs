using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puntos
{
    class Program
    {
        static void Main(string[] args)
        {
            point2D pun2D = new point2D();
            point3D pun3D = new point3D();

            pun2D.Setx(10);
            pun2D.Sety(5);
            Console.WriteLine("Dimencion de dos puntos (2D):");
            pun2D.ImprimeCordenadas();

            pun3D.Setx(15);
            pun3D.Sety(10);
            pun3D.Setz(5);
            Console.WriteLine("\n\nDimencion de tres puntos (3D):");
            pun3D.ImprimeCordenadas();

            Console.WriteLine("\n\n\n¡¡¡DE ENTER PARA SALIR!!!");
            Console.ReadKey();
        }
    }
}
