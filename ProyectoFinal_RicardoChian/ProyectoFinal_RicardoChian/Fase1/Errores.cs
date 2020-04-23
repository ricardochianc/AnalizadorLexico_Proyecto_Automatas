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
            AdvertenciasGenerales.Add("El archivo se encuentra vacío"); //1
            AdvertenciasGenerales.Add("El archivo no contiene:  "); //2
            AdvertenciasGenerales.Add("La sección SETS debe ir primero que la sección TOKENS");//3
            AdvertenciasGenerales.Add("El valor de ERROR es incorrecto");//

            SetsAdvertencias = new List<string>();

            SetsAdvertencias.Add("El nombre definidor del SET contiene un espacio de por medio"); //0
            SetsAdvertencias.Add("El set no contiene un signo igual que le de definición, formato: NOMBRE = DEFINICIÓN"); //1
            SetsAdvertencias.Add("No existe comilla simple de inicio"); //2
            SetsAdvertencias.Add("El rango debe de definirse con dos puntos consecutivos");//3
            SetsAdvertencias.Add("Error en la definición de la función CHAR en el SET");//4
            SetsAdvertencias.Add("La función CHR debe de tener paréntesis de apertura");//5
            SetsAdvertencias.Add("La función CHR debe de tener paréntesis de cierre");//6
            SetsAdvertencias.Add("Error en la función numérica que definen los CHR"); //7
        }
    }
}
