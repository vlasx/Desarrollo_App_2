using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sep21.Modelo
{
    class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}", Nombre);
        }
    }
}
