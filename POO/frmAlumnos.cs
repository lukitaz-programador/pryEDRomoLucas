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

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && cmbCarrera.SelectedIndex != -1)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
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
            ValidarDatos();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && cmbCarrera.Text != "")
            {
                dgvAlumnos.Rows.Add(txtNombre.Text, txtCodigo.Text, cmbCarrera.Text);
                txtNombre.Text = "";
                txtCodigo.Text = "";
                cmbCarrera.SelectedIndex = -1;
                btnAgregar.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Alumnos.csv");
            x.LimpiarTodo();
            x.Recorrer(dgvAlumnos);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }
    }
}
