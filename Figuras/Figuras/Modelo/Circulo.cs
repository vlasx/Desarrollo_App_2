using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Figuras.Modelo
{
    class Circulo
    {
        public int radio { get; set; }
        public Point centro { get; set; }

        public Circulo(int r, Point c)
        {
            radio = r;
            centro = c;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

    }
}
