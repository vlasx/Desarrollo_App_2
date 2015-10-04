using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace Sonidos
{
    class Ferrari : Sonidos
    {
        private string audio;

        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }
        public Ferrari(string nombre, Image imagen, string audio)
            : base(nombre, imagen)
        {
            Audio = audio;
        }
        public override void Play()
        {
            SoundPlayer l = new SoundPlayer(Audio);
            l.Play();
        }
    }
}
