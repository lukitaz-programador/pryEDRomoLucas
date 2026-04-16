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

namespace pryEpryEDRomoL
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objGrabar = new clsArchivo();
            objGrabar.NomArchi = "Carreras.csv";
            objGrabar.Recorrer(cmbCarrera);

            clsArchivo objAlumnos = new clsArchivo();
            if (File.Exists(objAlumnos.NomArchi)) objAlumnos.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && cmbCarrera.Text != "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objRecorrer = new clsArchivo();
            objRecorrer.NomArchi = "Alumnos.csv";
            objRecorrer.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objRecorrer.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Alumnos.csv");
            x.LimpiarTodo();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }
    }
}
