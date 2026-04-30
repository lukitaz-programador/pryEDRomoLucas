using pryEDRomoL;
using pryEDRomoL.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoL
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple x = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "ListaSimple.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(dgvListaSimple);
            btnAgregar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            x.Agregar(n);
            x.Recorrer(dgvListaSimple);
            x.Recorrer(lstListaSimple);
            x.Recorrer(cmbListaSimple);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();

            if (n.Primero != null)
            {
               // n.Eliminar();
                x.Recorrer(dgvListaSimple);
                x.Recorrer(cmbListaSimple);
                x.Recorrer(lstListaSimple);
            }

        }
    }
}