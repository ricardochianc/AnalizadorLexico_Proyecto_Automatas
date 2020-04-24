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
            SetsAdvertencias.Add("No existe comilla simple de apertura"); //2
            SetsAdvertencias.Add("El rango debe de definirse con dos puntos consecutivos");//3
            SetsAdvertencias.Add("Error en la definición de la función CHAR en el SET");//4
            SetsAdvertencias.Add("La función CHR debe de tener paréntesis de apertura");//5
            SetsAdvertencias.Add("La función CHR debe de tener paréntesis de cierre");//6
            SetsAdvertencias.Add("Error en la función numérica que definen los CHR"); //7
            SetsAdvertencias.Add("Ya existe un SET definido con ese nombre"); //8
            SetsAdvertencias.Add("El formato de comillas está malo"); //9

            tokensAdvertencias = new List<string>();

            tokensAdvertencias.Add("El nombre definidor del TOKEN contiene un espacio de por medio"); //0
            tokensAdvertencias.Add("El TOKEN no contiene un signo igual que le de definición, formato: TOKEN # = DEFINICIÓN"); //1
            tokensAdvertencias.Add("Ya existe un número de TOKEN igual");//2
            tokensAdvertencias.Add("No debe de existir algún otro tipo de caracter en la definición del TOKEN");//3
            tokensAdvertencias.Add("Debe de existir al menos un espacio entre la palabra TOKEN y el número que se le asigna");//4
            tokensAdvertencias.Add("El número de token ya fue asignado");//5
            tokensAdvertencias.Add("No existe comilla simple de apertura"); //6
            tokensAdvertencias.Add("No existe comillas simples de cierre"); //7
            tokensAdvertencias.Add("El formato de comillas está malo, debe de existir un único caracter encerrado en comillas"); //8
            tokensAdvertencias.Add("La expresión no forma parte de algún SET definido previamente"); //9 nuevos
            tokensAdvertencias.Add("El caracter no forma parte de algún SET definido previamente"); //10 nuveos

            ActionsAdvertencias = new List<string>();

            ActionsAdvertencias.Add("No deben de existir espacios en la definición de la función del ACTION");//0
            ActionsAdvertencias.Add("La función debe de tener paréntesis de apertura y de cierre, de manera contigua y sin espacios \"()\"");//1
            ActionsAdvertencias.Add("La función no contiene llave de inicio \"{\"");//2
            ActionsAdvertencias.Add("El número que se le asignó al ACTIONS ya se encuentra utilizado");//3
            ActionsAdvertencias.Add("La definición del ACTION debe de ser un número");//4
            ActionsAdvertencias.Add("El ACTION debe de estar definido dentro de comillas simples");//5
        }
    }
}
