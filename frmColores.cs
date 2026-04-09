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

namespace pryEDRomoLucas
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }   
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = "Colores.txt";
            x.Grabar(txtNombre.Text);
            x.Recorrer(cmbColores);

            txtNombre.Text = "";
        }
    }
}
