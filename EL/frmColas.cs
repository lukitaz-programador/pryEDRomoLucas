using pryEDRomoL;
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

        clsCola x = new clsCola();
        public frmColas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;
            x.Agregar(n);
            x.Recorrer(dgvCola);
            x.Recorrer(lstListadoCola);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (x.Primero != null)
            {

                lblCodigo.Text = Convert.ToString(x.Primero.Codigo);
                lblNombre.Text = x.Primero.Nombre;
                lblTramite.Text = x.Primero.Tramite;
                x.Eliminar(x.Primero);
                x.Recorrer(dgvCola);
                x.Recorrer(lstListadoCola);
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
                lblTramite.Text = "";
                lblNombre.Text = "";
                lblCodigo.Text = "";
            }
        }
    }
}