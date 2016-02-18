using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Puntos
{
    //Dos Puntos
    class point2D
    {
        protected int X;
        protected int Y;

        //Setters
        public void Setx(int X)
        {
            this.X = X;
        }
        public void Sety(int Y)
        {
            this.Y = Y;
        }
        
        //Metodos
        public virtual void ImprimeCordenadas()
        {
            System.Console.WriteLine("{0}, {1}", X, Y);
        }
    }


    //Tres Puntos
    class point3D : point2D
    {
        private int Z;

        //Setters
        public void Setz(int Z)
        {
            this.Z = Z;
        }
        
        //Metodos
        public override void ImprimeCordenadas()
        {
            System.Console.WriteLine("{0}, {1}, {2}", X, Y, Z);
        }
    }
}

