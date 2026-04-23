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
        //campos de la clase 
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la calse 
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

        //  metodos de la clase

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

        public void Eliminar()
        {
            if (Primero != null) // Si la cola tiene nodos
            {
                if (Primero == Ultimo) // Caso A: Hay un solo nodo
                {
                    Primero = null;
                    Ultimo = null;
                }
                else // Caso B: Hay más de un nodo
                {
                    Primero = Primero.Siguiente; // El segundo pasa a ser el primero
                }
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
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " -" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();

            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        internal void Recorrer(string v)
        {
            throw new NotImplementedException();
        }
    }
}
