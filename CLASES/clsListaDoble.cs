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
        private string NomArchi;

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
            if (pri == null)
            {
                pri = nuevo;
                ult = nuevo;
            }
            else
            {
                if (nuevo.Codigo < pri.Codigo)
                {
                    nuevo.Siguiente = pri;
                    pri.Anterior = nuevo;
                    pri = nuevo;
                }
                else
                {
                    if (nuevo.Codigo > ult.Codigo)
                    {
                        ult.Siguiente = nuevo;
                        nuevo.Anterior = ult;
                        ult = nuevo;
                    }
                    else
                    {
                        clsNodo aux = pri;
                        clsNodo ant = pri;
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
        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Primero;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            clsNodo aux = Primero;
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
    }
}


