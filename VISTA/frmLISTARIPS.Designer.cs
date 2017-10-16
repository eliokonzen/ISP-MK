namespace VISTA
{
    partial class frmLISTARIPS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLISTAR = new System.Windows.Forms.Button();
            this.dgvIPS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLISTAR
            // 
            this.btnLISTAR.Location = new System.Drawing.Point(321, 198);
            this.btnLISTAR.Name = "btnLISTAR";
            this.btnLISTAR.Size = new System.Drawing.Size(75, 23);
            this.btnLISTAR.TabIndex = 0;
            this.btnLISTAR.Text = "Listar";
            this.btnLISTAR.UseVisualStyleBackColor = true;
            this.btnLISTAR.Click += new System.EventHandler(this.btnLISTAR_Click);
            // 
            // dgvIPS
            // 
            this.dgvIPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIPS.Location = new System.Drawing.Point(46, 12);
            this.dgvIPS.Name = "dgvIPS";
            this.dgvIPS.Size = new System.Drawing.Size(634, 150);
            this.dgvIPS.TabIndex = 1;
            // 
            // frmLISTARIPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 261);
            this.Controls.Add(this.dgvIPS);
            this.Controls.Add(this.btnLISTAR);
            this.Name = "frmLISTARIPS";
            this.Text = "frmLISTARIPS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLISTAR;
        private System.Windows.Forms.DataGridView dgvIPS;
    }
}