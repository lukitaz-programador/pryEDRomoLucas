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
    internal class clsArbol
    {
        private clsNodo raiz;
        public clsNodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Raiz;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox cmb)
        {
            clsNodo aux = Raiz;
            cmb.Items.Clear();
            while (aux != null)
            {
                cmb.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }

        public void Recorrer(string NomArchi)
        {
            clsNodo aux = Raiz;

            using (StreamWriter AD = new StreamWriter(NomArchi, false, Encoding.UTF8))
            {
                AD.WriteLine("Codigo;Nombre;Tramite");

                while (aux != null)
                {
                    AD.WriteLine(aux.Codigo + ";" + aux.Nombre + ";" + aux.Tramite);
                    aux = aux.Siguiente;
                }
                AD.Close();
            }
        }

        public void Agregar(clsNodo nuevo)
        {
            if (Raiz == null)
            {
                Raiz = nuevo;
            }
             else
            {
                clsNodo aux = Raiz;
                clsNodo ant = Raiz;

                while (aux != null) 
                {
                    ant = aux;
                    if (nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierdo;
                    }
                    else
                    {
                        aux = aux.Derecho;
                    }
                }
            }
        }
    }
     
}
