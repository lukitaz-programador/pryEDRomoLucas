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

        public void Agregar(clsNodo Nuevo)
        {
            if (Ultimo == null)
            {
                Ultimo = Nuevo;

            }
            else
            {
                Nuevo.Siguiente = Ultimo;
                Ultimo = Nuevo;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(string NomArchi)
        {
            clsNodo aux = Ultimo;

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

        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Ultimo;
            lista.Items.Clear();

            while (aux != null)
            {
                lista.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Ultimo.Codigo == Codigo)
            {
                if (Ultimo != null)
                {
                    Ultimo = Ultimo.Siguiente;
                    if (Ultimo == null)
                    {
                        Primero = null;
                    }
                }
            }
        }         
    }
}
