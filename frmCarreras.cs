using pryEDnuevoSANTINO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdBarberoB
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NomArchi = "Carreras.txt";
            objCarrera.BorrarTodo();
            objCarrera.Recorrer(lstCarreras);
        }
    }
}
