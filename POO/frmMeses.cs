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

        private void ValidarDatos()
        {
            if (txtMeses.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            if (lstMeses.Items.Count > 0)
            {
                lstMeses.Items.Clear();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMeses.Text != "")
            {
                lstMeses.Items.Add(txtMeses.Text);
                txtMeses.Text = "";
                btnAgregar.Enabled = false;
            }
        }
    }
}
