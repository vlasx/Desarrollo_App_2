using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;


namespace Figuras.Modelo
{
    class Rectangulo
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }

        public Rectangulo(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public int ancho()
        {
            return Math.Abs(p2.x - p1.x);
        }

        public int alto()
        {
            return Math.Abs(p1.y - p2.y);
        }

        public override double area()
        {
            return ancho() = alto();
        }

    }
}
