using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG02__LAB01_FICHEROS_LUIS_MOSQUITO.Clases
{
    internal class clsUsuario
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string mtdCadena(string codigo, string nombre, string apellidopaterno, string apellidomaterno)
        {
            return codigo + "|" + nombre + "|" + apellidopaterno + "|" + apellidomaterno;
        }


        //agregar los demas campos
    }
}
