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
    public partial class frmGrabarArchivo : Form
    {
        public frmGrabarArchivo()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.GrabarDatos(txtCodigo.Text,txtNombre.Text,txtDeuda.Text);
            MessageBox.Show("Los datos se grabaron!!!");
            LimpiarCajas();
        }

        private void frmGrabarArchivo_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void LimpiarCajas()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }

        private void ControlarCajas()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "" )
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ControlarCajas();
        }
    }
}
