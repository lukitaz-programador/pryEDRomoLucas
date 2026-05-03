using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoL
{
    internal class clsArchivo
    {

        public string NomArchi;

        public void Recorrer(string codigo, string nombre)
        {
            StreamWriter sw = new StreamWriter(NomArchi, true);
            sw.Write(codigo + ";");
            sw.WriteLine(nombre);
            sw.Close();
        }
        public void Recorrer(string dato1, string dato2, string dato3)
        {
            StreamWriter sw = new StreamWriter(NomArchi, true);
            sw.Write(dato1 + ";");
            sw.Write(dato2 + ";");
            sw.WriteLine(dato3);
            sw.Close();
        }
        public void Recorrer(string texto)
        {
            StreamWriter sw = new StreamWriter(NomArchi, true);
            sw.WriteLine(texto);
            sw.Close();
        }
        public string Leer()
        {
            StreamReader sr = new StreamReader(NomArchi);
            string texto = sr.ReadToEnd();
            sr.Close();
            return texto;
        }

        public void Leer(ListBox Lista)
        {
            String datoLeido;
            Lista.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                Lista.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Leer(ComboBox Lista)
        {
            String datoLeido;
            Lista.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                Lista.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();
            }
            AD.Close();
            Lista.SelectedIndex = 0;
        }
        public void Leer(DataGridView dgv)
        {
            String DatoLeido;
            dgv.Rows.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();

            while (DatoLeido != null)
            {

                dgv.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }

            AD.Close();
        }
    }
}
