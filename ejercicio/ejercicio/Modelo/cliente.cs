using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio
{
    class cliente : ITarjeta_de_Lealtad
    {

        private int totalPoints;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int TotalPoints
        {
            get
            {
                if (totalPoints >= 0)
                    return totalPoints;
                else
                    return 0;
            }
        }

        public int AddPoints(int trasanctionValue)
        {
            this.totalPoints += totalPoints;
            return totalPoints;
        }

        public void ResetPoints()
        {
            totalPoints=0;
        }

        public override string ToString()
        {
          return string.Format("Cliente: {0} - Puntos acumulados: {1}", this.Nombre, this.TotalPoints);
        }

        public cliente(string nombre)
        {
            Nombre = nombre;
            totalPoints = 0;
        }

    }
}
