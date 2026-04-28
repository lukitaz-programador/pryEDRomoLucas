using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoL.CLASES
{
    //la clase lista simple es una clase que contiene un nodo y un metodo para agregar, eliminar y recorrer la lista
    internal class clsListaSimple
    {
        //la clase nodo es una clase que contiene un codigo, un nombre, un tramite y un nodo siguiente
        private clsNodo pri;
        //la propiedad primero es una propiedad que devuelve el nodo primero de la lista
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
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
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
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

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo aux2 = Primero;
                while (aux.Codigo != Codigo)
                {
                    aux2 = aux;
                    aux = aux.Siguiente;
                }
                aux2.Siguiente = aux.Siguiente;
            }
        }

        public void Agregar(clsNodo nuevo)
        {
            //verifica que la lista no este vacia, si lo esta el nuevo nodo se convierte en el primero
            if (Primero == null)
            {
                Primero = nuevo;
            }
            //si la lista no esta vacia, se compara el codigo del nuevo nodo con el codigo del primer nodo
            else
            {
                if (nuevo.Codigo <= Primero.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero = nuevo;
                }
                //si el codigo del nuevo nodo es mayor que el codigo del primer nodo,
                //se recorre la lista hasta encontrar el lugar donde se debe insertar el nuevo nodo
                else
                { 
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    //se recorre la lista hasta encontrar el lugar donde se debe insertar el nuevo nodo
                    while (nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        //si se llega al final de la lista, se sale del ciclo
                        if (aux == null) break;
                    }
                    //si se llega al final de la lista, se inserta el nuevo nodo al final de la lista
                    nuevo.Siguiente = aux;
                    ant.Siguiente = nuevo;
                }
            }
        }
    }
}
