using pryEDRomoL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryEDRomoL
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        public void Eliminar(clsNodo eliminar)
        {
            if (Primero == null)
            {
                Primero = eliminar;
                Ultimo = eliminar;

            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(string v)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", true, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");

            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                aux = aux.Siguiente;
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
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();

            while (aux != null)
            {
                combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }
    }
}
