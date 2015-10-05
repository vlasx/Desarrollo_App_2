using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras.Modelo
{
    class Vista
    {
        private Graphics g;
        private Color colorLapiz;
        private int anchura, altura;
        private Pen Lapiz;

        public Vista(Panel areaDibujo, Color c1)
        {
            g = areaDibujo.CreateGraphics();
            colorLapiz = c1;
            anchura = areaDibujo.Width;
            altura = areaDibujo.Height;
        }

        public void mostrar_Rectangulo(Rectangulo r)
        {
            Lapiz = new Pen(colorLapiz, 3);
            g.DrawRectangle(Lapiz, r.p1.x, r.p1.y, r.ancho(), r.alto());
        }

        public void mostrar_circulo(Circulo c)
        {
            Lapiz = new Pen(colorLapiz, 3);
            g.DrawEllipse(Lapiz, c.centro.x, c.centro.y, c.radio, c.radio);
        }

        public void borrar()
        {
            SolidBrush fondo = new SolidBrush(Color.LightBlue);
            Rectangle rect = new Rectangle(0, 0, anchura, altura);
            g.FillRectangle(fondo, rect);
        }
    }
}
