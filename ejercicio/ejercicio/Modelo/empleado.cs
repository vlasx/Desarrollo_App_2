using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    abstract class empleado
    {


        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }


        public virtual void Login()
        {
            MessageBox.Show("Empleado Logeado");
        }

        //public abstract void Hire();

        public empleado(string EmpNumber, string firstName, string lastName, string Address)
        {
            EmpNumber = empNumber;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

    }
}
