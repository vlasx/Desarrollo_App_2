using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace App1_Sonidos
{
    class Video : Genero
    {
        private string video;

        public string Video
        {
            get { return video; }
            set { video = value; }
        }

        public Video(string gen, Image foto, string video) : base(gen, foto) { this.Video = video; }

        public override void Accion()
        {
            FRMVideo2 form = new FRMVideo2(Video);
            form.Show();
        } 
       }
}
