using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRomoLucas
{
    public partial class EstructuraDeDatos : Form
    {
        public EstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopy frmCopy = new frmCopy();
            frmCopy.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void EstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void programacionOrientadaAObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
