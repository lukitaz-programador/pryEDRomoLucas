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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Meses.csv");
            x.Grabar(txtMeses.Text);
            x.Recorrer(lstMeses);

            txtMeses.Text = "";
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtMeses.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Meses.csv");
            x.LimpiarTodo();
            x.Recorrer(lstMeses);

            txtMeses.Text = "";
        }
    }
}
