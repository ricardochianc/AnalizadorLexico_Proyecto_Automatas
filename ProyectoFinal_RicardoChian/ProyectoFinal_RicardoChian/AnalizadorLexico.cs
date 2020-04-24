using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal_RicardoChian.Fase1;

namespace ProyectoFinal_RicardoChian
{
    public class AnalizadorLexico
    {
        public ManejoArchivo ManejadorArchivo { get; set; }
        private ExpresionPostfija Postfija { get; set; }
        public string Path { get; set; }

        public AnalizadorLexico()
        {
            ManejadorArchivo = new ManejoArchivo();
            Postfija = new ExpresionPostfija();
        }

        public bool VerificarArchivo(ref string advertencia)
        {
            if (ManejadorArchivo.Verificar(Path, ref advertencia))
            {
                return true;
            }

            return false;
        }

        public void GenerarExpresionRegular()
        {

        }
    }
}
