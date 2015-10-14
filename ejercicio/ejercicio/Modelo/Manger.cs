using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    class Manger : empleado
    {
        public enum Depto { Ventas, Compras, Contrataciones, Gerencia };
        
        private Depto departamento;
        
        public Depto Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        
        public Manger(string EmpNumber, string Name, string LastName, string Address, Depto depto)
            : base(EmpNumber, Name, LastName, Address)
        {
            departamento = Departamento;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} {2} {3} {4} ", EmpNumber, FirstName, LastName, Address, Departamento);
        }
       


    }
}
