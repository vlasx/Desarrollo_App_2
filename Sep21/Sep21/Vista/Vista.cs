using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sep21.Modelo;
using System.Windows.Forms;
using System.Collections;

namespace Sep21.Vista
{
    class VistaDatos
    {
        public void MostrarPila(ListBox lista,Stack Pila,Label turno)
        {
            //Limpiando los valores
            lista.Items.Clear();
            //Mostrando los valores
            foreach (Persona item in Pila)
                lista.Items.Add(item);//Si agregas un . despues de item .Nombre solo aparece el nombre en el listbox
            if (Pila.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", Pila.Peek());
            }
            else
                turno.Text = "Sin elementos";
        }

        public void MostrarCola(ListBox lista,Queue Cola, Label turno)
        {
            //Limpiando los valores
            lista.Items.Clear();
            //Mostrando los valores
            foreach (Persona item in Cola)
                lista.Items.Add(item);//Si agregas un . despues de item .Nombre solo aparece el nombre en el listbox
            if (Cola.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", Cola.Peek());
            }
            else
                turno.Text = "Sin elementos";
        }
    }
}
