using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_RicardoChian
{
    public partial class Home : Form
    {
        static AnalizadorLexico Analizador = new AnalizadorLexico();

        public Home()
        {
            InitializeComponent();
        }

        private void btn_CargarArchivo_Click(object sender, EventArgs e)
        {
            Analizador = null;
            Analizador = new AnalizadorLexico();
            openFileDialog_archivo.ShowDialog();
        }

        private void openFileDialog_archivo_FileOk(object sender, CancelEventArgs e)
        {
            lb_NombreArchivo.Text = openFileDialog_archivo.SafeFileName;
            Analizador.Path = openFileDialog_archivo.FileName;
            btn_continuar.Show();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            var mensaje = string.Empty;

            try
            {
                if (Analizador.VerificarArchivo(ref mensaje))
                {
                    //Mostrar MessageBox y cambiar pantalla
                    MessageBox.Show(mensaje, "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gbx_CargarArchivo.Hide();

                    try
                    {
                        if (Analizador.GenerarAutomata(ref mensaje))
                        {
                            MessageBox.Show("Creación correcta del autómata", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            gbx_ResultadoAnalisis.Show();

                            lb_ExpresionRegular.Text = Analizador.ExpresionRegular;

                            dgv_Sets.ColumnCount = 1;
                            dgv_Sets.RowCount = Analizador.ManejadorArchivo.Sets.Count;
                            dgv_Sets.ForeColor = Color.Black;

                            var fila = 0;

                            foreach (var item in Analizador.ManejadorArchivo.Sets)
                            {
                                if (item.Key != "SETS")
                                {
                                    dgv_Sets[0, fila].Value = item.Key;
                                    fila++;
                                }
                            }

                            fila = 0;

                            dgtv_Tokens.ColumnCount = 1;
                            dgtv_Tokens.RowCount = Analizador.ManejadorArchivo.Sets.Count + 1;
                            dgtv_Tokens.ForeColor = Color.Black;

                            foreach (var item in Analizador.ManejadorArchivo.Tokens)
                            {
                                if (item.Key != "TOKENS")
                                {
                                    dgtv_Tokens[0, fila].Value = "TOKEN " + item.Key;
                                    fila++;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gbx_CargarArchivo.Show();
                        gbx_ResultadoAnalisis.Hide();
                    }

                }
                else
                {
                    if (Analizador.ManejadorArchivo.Fila != -1 && Analizador.ManejadorArchivo.Columna != -1)
                    {
                        //Mostrar MessageBox y limpiar pantalla y volver al inicio
                        MessageBox.Show(mensaje + "\nFila: " + Analizador.ManejadorArchivo.Fila + "\nColumna: " + Analizador.ManejadorArchivo.Columna, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lb_NombreArchivo.Text = string.Empty;
                        btn_continuar.Hide();
                    }
                    else if (Analizador.ManejadorArchivo.Fila == -1)
                    {
                        //Mostrar MessageBox y limpiar pantalla y volver al inicio
                        MessageBox.Show(mensaje + "\nFila: No determinada" + "\nColumna: " + Analizador.ManejadorArchivo.Columna, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lb_NombreArchivo.Text = string.Empty;
                        btn_continuar.Hide();
                    }
                    else if (Analizador.ManejadorArchivo.Columna == -1)
                    {
                        //Mostrar MessageBox y limpiar pantalla y volver al inicio
                        MessageBox.Show(mensaje + "\nFila: " + Analizador.ManejadorArchivo.Fila + "\nColumna: No determinada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lb_NombreArchivo.Text = string.Empty;
                        btn_continuar.Hide();
                    }
                }
            }
            catch (Exception exception)
            {
                //Mostrar MessageBox y limpiar pantalla y volver al inicio
                MessageBox.Show(exception.Message + "; " + exception.Source + "\nFila: No determinada" + "\nColumna: No determinada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_NombreArchivo.Text = string.Empty;
                btn_continuar.Hide();
            }

            
        }

        private void btn_continuarAutomata_Click(object sender, EventArgs e)
        {
            gbx_ResultadoAnalisis.Hide();
            gbx_Automata.Show();

            dgv_Follows.Columns.Add("Nodo hoja","Nodo");
            dgv_Follows.Columns.Add("Follows", "Follows");
            dgv_Follows.RowCount = Analizador.Arbol.Hojas.Count;
            dgv_Follows.ForeColor = Color.Black;

            var fila = 0;

            foreach (var hoja in Analizador.Arbol.Hojas)
            {
                dgv_Follows[0, fila].Value = hoja.NumNodo; 
                fila++;
            }

            fila = 0;

            foreach (var nodos in Analizador.Arbol.Hojas)
            {
                if (nodos.Follow != null)
                {
                    for (int i = 0; i < nodos.Follow.Count; i++)
                    {
                        dgv_Follows[1, fila].Value += nodos.Follow[i].NumNodo + "  ";
                    }
                }
                else
                {
                    dgv_Follows[1, fila].Value += "----";
                }
                fila ++;
            }

            //---------------------------TABLA DE TRANSICIONES-----------------------------------------

            dgtv_Transiciones.Columns.Add("Estados", "Estados");
            dgtv_Transiciones.ForeColor = Color.Black;
            
            foreach (var Key in Analizador.Arbol.TablaTransiciones.Keys)
            {
                if (Analizador.DiccionarioSustitucion.ContainsKey(Key))
                {
                    dgtv_Transiciones.Columns.Add(Analizador.DiccionarioSustitucion[Key], Analizador.DiccionarioSustitucion[Key]);
                }
                else
                {
                    dgtv_Transiciones.Columns.Add(Key, Key);
                }
            }

            dgtv_Transiciones.RowCount = Analizador.Arbol.Estados.Count;

            fila = 0;
            foreach (var estado in Analizador.Arbol.Estados)
            {
                if (fila == 0)
                {
                    dgtv_Transiciones[0, fila].Value += "> ";
                    dgtv_Transiciones[0, fila].Style.BackColor = Color.CornflowerBlue;
                    
                }

                if (estado.EsAceptacion)
                {
                    dgtv_Transiciones[0, fila].Value += "# " + estado.Nombre + "{ ";
                    dgtv_Transiciones[0, fila].Style.BackColor = Color.SpringGreen;
                }
                else
                {
                    dgtv_Transiciones[0, fila].Value += estado.Nombre + "{";
                }

                for (int i = 0; i < estado.ListaNodos.Count; i++)
                {
                    dgtv_Transiciones[0, fila].Value += estado.ListaNodos[i].NumNodo + "  ";
                }

                dgtv_Transiciones[0, fila].Value += " }";

                fila++;
            }

            for (int i = 1; i < Analizador.Arbol.TablaTransiciones.Count+1; i++)
            {
                for (int j = 0; j < Analizador.Arbol.Estados.Count; j++)
                {
                    if (!Analizador.Arbol.TablaTransiciones.ContainsKey(dgtv_Transiciones.Columns[i].HeaderText))
                    {
                        var llave = "";

                        foreach (var item in Analizador.DiccionarioSustitucion.Values)
                        {
                            foreach (var key in Analizador.DiccionarioSustitucion.Keys)
                            {
                                if (Analizador.DiccionarioSustitucion[key] == item)
                                {
                                    llave = key;
                                }
                                break;
                            }
                        }

                        if (Analizador.Arbol.TablaTransiciones[llave][j].Nombre == "-")
                        {
                            dgtv_Transiciones[i, j].Value += "-----";
                        }
                        else
                        {
                            dgtv_Transiciones[i, j].Value +=
                                Analizador.Arbol.TablaTransiciones[llave][j].Nombre + " (";

                            foreach (var itemNodo in Analizador.Arbol.TablaTransiciones[llave][j].ListaNodos)
                            {
                                dgtv_Transiciones[i, j].Value += itemNodo.NumNodo + "  ";
                            }

                            dgtv_Transiciones[i, j].Value += ")";
                        }
                    }
                    else
                    {
                        if (Analizador.Arbol.TablaTransiciones[dgtv_Transiciones.Columns[i].HeaderText][j].Nombre == "-")
                        {
                            dgtv_Transiciones[i, j].Value += "-----";
                        }
                        else
                        {
                            dgtv_Transiciones[i, j].Value +=
                                Analizador.Arbol.TablaTransiciones[dgtv_Transiciones.Columns[i].HeaderText][j].Nombre + " (";

                            foreach (var itemNodo in Analizador.Arbol.TablaTransiciones[
                                dgtv_Transiciones.Columns[i].HeaderText][j].ListaNodos)
                            {
                                dgtv_Transiciones[i, j].Value += itemNodo.NumNodo + "  ";
                            }

                            dgtv_Transiciones[i, j].Value += ")";
                        }
                    }
                }
            }
        }

        private void btn_GenerarArchivo_Click(object sender, EventArgs e)
        {

        }
    }
}