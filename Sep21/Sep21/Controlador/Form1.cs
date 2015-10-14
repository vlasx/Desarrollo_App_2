using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Sep21.Modelo;
using Sep21.Vista;

namespace Sep21
{
    public partial class Form1 : Form
    {

        //PILA
        Stack pila = new Stack();
        //COLA
        Queue cola = new Queue();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //aGREGAR EN COLA
            cola.Enqueue(new Persona(txtItem.Text));
            //Agrefgar en cola
            pila.Push(new Persona(txtItem.Text));
            txtItem.Text = "";
            MostrarDatos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                //Quitar en una cola
                cola.Dequeue();
                //Quitar en una pila
                pila.Pop();
            }
            else
                MessageBox.Show("No hay elementos que remover", "Pila y Cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarDatos();

        }
        private void MostrarDatos()
        {
            VistaDatos v = new VistaDatos();
            v.MostrarPila(lbPila, pila, lbturnopila);
            v.MostrarCola(lbCola, cola, lbturnocola);
            lbCDantidad.Text = String.Format("Elementos: {0}", pila.Count);
        }
    }
}

    
