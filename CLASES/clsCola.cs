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
            if (pri == null)
            {
                pri = nuevo;
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
            if (pri != null) // Si la cola tiene nodos
            {
                if (pri == Ultimo) // Caso A: Hay un solo nodo
                {
                    pri = null;
                    Ultimo = null;
                }
                else // Caso B: Hay más de un nodo
                {
                    pri = pri.Siguiente; // El segundo pasa a ser el pri
                }
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
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " -" + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = pri;
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
