using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Animacion
{
    class circulo
    {
        private Point centro;

        public Point P_centro
        {
            get { return centro; }
            set { centro = value; }
        }
        

        private int radio;

        public int P_radio
        {
            get { return radio; }
            set { radio = value; }
        }
        

        public circulo(int _radio,Point _centro)
        {
            this.radio = _radio;
            this.centro = _centro;
        }

        public double area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

    }
}
