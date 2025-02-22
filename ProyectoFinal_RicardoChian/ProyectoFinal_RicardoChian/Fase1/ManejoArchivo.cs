﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string RemoverTodosEspacios(string subcadena)
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

        private string RemoverEspaciosLaterales(string subcadena)
        {
            subcadena = subcadena.TrimStart();
            return subcadena.TrimEnd();
        }

        /// <summary>
        /// Método para verficar comillas simples de una letra
        /// </summary>
        /// <param name="cadenaAnalizada">Cadena de longitud de 3 caracteres</param>
        /// <returns></returns>
        private char VerificadorComillasLetra(string cadenaAnalizada, ref bool esCorrecto)
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
                var posicion = linea.IndexOf('=') + 1;

                subCadenaIzq = linea.Split('=')[0];

                subCadenaDrch = linea.Substring(posicion, (linea.Length - posicion));

                return true;
            }

            return false;
        }

        private int VerificadorChars(string linea, ref string subCadenaDrch, ref bool esCorrecto, ref string advertencia)
        {
            var aux = "";

            if (linea.Length == 7)
            {
                if (linea[0].ToString().ToUpperInvariant() == "C")
                {
                    Columna++;

                    if (linea[1].ToString().ToUpperInvariant() == "H")
                    {
                        Columna++;

                        if (linea[2].ToString().ToUpperInvariant() == "R")
                        {
                            Columna++;

                            if (linea[3].ToString().ToUpperInvariant() == "(")
                            {
                                Columna++;

                                if (char.IsNumber(linea[4]))
                                {
                                    Columna++;
                                    aux += linea[4];

                                    if (char.IsNumber(linea[5]))
                                    {
                                        Columna++;
                                        aux += linea[5];

                                        if (linea[6].ToString().ToUpperInvariant() == ")")
                                        {
                                            Columna++;
                                            esCorrecto = true;
                                            subCadenaDrch = subCadenaDrch.Remove(0, 7);
                                            return int.Parse(aux);
                                        }
                                        else
                                        {
                                            esCorrecto = false;
                                            advertencia = Advertencia.SetsAdvertencias[6];
                                        }
                                    }
                                    else
                                    {
                                        esCorrecto = false;
                                        advertencia = Advertencia.SetsAdvertencias[7];
                                    }
                                }
                                else
                                {
                                    esCorrecto = false;
                                    advertencia = Advertencia.SetsAdvertencias[7];
                                }
                            }
                            else
                            {
                                esCorrecto = false;
                                advertencia = Advertencia.SetsAdvertencias[5];
                            }
                        }
                        else
                        {
                            esCorrecto = false;
                            advertencia = Advertencia.SetsAdvertencias[4];
                        }
                    }
                    else
                    {
                        esCorrecto = false;
                        advertencia = Advertencia.SetsAdvertencias[4];
                    }
                }
            }
            else if (linea.Length == 8)
            {
                if (linea[0].ToString().ToUpperInvariant() == "C")
                {
                    Columna++;

                    if (linea[1].ToString().ToUpperInvariant() == "H")
                    {
                        Columna++;

                        if (linea[2].ToString().ToUpperInvariant() == "R")
                        {
                            Columna++;

                            if (linea[3].ToString().ToUpperInvariant() == "(")
                            {
                                Columna++;

                                if (char.IsNumber(linea[4]))
                                {
                                    Columna++;
                                    aux += linea[4];

                                    if (char.IsNumber(linea[5]))
                                    {
                                        Columna++;
                                        aux += linea[5];

                                        if (char.IsNumber(linea[6]))
                                        {
                                            Columna++;
                                            aux += linea[6];

                                            if (linea[7].ToString().ToUpperInvariant() == ")")
                                            {
                                                Columna++;
                                                esCorrecto = true;
                                                subCadenaDrch = subCadenaDrch.Remove(0, 8);
                                                return int.Parse(aux);
                                            }
                                            else
                                            {
                                                esCorrecto = false;
                                                advertencia = Advertencia.SetsAdvertencias[6];
                                            }
                                        }
                                        else
                                        {
                                            esCorrecto = false;
                                            advertencia = Advertencia.SetsAdvertencias[7];
                                        }
                                    }
                                    else
                                    {
                                        esCorrecto = false;
                                        advertencia = Advertencia.SetsAdvertencias[7];
                                    }
                                }
                                else
                                {
                                    esCorrecto = false;
                                    advertencia = Advertencia.SetsAdvertencias[7];
                                }
                            }
                            else
                            {
                                esCorrecto = false;
                                advertencia = Advertencia.SetsAdvertencias[5];
                            }
                        }
                        else
                        {
                            esCorrecto = false;
                            advertencia = Advertencia.SetsAdvertencias[4];
                        }
                    }
                    else
                    {
                        esCorrecto = false;
                        advertencia = Advertencia.SetsAdvertencias[4];
                    }
                }
                else
                {
                    esCorrecto = false;
                    advertencia = Advertencia.SetsAdvertencias[4];
                }
            }

            return -1;
        }

        private bool VerificadorTokens(string subcadenaIzquierda, ref string advertencia, ref int numeroToken)
        {
            var EsCorrecto = false;

            Columna = subcadenaIzquierda.Length - subcadenaIzquierda.TrimStart().Length;

            subcadenaIzquierda = subcadenaIzquierda.TrimStart();
            subcadenaIzquierda = subcadenaIzquierda.TrimEnd();

            if (subcadenaIzquierda.Substring(0, 5).ToUpperInvariant() == "TOKEN")
            {
                if (subcadenaIzquierda.Substring(0, 6).ToUpperInvariant() == "TOKEN ")
                {
                    subcadenaIzquierda = subcadenaIzquierda.Remove(0, 6);

                    subcadenaIzquierda = subcadenaIzquierda.TrimStart();
                    subcadenaIzquierda = subcadenaIzquierda.TrimEnd();

                    if (int.TryParse(subcadenaIzquierda, out numeroToken))
                    {
                        EsCorrecto = true;
                    }
                }
                else
                {
                    //debe de existir al menos un espacio entre la palabra token y el número de TOKEN
                    advertencia = Advertencia.tokensAdvertencias[4];
                    Columna += 5;
                }
            }
            else
            {
                //La definición de la palabra TOKEN está mala
                advertencia = Advertencia.tokensAdvertencias[3];
            }



            return EsCorrecto;
        }


        /// <summary>
        /// Verifica existencia de tokens en los SETS
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private bool VerificarExistencia(string token)
        {
            var cont = 0;

            foreach (var ListaSets in Sets)
            {
                if (ListaSets.Value != null)
                {
                    if (ListaSets.Key == token || ListaSets.Value.Contains(token))
                    {
                        return true;
                    }
                }

                cont++;
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
            using (var file = new FileStream(rutaArchivo, FileMode.Open))
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

            if (Contenido.ToUpper().Contains("SETS"))
            {
                if (Contenido.ToUpper().Contains("TOKENS"))
                {
                    if (Contenido.ToUpper().Contains("ACTIONS"))
                    {
                        if (Contenido.ToUpper().Contains("ERROR"))
                        {

                            if (AnalizarSets(Contenido.Substring(Contenido.ToUpper().IndexOf("SETS"), (Contenido.ToUpper().IndexOf("TOKENS") - Contenido.ToUpper().IndexOf("SETS"))), ref advertencia))
                            {
                                //Aquí se le quita la parte de SETS a todo el texto
                                Contenido = Contenido.Remove(Contenido.ToUpper().IndexOf("SETS"), (Contenido.ToUpper().IndexOf("TOKENS") - Contenido.ToUpper().IndexOf("SETS")));

                                //Aquí empieza el análisis de los TOKENS
                                if (AnalizarTokens(Contenido.Substring(Contenido.ToUpper().IndexOf("TOKENS"), (Contenido.ToUpper().IndexOf("ACTIONS") - Contenido.ToUpper().IndexOf("TOKENS"))), ref advertencia))
                                {
                                    //Se quita la parte de TOKENS y se procede a analizar los ACTIONS
                                    Contenido = Contenido.Remove(Contenido.ToUpper().IndexOf("TOKENS"), (Contenido.ToUpper().IndexOf("ACTIONS") - Contenido.ToUpper().IndexOf("TOKENS")));

                                    if (AnalizarActions(Contenido.Substring(Contenido.ToUpper().IndexOf("ACTIONS"), (Contenido.ToUpper().IndexOf("ERROR") - Contenido.ToUpper().IndexOf("ACTIONS"))), ref advertencia))
                                    {
                                        Contenido = Contenido.Remove(Contenido.ToUpper().IndexOf("ACTIONS"), (Contenido.ToUpper().IndexOf("ERROR") - Contenido.ToUpper().IndexOf("ACTIONS")));

                                        if(AnalizadorApartadoError(Contenido))
                                        {
                                            advertencia = Advertencia.AdvertenciasGenerales[0];
                                            return true;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }

                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
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

        private bool AnalizarSets(string contenido, ref string advertencia)
        {
            var lineas = contenido.Split('\n').ToList();

            if (Fila == -1)
            {
                Fila = 0;
            }

            lineas.RemoveAt(lineas.Count - 1);

            foreach (var linea in lineas)
            {
                var lineaAux = string.Empty;
                Fila++;
                Columna = 0;

                //Si está vacío verificar que la primer línea de la sección de SETS sea la palabra definidora de la sección (SETES)
                if (Sets.Count == 0)
                {
                    lineaAux = RemoverTodosEspacios(linea.Trim('\r'));

                    if (lineaAux.ToUpperInvariant() == "SETS")
                    {
                        Sets.Add(lineaAux, null);
                    }
                }
                else
                {
                    lineaAux = RemoverEspaciosLaterales(linea).Trim('\r');

                    if (lineaAux != "")
                    {
                        var subIzq = string.Empty;
                        var subDrch = string.Empty;

                        if (lineaAux.Contains("=") && RemoverEspaciosLaterales(lineaAux) != "")
                        {
                            VerificadorIgual(linea, ref subIzq, ref subDrch);

                            //si tiene espacio es un error en el nombre del SET
                            if (RemoverEspaciosLaterales(subIzq).Contains(" "))
                            {
                                var auxIzq = subIzq.TrimStart();

                                Columna = subIzq.Length - auxIzq.Length;
                                Columna += RemoverEspaciosLaterales(subIzq).IndexOf(' ');

                                advertencia = Advertencia.SetsAdvertencias[0];
                                return false;
                            }
                            else
                            {
                                var setAnalizado = RemoverEspaciosLaterales(subIzq); //Ejemplo LETRA, DIGITO, CHARSET

                                if (Sets.ContainsKey(setAnalizado))
                                {
                                    advertencia = Advertencia.SetsAdvertencias[8];
                                    Columna = -1;
                                    return false;
                                }

                                Sets.Add(setAnalizado, new List<string>());

                                Columna += linea.IndexOf('=') + 1;
                                Columna += subDrch.Length - subDrch.TrimStart().Length;

                                subDrch = RemoverEspaciosLaterales(subDrch);

                                //Acá se empieza a anlizar la definición de los SETS-------------------------------------------------------------------------

                                while (subDrch.Length >= 3)
                                {
                                    if (subDrch[0] != '\'' && subDrch[0].ToString().ToUpperInvariant() != "C" && subDrch[0] != '+' && subDrch[0] != '.')
                                    {
                                        //Es porque hubo un error
                                        advertencia = Advertencia.SetsAdvertencias[2];
                                        return false;
                                    }
                                    else if (subDrch[0] == '\'')
                                    {
                                        var esCorrecto = false;
                                        var caracter = VerificadorComillasLetra(subDrch.Substring(0, 3), ref esCorrecto);

                                        if (esCorrecto)
                                        {
                                            Sets[setAnalizado].Add(caracter.ToString());
                                            subDrch = subDrch.Remove(0, 3);
                                            Columna += 3;
                                        }
                                        else
                                        {
                                            //Error de comillas
                                            advertencia = Advertencia.SetsAdvertencias[9];
                                            Columna++;
                                            return esCorrecto;
                                        }
                                    }
                                    else if (subDrch[0] == '.')
                                    {
                                        if (subDrch[0 + 1] != '.')
                                        {
                                            //Error de puntos suspensivos de rango
                                            Columna++;
                                            advertencia = Advertencia.SetsAdvertencias[3];
                                            return false;
                                        }
                                        else
                                        {

                                            Columna += 2;
                                            Sets[setAnalizado].Add("..");
                                            subDrch = subDrch.Remove(0, 2);
                                        }
                                    }
                                    else if (subDrch[0] == '+')
                                    {
                                        Columna++;
                                        subDrch = subDrch.Remove(0, 1);
                                    }
                                    else if (subDrch[0].ToString().ToUpperInvariant() == "C")
                                    {
                                        var numRango = -1;
                                        var esCorrecto = false;

                                        if (subDrch.Contains(")"))
                                        {
                                            var aux = subDrch.Substring(0, subDrch.IndexOf(')') + 1);

                                            if (aux.Length == 7 || aux.Length == 8)
                                            {
                                                numRango = VerificadorChars(aux, ref subDrch, ref esCorrecto, ref advertencia);

                                                if (esCorrecto != true)
                                                {
                                                    return esCorrecto;
                                                }

                                                Sets[setAnalizado].Add(char.ConvertFromUtf32(numRango));
                                            }
                                            else
                                            {
                                                advertencia = Advertencia.SetsAdvertencias[4];
                                                Columna = -1;
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            advertencia = Advertencia.SetsAdvertencias[6];
                                            Columna = -1;
                                            return false;
                                        }
                                    }
                                }
                                //Se crean RANGOS------------------------------------------------------------------------------------------------------------
                                if (Sets[setAnalizado].Contains(".."))
                                {
                                    while (Sets[setAnalizado].Contains(".."))
                                    {
                                        var caracterInicio = char.Parse(Sets[setAnalizado][Sets[setAnalizado].IndexOf("..") - 1]);
                                        var caracterFinal = char.Parse(Sets[setAnalizado][Sets[setAnalizado].IndexOf("..") + 1]);

                                        if (char.IsNumber(caracterInicio) && char.IsNumber(caracterFinal))
                                        {
                                            if (caracterInicio < caracterFinal)
                                            {
                                                for (int i = caracterInicio + 1; i < caracterFinal; i++)
                                                {
                                                    Sets[setAnalizado].Add(char.ConvertFromUtf32(i));
                                                }
                                            }
                                            else
                                            {
                                                for (int i = caracterFinal + 1; i < caracterInicio; i++)
                                                {
                                                    Sets[setAnalizado].Add(char.ConvertFromUtf32(i));
                                                }
                                            }
                                        }
                                        else
                                        {
                                            var inicio = Convert.ToInt32(caracterInicio);
                                            var final = Convert.ToInt32(caracterFinal);

                                            if (inicio < final)
                                            {
                                                for (int i = inicio + 1; i < final; i++)
                                                {
                                                    Sets[setAnalizado].Add(char.ConvertFromUtf32(i));
                                                }
                                            }
                                            else
                                            {
                                                for (int i = final + 1; i < inicio; i++)
                                                {
                                                    Sets[setAnalizado].Add(char.ConvertFromUtf32(i));
                                                }
                                            }
                                        }

                                        Sets[setAnalizado].RemoveAt(Sets[setAnalizado].IndexOf(".."));
                                    }
                                }
                            }
                        }
                        else //ERROR EN LA LÍNEA PORQUE NO CONTIENE UN SIGNO IGUAL
                        {
                            advertencia = Advertencia.SetsAdvertencias[1];
                            Columna = -1;
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        //----------------------------------------TOKENS------------------------------------------------------------
        private bool AnalizarTokens(string contenido, ref string advertencia)
        {

            var lineas = contenido.Split('\n').ToList();

            lineas.RemoveAt(lineas.Count - 1);

            foreach (var linea in lineas)
            {
                var lineaAux = string.Empty;
                Fila++;
                Columna = 0;

                if (Tokens.Count == 0)
                {
                    lineaAux = RemoverEspaciosLaterales(linea.Trim('\r'));

                    if (lineaAux.ToUpperInvariant() == "TOKENS")
                    {
                        Tokens.Add(lineaAux, new List<string>());
                    }
                }
                else
                {
                    lineaAux = RemoverEspaciosLaterales(linea).Trim('\r');

                    if (lineaAux != "")
                    {
                        var subIzq = string.Empty;
                        var subDrch = string.Empty;

                        if (lineaAux.Contains("=") && RemoverEspaciosLaterales(lineaAux) != "")
                        {
                            VerificadorIgual(linea, ref subIzq, ref subDrch); //Aquí se devuelven las cadenas izquierda y derecha del token

                            var tokenAnalizado = -1;

                            if (VerificadorTokens(subIzq, ref advertencia, ref tokenAnalizado))
                            {
                                if (Tokens.ContainsKey(tokenAnalizado.ToString()))
                                {
                                    advertencia = Advertencia.tokensAdvertencias[5];
                                    Columna = -1;
                                    return false;
                                }

                                Tokens.Add(tokenAnalizado.ToString(), new List<string>());

                                Columna = linea.IndexOf('=') + 1;
                                Columna += subDrch.Length - subDrch.TrimStart().Length;

                                subDrch = RemoverEspaciosLaterales(subDrch);

                                var palabraToken = string.Empty;

                                //ACÁ SE EMPIEZA A ANALIZAR LOS VALORES DEL TOKEN
                                while (subDrch.Length > 0)
                                {
                                    //SI EL CARACTER ANALIZADO ES UNA COMILLA
                                    if (subDrch[0] == '\'') //Si el primer caracter analizado es una comilla simple...
                                    {
                                        var esCorrecto = false;
                                        var caracter = VerificadorComillasLetra(subDrch.Substring(0, 3), ref esCorrecto);

                                        if (esCorrecto)
                                        {
                                            Tokens[tokenAnalizado.ToString()].Add(caracter.ToString());
                                            subDrch = subDrch.Remove(0, 3);
                                            Columna += 3;
                                        }
                                        else
                                        {
                                            //error de comillas
                                            advertencia = Advertencia.tokensAdvertencias[8];
                                            Columna++;
                                            return esCorrecto;
                                        }
                                    }
                                    //SI ES UN ESPACIO EN BLANCO Y NO HAY UNA PALABRA PENDIENTE DE FORMAR...
                                    else if (subDrch[0] == ' ' && palabraToken == string.Empty)
                                    {
                                        subDrch = subDrch.Remove(0, 1);
                                        Columna++;
                                    }
                                    else if (subDrch[0] == ' ' && palabraToken != string.Empty)
                                    {
                                        Columna++;

                                        if (!VerificarExistencia(palabraToken))
                                        {
                                            //ERROR DE QUE EL TOKEN ES INVÁLIDO PORQUE NO EXISTE UNA DEFINICIÓN DE SET
                                            advertencia = Advertencia.tokensAdvertencias[9];
                                            return false;

                                        }
                                        else
                                        {
                                            //Guardarlo en la lista de los TOKENS, columna++ y remover ese caracter
                                            Tokens[tokenAnalizado.ToString()].Add(palabraToken);
                                            palabraToken = string.Empty;
                                            subDrch = subDrch.Remove(0, 1);

                                        }
                                    }
                                    //AHORITA VER SI SON SIMBOLOS DE OPERACION GUARDARLOS DIRECTAMENTE EN LA LISTA DE TOKENS
                                    else if (subDrch[0] == '|' || subDrch[0] == '.' || subDrch[0] == '(' || subDrch[0] == ')')
                                    {
                                        Columna++;
                                        Tokens[tokenAnalizado.ToString()].Add("\'" + subDrch[0].ToString());
                                        subDrch = subDrch.Remove(0, 1);
                                    }
                                    //SI ES * O +, CONCATÁRSELO AL ÚLTIMO GUARDADO
                                    else if (subDrch[0] == '*' || subDrch[0] == '+')
                                    {
                                        Columna++;
                                        Tokens[tokenAnalizado.ToString()][Tokens[tokenAnalizado.ToString()].Count - 1] += subDrch[0];
                                        subDrch = subDrch.Remove(0, 1);
                                    }
                                    //SI ES OTRO CARACTER IR CONCATENÁNDOLO A LA palabraToken
                                    else if (subDrch[0] != '\'' && subDrch[0] != ' ')
                                    {
                                        Columna++;
                                        palabraToken += subDrch[0];
                                        subDrch = subDrch.Remove(0, 1);
                                    }
                                }

                            }
                            else
                            {
                                return false;
                            }
                        }
                        else //ERROR EN LA LÍNEA, PORQUE NO CONTIENE UN SIGNO IGUAL
                        {
                            advertencia = Advertencia.tokensAdvertencias[1];
                            Columna = -1;
                            return false;
                        }
                    }
                }
            }


            return true;
        }

        //----------------------------------------ACTIONS----------------------------------------------------------
        private bool AnalizarActions(string contenido, ref string advertencia)
        {
            var lineas = contenido.Split('\n').ToList();

            lineas.RemoveAt(lineas.Count - 1);

            var actionAnalizado = string.Empty;
            var metodoEnProceso = false;
            var corcheteEncontrado = false;

            foreach (var linea in lineas)
            {
                var lineasAux = string.Empty;
                
                Fila++;
                Columna = 0;

                if (RemoverTodosEspacios(linea).Trim('\r') != "")
                {
                    if (Actions.Count == 0) //Se ingresa la primer palabra que separa la sección ACTIONS
                    {
                        lineasAux = RemoverEspaciosLaterales(linea.Trim('\r'));

                        if (lineasAux.ToUpperInvariant() == "ACTIONS")
                        {
                            Actions.Add(lineasAux, new List<string>());
                        }
                    }
                    else if (metodoEnProceso)
                    {
                        if (RemoverEspaciosLaterales(linea) != "")
                        {
                            var subIzq = string.Empty;
                            var subDrch = string.Empty;

                            if (Actions[actionAnalizado].Count == 0 && corcheteEncontrado == false)
                            {
                                lineasAux = RemoverEspaciosLaterales(linea);

                                if (lineasAux != "{")
                                {
                                    advertencia = Advertencia.ActionsAdvertencias[2];
                                    return false;
                                }

                                corcheteEncontrado = true;

                            }
                            else if (linea.Contains('='))
                            {
                                VerificadorIgual(linea, ref subIzq, ref subDrch);

                                subIzq = RemoverTodosEspacios(subIzq);
                                subDrch = RemoverTodosEspacios(subDrch).TrimEnd('\r');

                                var num = 0;

                                if (!int.TryParse(subIzq, out num))
                                {
                                    advertencia = Advertencia.ActionsAdvertencias[4];
                                    Columna = -1;
                                    return false;
                                }

                                if (!subDrch.Contains('\''))
                                {
                                    advertencia = Advertencia.ActionsAdvertencias[5];
                                    Columna = -1;
                                    return false;
                                }

                                if (Tokens.ContainsKey(num.ToString()))
                                {
                                    advertencia = Advertencia.ActionsAdvertencias[3];
                                    Columna = -1;
                                    return false;
                                }

                                Actions[actionAnalizado].Add(num + "|" + subDrch);
                            }
                            else if (linea.Contains('}'))
                            {
                                metodoEnProceso = false;
                            }
                        }
                    }
                    else
                    {
                        lineasAux = linea.TrimStart();
                        Columna = linea.Length - lineasAux.Length;

                        lineasAux = RemoverEspaciosLaterales(lineasAux.TrimEnd('\r'));

                        if (lineasAux.Contains(' '))
                        {
                            advertencia = Advertencia.ActionsAdvertencias[0];
                            Columna += lineasAux.IndexOf(' ');
                            return false;

                        }
                        else if (lineasAux.Contains("()"))
                        {

                            actionAnalizado = lineasAux;
                            Actions.Add(actionAnalizado, new List<string>());
                            metodoEnProceso = true;
                        }
                        else
                        {
                            //Error
                            advertencia = Advertencia.ActionsAdvertencias[1];
                            Columna = -1;
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        //----------------------------------------ERROR-------------------------------------------------------------

        /// <summary>
        /// Método que analiza la parte de ERROR del archivo
        /// </summary>
        /// <param name="linea"></param>
        /// <returns>Asigna el valor de ERROR</returns>
        private bool AnalizadorApartadoError(string contenido)
        {
            var linea = contenido.Split('\n')[0].Trim('\r');

            var subCadenaIzq = "";
            var subCadenaDrch = "";

            if (VerificadorIgual(linea, ref subCadenaIzq, ref subCadenaDrch))
            {
                subCadenaIzq = RemoverTodosEspacios(subCadenaIzq);
                subCadenaDrch = RemoverTodosEspacios(subCadenaDrch);

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