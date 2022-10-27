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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsClientes objCli = new clsClientes();
        private void btnListar_Click(object sender, EventArgs e)
        {
            objCli.ListarTodos(dgvClientes);
        }
    }
}
