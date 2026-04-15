
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
//agrego una libreria que me permite procesar archivos 
using System.IO;


namespace pryEDRomoL
{

    internal class clsArchivoTexto
    {
        //creamos campo     
        public string NomArchi;

        //public void Grabar()
        //{
        //abrir archivo para escritura 
        //   StreamWriter AD = new StreamWriter(NomArchi, true);
        //   AD.WriteLine("hola mundo!!");
        //   AD.Close();
        //}

        public void Grabar(string datos)
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            //se graban los datos en una linea
            AD.WriteLine(datos);
            //se cierra el archivo de escritura
            AD.Close();
        }

        public void Recorrer(ComboBox cmbDatos)
        {
            //abrir archivo para lectura
            string DatoLeido;
            cmbDatos.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi, true);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            cmbDatos.SelectedIndex = 0;
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        {
            //abrir archivo para lectura
            string DatoLeido;
            lstDatos.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi, true);
            //se lee la primera linea como en un registro
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            //se cierra el archivo de lectura
            lstDatos.SelectedIndex = 0;
            AD.Close();
        }

        public void Recorrer(DataGridView dgvDatos)
        {
            //abrir archivo para lectura 
            string DatoLeido;
            dgvDatos.Rows.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                dgvDatos.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Grabar(string cod, string nom, string deu)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(cod + ";" + nom + ";" + deu);
            AD.Close();
        }

        public void BorrarTodo()
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, false);
            AD.Close();
        }
    }
}
}
