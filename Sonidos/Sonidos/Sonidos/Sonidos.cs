using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace Sonidos
{
    abstract class Sonidos
    {
        public string Nombre { set; get; }
        public Image Imagen { set; get; }

        public Sonidos(string nombre, Image imagen)
        {
            Nombre = nombre;
            Imagen = imagen;
        }
        abstract public void Play();

       
    }
}
