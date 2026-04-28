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
            if (Primero == null)
            {
                Primero = nuevo;
            }
            else
            {
                nuevo.Siguiente = Primero;
                Primero = nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();

            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + "-" + aux.Nombre + "-" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo + "-" + aux.Nombre + "-" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(String NomArchi)
        {
            clsNodo aux = Primero;
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
