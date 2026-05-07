using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pryEDRomoL;

namespace pryEDRomoL
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objAlumnos = new clsArchivo();
            objAlumnos.NomArchi = "Alumnos.csv";
            objAlumnos.Recorrer(dgvAlumnos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.SelectedIndex = -1;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "")
            {
                btnRecorrer.Enabled = true;
            }
            else
            {
                btnRecorrer.Enabled = false;
            }
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            clsArchivo objRecorrer = new clsArchivo();
            objRecorrer.NomArchi = "Alumnos.csv";
            objRecorrer.Recorrer(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objRecorrer.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Alumnos.csv");
            x.LimpiarTodo();
            x.Recorrer(dgvAlumnos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "")
            {
                btnRecorrer.Enabled = true;
            }
            else
            {
                btnRecorrer.Enabled = false;
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarrera.Text != "")
            {
                btnRecorrer.Enabled = true;
            }
            else
            {
                btnRecorrer.Enabled = false;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
