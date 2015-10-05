using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Animacion
{
    class Vista
    {
        private Graphics g;

        int ancho, alto;
        private Pen lapiz;
        private Color colorLapiz;

        public Color P_ColorLapiz
        {
            set { colorLapiz = value; }
        }


        public Vista(Panel areaDibujo)
        {
            this.g = areaDibujo.CreateGraphics();
            this.colorLapiz = Color.Empty;
            ancho = areaDibujo.Width;
            alto = areaDibujo.Height;
        }


        public void dibujar_circulo(circulo c)
        {
            lapiz = new Pen(colorLapiz);
            lapiz.Width = 3;
            g.DrawEllipse(lapiz, c.P_centro.X, c.P_centro.Y, c.P_radio, c.P_radio);
        }

        public void limpiar()
        {
            SolidBrush fondo = new SolidBrush(Color.Black);
            Rectangle cubre = new Rectangle(0, 0, ancho, alto);
            g.FillRectangle(fondo, cubre);
        }

    }
}
