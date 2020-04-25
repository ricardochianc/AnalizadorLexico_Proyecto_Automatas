using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_RicardoChian.Fase1;
using ProyectoFinal_RicardoChian.Fase1.Automata;

namespace ProyectoFinal_RicardoChian
{
    public class AnalizadorLexico
    {
        public string Path { get; set; }
        public Dictionary<string, string> DiccionarioSustitucion { get; set; }
        public string ExpresionRegular { get; set; }


        public ManejoArchivo ManejadorArchivo { get; set; }
        private ExpresionPostfija ConvertidorPostfija { get; set; }
        public ArbolExpresiones Arbol { get; set; }
        
        public AnalizadorLexico()
        {
            ManejadorArchivo = new ManejoArchivo();
            ConvertidorPostfija = new ExpresionPostfija();
            DiccionarioSustitucion = new Dictionary<string, string>();
            Arbol = new ArbolExpresiones();
        }

        public bool VerificarArchivo(ref string advertencia)
        {
            if (ManejadorArchivo.Verificar(Path, ref advertencia))
            {
                return true;
            }

            return false;
        }

        public bool GenerarAutomata(ref string advertencia)
        {
            try
            {
                GenerarExpresionRegular();
                ConvertidorPostfija.ConvertirPostfijo(ExpresionRegular);

                var recorrido = "";
                Arbol.CrearArbol(ConvertidorPostfija.Postfija);
                Arbol.PostOrdenOperaciones(Arbol.Raiz, ref recorrido);
                Arbol.GenerarTransiciones();

                return true;
            }
            catch (Exception e)
            {
                advertencia = e.Message;
                return false;
            }
        }

        //------------------Privados que se usan para genera AUTÓMATA----------------------------
        private void GenerarExpresionRegular()
        {
            var especiales = new List<string>();
            especiales.Add("~");
            especiales.Add("¬");
            especiales.Add("^");
            especiales.Add("¨");

            foreach (var Token in ManejadorArchivo.Tokens)
            {
                var token = "";

                if (Token.Key != "TOKENS")
                {
                    foreach (var item in Token.Value)
                    {
                        if (token.Length - 1 >= 0)
                        {
                            if (token[token.Length - 1] != '(' && token[token.Length - 1] != ')' && token[token.Length - 1] != '|'
                                && item != "\')" && item != "\'|" && item != "\')*")
                            {
                                token += ".";
                            }
                        }


                        if (item.Contains("*"))
                        {
                            var aux = item.Substring(0, item.Length - 1);

                            

                            if (ManejadorArchivo.Sets.ContainsKey(aux))
                            {
                                if (!DiccionarioSustitucion.ContainsValue(aux))
                                {
                                    DiccionarioSustitucion.Add(especiales[0], aux);
                                    especiales.RemoveAt(0);

                                    foreach (var item2 in DiccionarioSustitucion)
                                    {
                                        if (item2.Value == aux)
                                        {
                                            token += item2.Key + "*";
                                        }
                                    }
                                }
                                else
                                {
                                    foreach (var item2 in DiccionarioSustitucion)
                                    {
                                        if (item2.Value == aux)
                                        {
                                            token += item2.Key + "*";
                                        }
                                    }
                                }

                            }
                            else
                            {
                                if (item.Contains('\'')) //si tiene comilla simple no se le agrega concateniacion, 
                                {
                                    token+= item.Trim('\'');
                                }
                                else
                                {
                                    token += item;
                                }
                            }
                        }
                        else if(ManejadorArchivo.Sets.ContainsKey(item))
                        {
                            if (!DiccionarioSustitucion.ContainsValue(item))
                            {
                                DiccionarioSustitucion.Add(especiales[0], item);
                                especiales.RemoveAt(0);

                                foreach (var item2 in DiccionarioSustitucion)
                                {
                                    if (item2.Value == item)
                                    {
                                        token += item2.Key;
                                    }
                                }
                            }
                            else
                            {
                                foreach (var item2 in DiccionarioSustitucion)
                                {
                                    if (item2.Value == item)
                                    {
                                        token += item2.Key;
                                    }
                                }
                            }
                        }
                        else if (item.Contains('\'')) //si tiene comilla simple no se le agrega concateniacion, 
                        {
                            token += item.Trim('\'');
                        }
                        else
                        {
                            token += item;
                        }
                    }

                    ExpresionRegular += token + "|";
                }
            }

            ExpresionRegular = ExpresionRegular.TrimEnd('|');
        }
    }
}
