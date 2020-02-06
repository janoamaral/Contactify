using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactify
{
    public class Importador
    {
        public string Path;
        public string[] Archivo;
        public string[] Output;

        public Importador()
        {
            Path = "";
        }

        public int Cargar()
        {
            if (!File.Exists(Path)) { return -1; }
            Archivo = File.ReadAllLines(Path);
            return 0;
        }

        public int Generar()
        {
            if (Archivo.Length == 0) { return -1; }

            foreach (string linea in Archivo)
            {
                string outLinea;
            }

            return 0;
        }

    }
}
