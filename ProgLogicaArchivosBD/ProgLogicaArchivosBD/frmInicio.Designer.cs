
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
            this.grabarDatosEnUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.grabarDatosEnUnArchivoToolStripMenuItem.Text = "Grabar datos en un archivo...";
            this.grabarDatosEnUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.grabarDatosEnUnArchivoToolStripMenuItem_Click);
            // 
            // listarDatosDeUnArchivoToolStripMenuItem
            // 
            this.listarDatosDeUnArchivoToolStripMenuItem.Name = "listarDatosDeUnArchivoToolStripMenuItem";
            this.listarDatosDeUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.listarDatosDeUnArchivoToolStripMenuItem.Text = "Listar datos de un archivo...";
            this.listarDatosDeUnArchivoToolStripMenuItem.Click += new System.EventHandler(this.listarDatosDeUnArchivoToolStripMenuItem_Click);
            // 
            // buscarDatosEnUnArchivoToolStripMenuItem
            // 
            this.buscarDatosEnUnArchivoToolStripMenuItem.Name = "buscarDatosEnUnArchivoToolStripMenuItem";
            this.buscarDatosEnUnArchivoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.buscarDatosEnUnArchivoToolStripMenuItem.Text = "Buscar datos en un archivo...";
            // 
            // baseDatosADOToolStripMenuItem
            // 
            this.baseDatosADOToolStripMenuItem.Name = "baseDatosADOToolStripMenuItem";
            this.baseDatosADOToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.baseDatosADOToolStripMenuItem.Text = "Base Datos";
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
    }
}

