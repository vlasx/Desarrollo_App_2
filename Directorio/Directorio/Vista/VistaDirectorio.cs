using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Directorio.Modelo;
using System.Windows.Forms;

namespace Directorio.Vista
{
    class VistaDirectorio
    {
        public void mostrarArchivos(ModeloDirectorio directorio, ListView lista)
        {
            string[] archivos = directorio.CargaArchivos();
            foreach (string ruta in archivos)
            {
                FileInfo archivo = new FileInfo(ruta);
                int imagen;
                switch (archivo.Extension)
                { 
                    case ".xls":
                    case ".xlsx": imagen = 0;
                        break;
                    case ".jpg":
                    case ".png": imagen = 1;
                        break;
                    case ".pdf": imagen = 2;
                        break;
                    case ".ppt":
                    case ".pptx": imagen = 3;
                        break;
                    case ".doc" :
                    case ".docx": imagen = 4;
                        break;
                    default: imagen = 5;
                        break;
                }
                lista.Items.Add(archivo.Name, imagen);
            }
        }
    }
}
