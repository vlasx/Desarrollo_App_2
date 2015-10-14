using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Directorio.Modelo
{
    class ModeloDirectorio
    {
        //Nombre del directorio
        private string directorio;

        public ModeloDirectorio(string nombreDirectorio)
        {
            directorio = nombreDirectorio;
        }

        public string[] CargaArchivos()
        {
            return Directory.GetFiles(directorio); 
        }
    }
}
