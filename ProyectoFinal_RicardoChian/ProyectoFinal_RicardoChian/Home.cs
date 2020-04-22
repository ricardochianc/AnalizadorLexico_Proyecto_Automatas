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

            if (Analizador.VerificarArchivo(ref mensaje))
            {
                //Mostrar MessageBox y cambiar pantalla
                MessageBox.Show(mensaje, "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Mostrar MessageBox y limpiar pantalla y volver al inicio
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lb_NombreArchivo.Text = string.Empty;
                btn_continuar.Hide();
            }
        }
    }
}
