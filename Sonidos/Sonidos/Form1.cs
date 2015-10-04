using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.Collections;
using Sonidos;



namespace Sonidos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        ArrayList miLista = new ArrayList();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Sonidos auto = (Sonidos)miLista[e.RowIndex];
                auto.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lambo Murcielago = new Lambo("Lamborghini", Image.FromFile("lambo.jpg"), "lambo.wav");
            miLista.Add(Murcielago);
            Ferrari M = new Ferrari("Ferrari", Image.FromFile("ferrari.jpg"), "ferrari.wav");
            miLista.Add(M);
            Audi A = new Audi("Audi", Image.FromFile("audi.jpg"), "audi.wav");
            miLista.Add(A); 


            int i = 0;
            foreach (Sonidos item in miLista)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = item.Imagen;
                dataGridView1[1, i].Value = item.Nombre;
                dataGridView1[2, i].Value = "Reproducir";
                i++;
            }


        }
    }
}
