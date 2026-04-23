using pryEDRomoL;
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
        public frmColas()
        {
            InitializeComponent();
        }

        clsCola FilaDePersonas = new clsCola();

        private void frmColas_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Cola.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(dgvCola);
            btnAgregar.Enabled = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(Persona);
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer("Cola.csv");
            FilaDePersonas.Recorrer(lstListadoCola);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCodRdo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNomRdo.Text = FilaDePersonas.Primero.Nombre;
                lblTramiteRdo.Text = FilaDePersonas.Primero.Tramite;

                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer("Cola.csv");
                FilaDePersonas.Recorrer(lstListadoCola);
            }
            else
            {
                lblCodRdo.Text = "";
                lblNomRdo.Text = "";
                lblTramiteRdo.Text = "";
            }
        }
    }
}