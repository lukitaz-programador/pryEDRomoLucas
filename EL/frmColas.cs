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
    public partial class frmColas : Form
    {

        clsCola Cola = new clsCola();
        public frmColas()
        {
            InitializeComponent();
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

            Cola.Agregar(x);
            Cola.Recorrer(dgvCola);
            Cola.Recorrer("Cola.csv");
            Cola.Recorrer(lstCola);

            lblCodRdo.Text = x.Codigo.ToString();
            lblNomRdo.Text = x.Nombre;
            lblTramRdo.Text = x.Tramite;

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Cola.Eliminar(Cola.Primero.Codigo);

            Cola.Recorrer(dgvCola);
            Cola.Recorrer(lstCola);
            Cola.Recorrer("Cola.csv");

            lblCodRdo.Text = "";
            lblNomRdo.Text = "";
            lblTramRdo.Text = "";

            if (Cola.Primero == null)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
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
    }
}