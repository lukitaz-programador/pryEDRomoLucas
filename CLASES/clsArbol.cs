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
            clsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(string NomArchi)
        {
            clsNodo aux = Primero;

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
                while (aux != null) 
                {
                    ant = aux;
                    if (nuevo.Codigo < aux.Codigo)
                    {
                        aux = aux.izq;
                    }
                    else
                    {
                        aux = aux.der;
                    }
                }
            }
        }
    }
     
}
