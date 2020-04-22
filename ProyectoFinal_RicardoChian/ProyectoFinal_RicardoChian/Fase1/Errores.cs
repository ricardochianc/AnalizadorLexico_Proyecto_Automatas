using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_RicardoChian.Fase1
{
    public class Errores
    {
        public List<string> AdvertenciasGenerales { get; set; }

        public List<string> SetsAdvertencias { get; set; }
        public List<string> tokensAdvertencias { get; set; }
        public List<string> ActionsAdvertencias { get; set; }

        public Errores()
        {
            AdvertenciasGenerales = new List<string>();

            AdvertenciasGenerales.Add("El archivo tiene el formato correcto"); //0
            AdvertenciasGenerales.Add("El archvio no contiene la siguiente parte: "); //1
        }
    }
}
