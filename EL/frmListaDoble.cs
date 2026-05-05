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

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }


        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {

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
        }
    }
}