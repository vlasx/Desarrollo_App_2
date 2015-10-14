using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    interface ITarjeta_de_Lealtad
    {
        int TotalPoints { get; }
        int AddPoints(int trasanctionValue);
        void ResetPoints();
    }
}
