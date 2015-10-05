using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenada.Text = string.Format("( {0}, {1} )", e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbRectangulo.Checked)
            {
                textBox1.Text = e.X.ToString();
                textBox4.Text = e.Y.ToString();
            }
            else
            {
                textBox5.Text = e.X.ToString();
                textBox6.Text = e.Y.ToString();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (rbRectangulo.Checked)
            {
                textBox3.Text = e.X.ToString();
                textBox2.Text = e.Y.ToString();
                calcularArea();
                dibujar();
            }
            else
            {
                textBox7.Text = Math.Abs(Convert.ToInt32(textBox5.Text) - e.X).ToString();
                calcularArea();
                dibujar();
            }
        }

        public void calcularArea()
        {
            if (rbRectangulo.Checked)
            {
                Point punto1 = new Point(Convert.ToInt32(txbCuaP1X.Text), Convert.ToInt32);
                Point punto2 = new Point(Convert.ToInt32(txbCuaP2X.Text), Convert.ToInt32);
                r = new Rectangulo(punto1, punto2);
                label8.Text = r.area().toString();
            }
            else
            {
                Point puntoCirculo = new Point(Convert.ToInt32(txbCirculoX.Text));
                int radio = int.Parse(txbCirculoRadio.Text);
                c = new Circulo(radio, puntoCirculo);
                label7.Text = c.area().ToString();
            }
        }

        private void dibujar()
        {
            Color colorPluma;
            if (rbRectangulo.Checked)
            {
                colorPluma = Color.DarkBlue;
            }
            else
            {
                colorPluma = Color.DarkRed;
                v = new Vista(panel1, colorPluma);
                if (rbRectangulo.Checked)
                    v.mostrar_Rectangulo(r);
                else if (rbCirculo.Checked)
                    v.mostrar_Rectangulo(c);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularArea();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
