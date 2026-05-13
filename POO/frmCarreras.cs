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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void ValidarDatos()
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = ("Carreras.csv");
            objCarrera.Recorrer(txtCarreras.Text);
            lstCarreras.Items.Add(txtCarreras.Text);

            txtCarreras.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Carreras.csv");
            x.LimpiarTodo();
            x.Recorrer(lstCarreras);
            lstCarreras.Items.Clear();

            txtCarreras.Text = "";
        }

        private void txtCarreras_TextChanged(object sender, EventArgs e)
        {
            if (txtCarreras.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            
        }
    }
}