using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Productos
    {
        public enum Producto { tortas, empanadas, tostadas, quesadillas, tacos, licuados };

        private Producto nombre;
        private decimal precio;

        public Productos(Producto nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Producto Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value > 0)
                    precio = value;
                else
                    precio = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - $ {1} ", Nombre, Precio);
        }
    }
}
