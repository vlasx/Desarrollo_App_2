using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace App1_Sonidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList lista = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            Registros.RowTemplate.Height = 150;
            Genero genrap = new Coches("Lambo", Image.FromFile("lambo.jpg"));
            lista.Add(genrap);
            Genero docc = new Documento("Ferrari", Image.FromFile("ferrari.jpg"),"f.pdf");
            lista.Add(docc);
            Genero vid = new Video("Audi", Image.FromFile("audi.jpg"), "https://www.youtube.com/watch?v=jzJGrYe3M-c");
            lista.Add(vid);
        
            int i = 0;
            foreach (Genero item in lista)
            {
                
                Registros.Rows.Add();
                Registros[0, i].Value = item.Foto;
                Registros[1, i].Value = item.NombreGenero;
                Registros[2, i].Value = "Da Clic"; 
                i++;                 
            }
        }

        private void datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Genero obj = (Genero)lista[e.RowIndex];
                obj.Accion();
            }
        }
    }
}
