
namespace ProgLogicaArchivosBD
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarDatosEnUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDatosDeUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDatosEnUnArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDatosADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.baseDatosADOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeDesarrolladorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // datosDeDesarrolladorToolStripMenuItem
            // 
            this.datosDeDesarrolladorToolStripMenuItem.Name = "datosDeDesarrolladorToolStripMenuItem";
            this.datosDeDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.datosDeDesarrolladorToolStripMenuItem.Text = "Datos de desarrollador...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarDatosEnUnArchivoToolStripMenuItem,
            this.listarDatosDeUnArchivoToolStripMenuItem,
            this.buscarDatosEnUnArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // grabarDatosEnUnArchivoToolStripMenuItem
            // 
            this.grabarDatosEnUnArchivoToolStripMenuItem.Name = "grabarDatosEnUnArchivoToolStripMenuItem";
            this.grabarDatosEnUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.grabarDatosEnUnArchivoToolStripMenuItem.Text = "Grabar datos en un archivo...";
            this.grabarDatosEnUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.grabarDatosEnUnArchivoToolStripMenuItem_Click);
            // 
            // listarDatosDeUnArchivoToolStripMenuItem
            // 
            this.listarDatosDeUnArchivoToolStripMenuItem.Name = "listarDatosDeUnArchivoToolStripMenuItem";
            this.listarDatosDeUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.listarDatosDeUnArchivoToolStripMenuItem.Text = "Listar datos de un archivo...";
            this.listarDatosDeUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.listarDatosDeUnArchivoToolStripMenuItem_Click);
            // 
            // buscarDatosEnUnArchivoToolStripMenuItem
            // 
            this.buscarDatosEnUnArchivoToolStripMenuItem.Name = "buscarDatosEnUnArchivoToolStripMenuItem";
            this.buscarDatosEnUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.buscarDatosEnUnArchivoToolStripMenuItem.Text = "Buscar datos en un archivo...";
            // 
            // baseDatosADOToolStripMenuItem
            // 
            this.baseDatosADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoClienteToolStripMenuItem,
            this.consultarUnClienteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem,
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem});
            this.baseDatosADOToolStripMenuItem.Name = "baseDatosADOToolStripMenuItem";
            this.baseDatosADOToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.baseDatosADOToolStripMenuItem.Text = "Base Datos";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            this.agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            this.agregarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.agregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente...";
            // 
            // consultarUnClienteToolStripMenuItem
            // 
            this.consultarUnClienteToolStripMenuItem.Name = "consultarUnClienteToolStripMenuItem";
            this.consultarUnClienteToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.consultarUnClienteToolStripMenuItem.Text = "Consultar un cliente...";
            this.consultarUnClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarUnClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 6);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem.Name = "listadoDeClientesDeudoresToolStripMenuItem";
            this.listadoDeClientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.listadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de clientes deudores...";
            // 
            // listadoDeClientesDeUnaCiudadToolStripMenuItem
            // 
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Name = "listadoDeClientesDeUnaCiudadToolStripMenuItem";
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.listadoDeClientesDeUnaCiudadToolStripMenuItem.Text = "Listado de clientes de una ciudad...";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(465, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Procesamiento de archivos y bases de datos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarDatosEnUnArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDatosDeUnArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarDatosEnUnArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDatosADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeUnaCiudadToolStripMenuItem;
    }
}

