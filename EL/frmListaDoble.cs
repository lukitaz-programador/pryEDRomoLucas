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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }


        clsListaDoble objListaDoble = new clsListaDoble();
        public object Primero { get; private set; }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objListaDoble.Agregar(x);
            objListaDoble.Recorrer(dgvListaDoble);
            objListaDoble.Recorrer("ListaDoble.csv");
            objListaDoble.Recorrer(lstListaDoble);
            objListaDoble.Recorrer(cmbListaDoble);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private clsListaDoble GetObjListaDoble()
        {
            return objListaDoble;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            objListaDoble.Eliminar(Convert.ToInt32(cmbListaDoble.Text));
            objListaDoble.Recorrer(dgvListaDoble);
            objListaDoble.Recorrer("ListaDoble.csv");
            objListaDoble.Recorrer(lstListaDoble);
            objListaDoble.Recorrer(cmbListaDoble);

            btnEliminar.Enabled = false;
        }

        private void cmbListaDoble_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaDoble.SelectedIndex == -1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.Recorrer(dgvListaDoble);
            objListaDoble.Recorrer("ListaDoble.csv");
            objListaDoble.Recorrer(lstListaDoble);
            objListaDoble.Recorrer(cmbListaDoble);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.RecorrerDes(dgvListaDoble);
            objListaDoble.RecorrerDes("ListaDoble.csv");
            objListaDoble.RecorrerDes(lstListaDoble);
            objListaDoble.RecorrerDes(cmbListaDoble);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}