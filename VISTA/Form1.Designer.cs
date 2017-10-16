namespace VISTA
{
    partial class Form1
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
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARIPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIP = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.conexionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // conexionesToolStripMenuItem
            // 
            this.conexionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTARIPSToolStripMenuItem});
            this.conexionesToolStripMenuItem.Name = "conexionesToolStripMenuItem";
            this.conexionesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.conexionesToolStripMenuItem.Text = "Conexiones";
            this.conexionesToolStripMenuItem.Click += new System.EventHandler(this.conexionesToolStripMenuItem_Click);
            // 
            // lISTARIPSToolStripMenuItem
            // 
            this.lISTARIPSToolStripMenuItem.Name = "lISTARIPSToolStripMenuItem";
            this.lISTARIPSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lISTARIPSToolStripMenuItem.Text = "LISTAR IPS";
            this.lISTARIPSToolStripMenuItem.Click += new System.EventHandler(this.lISTARIPSToolStripMenuItem_Click);
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(274, 150);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 23);
            this.btnIP.TabIndex = 1;
            this.btnIP.Text = "ListarIPS";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 261);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ISP-MK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTARIPSToolStripMenuItem;
        private System.Windows.Forms.Button btnIP;
    }
}

