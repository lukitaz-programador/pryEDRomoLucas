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
    internal class clsListaDoble
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
                if (nuevo.Codigo < pri.Codigo)
                {
                    nuevo.Siguiente = Primero;
                    Primero.Anterior = nuevo;
                    Primero = nuevo;
                }
                else
                {
                    if (nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = nuevo;
                        nuevo.Anterior = Ultimo;
                        Ultimo = nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null) break;
                        }
                        nuevo.Siguiente = aux;
                        nuevo.Anterior = aux.Anterior;
                        aux.Anterior.Siguiente = nuevo;
                        aux.Anterior = nuevo;

                    }
                }
            }
        }
        public void Recorrer(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }

        public void RecorrerDes(DataGridView dgv)
        {
            clsNodo aux = Ultimo;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ListBox lst)
        {
            clsNodo aux = Primero;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDes(ListBox lst)
        {
            clsNodo aux = Ultimo;
            lst.Items.Clear();
            while (aux != null)
            {
                lst.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDes(ComboBox cmb)
        {
            clsNodo aux = Ultimo;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        public void Recorrer(string NomArchi)
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", true);
            while (aux != null)
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

        public void RecorrerDes(string NomArchi)
        {
            clsNodo aux = Ultimo;
            StreamWriter AD = new StreamWriter("ListaDoble.csv", true);
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Anterior;
            }
            AD.Close();
        }

        public void Eliminar(int Codigo)
        {
            if (Primero == null) return; // Lista vacía

            clsNodo Aux = Primero;

            // 1. Buscar el nodo a eliminar
            while (Aux != null && Aux.Codigo != Codigo)
            {
                Aux = Aux.Siguiente;
            }

            // Si no se encontró el código, salimos
            if (Aux == null) return;

            // 2. Si el nodo es el PRIMERO
            if (Aux == Primero)
            {
                Primero = Aux.Siguiente;
                if (Primero != null)
                    Primero.Anterior = null;
                else
                    Ultimo = null; // La lista quedó vacía
            }
            // 3. Si el nodo es el ÚLTIMO
            else if (Aux == Ultimo)
            {
                Ultimo = Aux.Anterior;
                if (Ultimo != null)
                    Ultimo.Siguiente = null;
            }
            // 4. Si está en el MEDIO
            else
            {
                // El truco de la "puenteada"
                Aux.Anterior.Siguiente = Aux.Siguiente;
                Aux.Siguiente.Anterior = Aux.Anterior;
            }
        }
    }
}


