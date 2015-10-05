using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;

namespace App1_Sonidos
{
    class Coches : Genero
    {
        public Coches(string gen, Image foto): base(gen, foto){}

        public override void Accion()
        {
            SoundPlayer audio = new SoundPlayer("lamb.wav");
            audio.Play();
        }
    }
}
