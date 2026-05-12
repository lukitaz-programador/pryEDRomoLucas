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

        public void Recorrer(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();

            while (aux != null)
            {
                lista.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }

        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero != null)
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    if (Primero == null)
                    {
                        Ultimo = null;
                    }
                }
            }
        }
    }
}
