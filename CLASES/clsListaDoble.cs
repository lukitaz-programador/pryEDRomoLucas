using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDRomoL.CLASES
{
    class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo ultimo
        {
            get { return ult; }
            set { ult = value; }
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
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
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
        public void Agregar(clsNodo nuevo)
        {
            //verifica que la lista no este vacia, si lo esta el nuevo nodo se convierte en el pri
            if (pri == null)
            {
                pri = nuevo;
                ultimo = nuevo;
            }
            //si la lista no esta vacia, se compara el codigo del nuevo nodo con el codigo del primer nodo
            else
            {
                if (nuevo.Codigo <= pri.Codigo)
                {
                    nuevo.Siguiente = pri;
                    pri.Anterior = nuevo;
                    pri = nuevo;
                }
                //si el codigo del nuevo nodo es mayor que el codigo del primer nodo,
                //se recorre la lista hasta encontrar el lugar donde se debe insertar el nuevo nodo
                else
                {
                    if (nuevo.Codigo <= pri.Codigo)
                    {
                        nuevo.Siguiente = pri;
                        pri.Anterior = nuevo;
                        pri = nuevo;
                    }
                    //se recorre la lista hasta encontrar el lugar donde se debe insertar el nuevo nodo
                    else 
                    {
                        if (nuevo.Codigo >= ultimo.Codigo)
                        {
                            ultimo.Siguiente = nuevo;
                            nuevo.Anterior = ultimo;
                            ultimo = nuevo;
                        }
                        else
                        {
                            clsNodo aux = pri;
                            clsNodo ant = null;
                            while (aux.Codigo > aux.Codigo)
                            {
                                ant = aux;
                                aux = aux.Siguiente;
                                //si se llega al final de la lista, se sale del ciclo
                                if (aux == null) break;
                            }
                            ant.Siguiente = nuevo;
                            nuevo.Anterior = ant;
                            nuevo.Siguiente = aux;
                            aux.Anterior = nuevo;
                        }
                    }
                }
            }
        }
    }
}
