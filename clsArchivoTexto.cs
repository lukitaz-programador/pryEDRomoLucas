using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agrego una libreria que me permite procesar archivos 
using System.IO;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace pryEDnuevoSANTINO
{

    internal class clsArchivoTexto
    {
        //creamos campo     
        public string NomArchi = "Colores.txt";
        public string NomArchi2 = "Meses.txt";
        public string NomArchi3 = "Clientes.csv";

        public void Grabar()
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine("hola!!");
            AD.Close();

        }

        public void Grabar(string datos)
        {
            //abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(datos);
            AD.Close();

        }

        public void Recorrer(ListBox cmbDatos)
        {
            //abrir archivo para lectura 
            cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi, true);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmbDatos)
        {
            //abrir archivo para lectura 
            cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi, true);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView cmbDatos)
        {
            //abrir archivo para lectura 
            cmbDatos.Raws.+Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();


            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Raws.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Grabar(string cod, string nom, string deu)
        {              
            StreamWriter AD = new StreamWriter(NomArchi3, true);
            AD.WriteLine(cod+";"+nom+";"+deu);
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