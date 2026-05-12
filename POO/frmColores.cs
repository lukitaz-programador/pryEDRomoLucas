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

        private void ValidarDatos()
        {
            if (txtColores.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            if (lstColores.Items.Count > 0)
            {
                lstColores.Items.Clear();
            }   

            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtColores.Text != "")
            {
                lstColores.Items.Add(txtColores.Text);
                txtColores.Text = "";
                btnAgregar.Enabled = false;
            }
        }
    }
}
