using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio.Vista
{
    class VistaDatos
    {
        //public void MostrarAdiministradores(ListBox lista, List<Manger> administradores)
        //{
        //    foreach (Manger admin in administradores)
        //        lista.Items.Add(admin);
        //}

        //public void MostrarProductos(ListBox lista, List<Productos> productos)
        //{
        //    foreach (Productos prod in productos)
        //        lista.Items.Add(prod);
        //}

        //public void MostrarClientes(ListBox lista, List<cliente> clientes)
        //{
        //    foreach (cliente cliente in clientes)
        //        lista.Items.Add(cliente);
        //}

        public void Mostrar<T>(ListBox lista, List<T> coleccion)
        {
            foreach (object item in coleccion)
                lista.Items.Add(item);
        }
    }
}
