using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Animacion.Properties;
using Animacion;
using System.Threading;
using System.Threading.Tasks; 


namespace Animacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vista V;
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            V = new Vista(panel);
            Random aleatorio = new Random();
            int radio = aleatorio.Next(20, 50);
            int x = aleatorio.Next(0, panel.Width - radio);
            int y = aleatorio.Next(0, panel.Height - radio);
            Point centro = new Point(x, y);
            circulo C = new circulo(radio, centro);
            Task tarea = new Task(() => Animar(V, C));
            tarea.Start();

        }
        private void Animar(Vista V, circulo C)
        {
            V.P_ColorLapiz = Color.Purple;
            V.dibujar_circulo(C);
            bool sentido = true;
            while (true)
            {
                while (checkBoxAnim.Checked)
                {
                    Thread.Sleep(500);
                    V.P_ColorLapiz = Color.White;
                    V.dibujar_circulo(C);
                    if (sentido)
                    {
                        if (C.P_centro.X <= panel.Width - 2 * C.P_radio)
                        {
                            C.P_centro = new Point(C.P_centro.X + C.P_radio, C.P_centro.Y);
                        }
                        else
                            sentido = false;
                    }
                    else
                    {
                        if (C.P_centro.X > C.P_radio)
                            C.P_centro = new Point(C.P_centro.X - C.P_radio, C.P_centro.Y);

                        else
                            sentido = true;
                    }
                    V.P_ColorLapiz = Color.Purple;
                    V.dibujar_circulo(C);
                }

            }
        }
    }
}
