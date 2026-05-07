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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            clsArchivo objCliente = new clsArchivo();
            objCliente.NomArchi = "Clientes.csv";
            objCliente.Recorrer(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objCliente.Recorrer(dgvClientes);

            txtNombre.Text = "";    
            txtCodigo.Text = "";
            txtDeuda.Text = "";
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.csv";
            //if (File.Exists(x.NomArchi)) x.Recorrer(dgvClientes);
            btnRecorrer.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnRecorrer.Enabled = false;
            }
            else
            {
                btnRecorrer.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Clientes.csv");
            // x.LimpiarTodo();
            // x.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnRecorrer.Enabled = false;
            }
            else
            {
                btnRecorrer.Enabled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnRecorrer.Enabled = false;
            }
            else
            {
                btnRecorrer.Enabled = true;
            }
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnRecorrer.Enabled = false;
            }
            else
            {
                btnRecorrer.Enabled = true;
            }
        }
    }
}
