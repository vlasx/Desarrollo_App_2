using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio.Datos
{
    static class Data
    {
        private static List<cliente> clientes = new List<cliente>();
        private static List<Manger> administradores = new List<Manger>();
        private static List<Productos> productos = new List<Productos>();

        public static List<cliente> Clientes {
            get
            {
                return clientes;
            }
        }
        public static  List<Manger> Administradores
        {
            get
            {
                return administradores;
            }
        }
        public static List<Productos> Productos
        {
            get
            {
                return productos;
            }
        }
        public static void add(cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public static void add(Manger administrador)
        {
            administradores.Add(administrador);
        }
        public static void add(Productos producto)
        {
            Productos.Add(producto);
        }
    }
}
