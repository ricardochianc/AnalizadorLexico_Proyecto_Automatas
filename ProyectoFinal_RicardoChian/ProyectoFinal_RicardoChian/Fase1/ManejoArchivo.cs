using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RicardoChian.Fase1
{
    public class ManejoArchivo
    {
        public int Columna { get; set; }
        public int Fila { get; set; }

        public Dictionary<string, List<string>> Sets { get; set; }
        public Dictionary<string, List<string>> Tokens { get; set; }
        public Dictionary<string, List<string>> Actions { get; set; }

        public Errores Error { get; set; }

        public ManejoArchivo()
        {
            Columna = -1;
            Fila = -1;

            Sets = new Dictionary<string, List<string>>();
            Tokens = new Dictionary<string, List<string>>();
            Actions = new Dictionary<string, List<string>>();

            Error = new Errores();
            
        }
    }
}
