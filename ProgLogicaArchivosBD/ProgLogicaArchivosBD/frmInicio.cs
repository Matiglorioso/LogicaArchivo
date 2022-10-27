using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgLogicaArchivosBD
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grabarDatosEnUnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrabarArchivo v = new frmGrabarArchivo();
            v.ShowDialog();
        }

        private void listarDatosDeUnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarDatosArchivo v = new frmListarDatosArchivo();
            v.ShowDialog();
        }

        private void consultarUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoClientes objVentana = new frmListadoClientes();
                objVentana.ShowDialog();
        }
    }
}
