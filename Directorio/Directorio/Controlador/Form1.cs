using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Directorio.Modelo;
using Directorio.Vista;
using System.Diagnostics;

namespace Directorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndirectorio_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                txtdirectorio.Text = Path.GetFullPath(folderBrowserDialog1.SelectedPath);
                ModeloDirectorio modelo = new ModeloDirectorio(txtdirectorio.Text);
                VistaDirectorio vista = new VistaDirectorio();
                vista.mostrarArchivos(modelo, listView1);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if(MessageBox.Show("Quieres abrir el archivo = "+listView1.SelectedItems[0].Text,
                                    "App Directorio",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                Process proceso = new Process();
                proceso.StartInfo.FileName = txtdirectorio.Text + "\\" + listView1.SelectedItems[0].Text;
                proceso.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
