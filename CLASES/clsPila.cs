using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoL
{
    internal class clsPila
    {

        private clsNodo pri;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (pri == null)
            {
                pri = nuevo;
            }
            else
            {
                nuevo.Siguiente = pri;
                pri = nuevo;
            }
        }

        public void Eliminar()
        {
            if (pri != null)
            {
                pri = pri.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = pri;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = pri;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + "-" + aux.Nombre + "-" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = pri;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo + "-" + aux.Nombre + "-" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(String NomArchi)
        {
            clsNodo aux = pri;
            StreamWriter AD = new StreamWriter(NomArchi, false, Encoding.UTF8);
            AD.WriteLine("Lista de personas");
            AD.WriteLine("Codigo;Nombre;Tramite");

            while(aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
