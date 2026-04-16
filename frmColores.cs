using pryEDRomoL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoL
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Colores.csv");
            x.Grabar(txtColores.Text);
            x.Recorrer(lstColores);

            txtColores.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtColores.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Careras.csv");
            x.LimpiarTodo();
            x.Recorrer(lstColores);

            txtColores.Text = "";
        }
    }
}
