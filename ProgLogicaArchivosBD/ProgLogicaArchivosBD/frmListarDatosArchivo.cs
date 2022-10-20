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
    public partial class frmListarDatosArchivo : Form
    {
        public frmListarDatosArchivo()
        {
            InitializeComponent();
        }

        clsArchivoTexto x = new clsArchivoTexto();

        private void btnListar_Click(object sender, EventArgs e)
        {            
            x.ListarDatos(dgvDatosArchivo);
            lblDeuda.Text = x.TotalDeuda.ToString("0.00");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            x.ExportarDatos();
            MessageBox.Show("Los datos fueron exportados!!!");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DialogoImpresora.ShowDialog();
            Documento.PrinterSettings = DialogoImpresora.PrinterSettings;
            Documento.Print();
        }

        private void Documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            x.Imprimir(e);
        }
       
    }
}
