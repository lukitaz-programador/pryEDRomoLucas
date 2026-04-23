
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria que permite procesar archivos
using System.IO;
using System.Windows.Forms;

namespace pryEDRomoL
{
    internal class clsArchivo
    {
        //Creo un campo
        public string NomArchi = ""; //guarda el nombre del archivo (propiedad)


        public void Grabar()
        {
            //Abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola!!!");
            AD.Close();
        }

        public void Grabar(string Dato)
        {
            //Abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato); //WriteLine escribe una línea y le da el enter
            AD.Close();
        }

        public void Grabar(string dato1, string dato2, string dato3)
        {
            //Abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(dato1); //Write solo escribe una línea
            AD.Write(";"); // ; sirve para que el siguientes dato se escriba en otra celda
            AD.Write(dato2);
            AD.Write(";");
            AD.WriteLine(dato3);
            AD.Close();
        }

        public void LimpiarTodo()
        {
            StreamWriter AD = new StreamWriter(NomArchi, false); //Abre y pisa el que existe            
            AD.Close();
        }

        public void Recorrer(ListBox lst)
        {
            lst.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        //Instancio una sobrecarga pero con combo box y datagridview

        public void Recorrer(ComboBox cmb)
        {
            string DatoLeido = "";
            cmb.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmb.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
    }
}
