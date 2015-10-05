using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace App1_Sonidos
{
    abstract class Genero
    {
        private string genero;

        public string NombreGenero
        {
            get { return genero; }
            set { genero = value; }
        }

        private Image _foto;

        public Image Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }


        public Genero(string gen, Image foto)
        {
            this.NombreGenero = gen;
            this.Foto = foto;
        }

        public virtual void Accion()
        {
        }
    }
}
