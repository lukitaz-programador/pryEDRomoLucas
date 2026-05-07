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

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            clsArchivo objMes = new clsArchivo();
            objMes.NomArchi = ("Meses.csv");
            objMes.Recorrer(txtMeses.Text);

            txtMeses.Text = "";
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnRecorrer.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtMeses.Text == "")
            {
                btnRecorrer.Enabled = false;
            }
            else
            {
                btnRecorrer.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Meses.csv");
            x.LimpiarTodo();
            //x.Recorrer(lstMeses);

            txtMeses.Text = "";
        }
    }
}
