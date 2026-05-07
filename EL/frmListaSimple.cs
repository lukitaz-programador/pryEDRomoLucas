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

        clsListaSimple objLista = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaSimple);
            //Esto no es necesario pero se hrealiza para ver si funciona el programa y el método
            objLista.Recorrer("ListaSimple.csv");
            objLista.Recorrer(lstListaSimple);
            objLista.Recorrer(cmbListaSimple);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objLista.Eliminar(Convert.ToInt32(cmbListaSimple.Text));
            objLista.Recorrer(dgvListaSimple);
            objLista.Recorrer(lstListaSimple);
            objLista.Recorrer(cmbListaSimple);
            objLista.Recorrer("ListaSimple.csv");

            btnEliminar.Enabled = false;
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaSimple.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }
    }
}