using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;

namespace App1_Sonidos
{
    class Documento : Genero
    {
        public string Cv;
        public string cv
        {
            get { return Cv; }
            set { Cv = value; }
        }
        
        public Documento(string gen, Image foto,string Cv): base(gen, foto){
            this.cv = Cv;
        }
        private void doc()
        {
            Process docc = new Process();
            docc.StartInfo.FileName = Cv;
            docc.Start();
        }
        public override void Accion()
        {
            Process.Start(Cv);
        }
    }
}
