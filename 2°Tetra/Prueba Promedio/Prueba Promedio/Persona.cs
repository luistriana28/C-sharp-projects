using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prueba_Promedio
{
    class Persona
    {
        protected String Nombre, Direccion;

    //Setters
        public void SetNombre(String n)
        {
            Nombre = n;
        }
        public void SetDireccion(String d)
        {
            Direccion = d;
        }

    //Getters
        public String GetNombre()
        {
            return Nombre;
        }
        public String GetDireccion()
        {
            return Direccion;
        }
    }
}
