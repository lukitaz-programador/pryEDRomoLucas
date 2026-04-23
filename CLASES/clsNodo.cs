using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDRomoL
{
    internal class clsNodo
    {
        //Campos del nodo
        private Int32 Cod;
        private string Nom;
        private string Tra;
        private clsNodo Sig;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return Cod; }
            set { Cod = value; }
        }

        public string Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }
    }
}
