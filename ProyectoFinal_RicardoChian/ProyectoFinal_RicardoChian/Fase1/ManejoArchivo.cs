using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal_RicardoChian.Fase1
{
    public class ManejoArchivo
    {
        public string Contenido { get; set; }
        
        public int Columna { get; set; }
        public int Fila { get; set; }

        public Dictionary<string, List<string>> Sets { get; set; }
        public Dictionary<string, List<string>> Tokens { get; set; }
        public Dictionary<string, List<string>> Actions { get; set; }

        public int Error { get; set; } //se refiere al apartado ERROR del archivo

        public Errores Advertencia { get; set; }

        public ManejoArchivo()
        {
            Columna = -1;
            Fila = -1;

            Sets = new Dictionary<string, List<string>>();
            Tokens = new Dictionary<string, List<string>>();
            Actions = new Dictionary<string, List<string>>();

            Advertencia = new Errores();
            
        }

        //----------------------------MÉTODOS GENERALES-------------------------------------------------------------

        /// <summary>
        /// Método que remueve tabs y espacios de una subcadena deseada
        /// </summary>
        /// <param name="subcadena"></param>
        /// <returns></returns>
        private string RemoverEspacios(string subcadena)
        {
            if (subcadena.Contains(" "))
            {
                subcadena = subcadena.Replace(" ", "");
            }

            if (subcadena.Contains("\t"))
            {
                subcadena = subcadena.Replace("\t", "");
            }
            return subcadena;
        }

        /// <summary>
        /// Método para verficar comillas simples de una letra
        /// </summary>
        /// <param name="cadenaAnalizada">Cadena de longitud de 3 caracteres</param>
        /// <returns></returns>
        private char VeficadorComillasLetra(string cadenaAnalizada, ref bool esCorrecto)
        {
            var caracter = '¬';
            esCorrecto = false;

            if (cadenaAnalizada[0] == '\'' && cadenaAnalizada[2] == '\'')
            {
                esCorrecto = true;
                return cadenaAnalizada[1];
            }

            return caracter;
        }

        /// <summary>
        /// Método que verifica la existencia de un signo igual en la línea que se esté analizando
        /// </summary>
        /// <param name="linea">Línea que se desea analizar</param>
        /// <param name="subCadenaIzq">Parte izquierda, contenido de la línea antes del signo igual</param>
        /// <param name="subCadenaDrch">Parte derecha del signo igual</param>
        /// <returns>true = tiene signo igual
        /// false = No posee signo igual
        /// </returns>
        private bool VerificadorIgual(string linea, ref string subCadenaIzq, ref string subCadenaDrch)
        {
            if (linea.Contains('='))
            {
                var posicion = linea.IndexOf('=');

                subCadenaIzq = linea.Remove(0, posicion);
                subCadenaDrch = linea.Remove(posicion+1, (linea.Length-posicion));

                return true;
            }

            return false;
        }


        //--------------------------LECTURA VERIFICACIÓN GENERAL DEL ARCHIVO----------------------------------------

        /// <summary>
        /// Método general de verificación del archivo
        /// </summary>
        /// <param name="rutaArchivo"></param>
        /// <param name="advertencia">Cadena que contiene el mensaje que se le mostrará al usuario final del estado del archivo</param>
        public bool Verificar(string rutaArchivo, ref string advertencia)
        {
            using(var file = new FileStream(rutaArchivo,FileMode.Open))
            {
                using (var reader = new StreamReader(file, Encoding.UTF8))
                {
                    Contenido = reader.ReadToEnd();

                    if (Contenido == string.Empty)
                    {
                        advertencia = Advertencia.AdvertenciasGenerales[1];
                        return false;
                    }
                }
            }

            if (Contenido.ToUpper().Contains("SETS") )
            {
                if (Contenido.ToUpper().Contains("TOKENS"))
                {
                    if (Contenido.ToUpper().Contains("ACTIONS"))
                    {
                        if (Contenido.ToUpper().Contains("ERROR"))
                        {
                            
                            if (AnalizarSets(Contenido.Substring(Contenido.ToUpper().IndexOf("SETS"), (Contenido.ToUpper().IndexOf("TOKENS") - Contenido.ToUpper().IndexOf("SETS")))) == false)
                            {
                                //Aquí se le quita la parte de SETS a todo el texto
                                Contenido = Contenido.Remove(Contenido.ToUpper().IndexOf("SETS"), (Contenido.ToUpper().IndexOf("TOKENS") - Contenido.ToUpper().IndexOf("SETS")));

                            }


                        }
                        else
                        {
                            advertencia = Advertencia.AdvertenciasGenerales[2] + "la sección \"ERROR\"";
                            return false;
                        }
                    }
                    else
                    {
                        advertencia = Advertencia.AdvertenciasGenerales[2] + "ACTIONS";
                        return false;
                    }
                }
                else
                {
                    advertencia = Advertencia.AdvertenciasGenerales[2] + "TOKENS";
                    return false;
                }
            }
            else
            {
                advertencia = Advertencia.AdvertenciasGenerales[2] + "SETS";
                return false;
            }

            advertencia = Advertencia.AdvertenciasGenerales[0];
            return true;
        }

        //----------------------------------------SETS--------------------------------------------------------------

        private bool AnalizarSets(string contenido)
        {
            var lineas = contenido.Split('\n').ToList();

            foreach (var linea in lineas)
            {
                
            }

            return false;
        }


        //----------------------------------------ERROR-------------------------------------------------------------

        /// <summary>
        /// Método que analiza la parte de ERROR del archivo
        /// </summary>
        /// <param name="linea"></param>
        /// <returns>Asigna el valor de ERROR</returns>
        private bool AnalizadorApartadoError(string linea)
        {
            var subCadenaIzq = "";
            var subCadenaDrch = "";

            if (VerificadorIgual(linea, ref subCadenaIzq, ref subCadenaDrch))
            {
                subCadenaIzq = RemoverEspacios(subCadenaIzq);
                subCadenaDrch = RemoverEspacios(subCadenaDrch);

                if (subCadenaIzq != "" && subCadenaIzq.ToUpper() == "ERROR")
                {
                    if (subCadenaDrch != "")
                    {
                        var numeroError = 0;
                        int.TryParse(subCadenaDrch, out numeroError);

                        if (numeroError != 0)
                        {
                            Error = numeroError;
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
