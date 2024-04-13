namespace IP_WhoIs {
    partial class UcSaved {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgvSavedAddresses = new System.Windows.Forms.DataGridView();
            this.lblTitleSaved = new System.Windows.Forms.Label();
            this.pnlTitleSaved = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedAddresses)).BeginInit();
            this.pnlTitleSaved.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSavedAddresses
            // 
            this.dgvSavedAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavedAddresses.Location = new System.Drawing.Point(397, 155);
            this.dgvSavedAddresses.Name = "dgvSavedAddresses";
            this.dgvSavedAddresses.RowHeadersWidth = 51;
            this.dgvSavedAddresses.RowTemplate.Height = 24;
            this.dgvSavedAddresses.Size = new System.Drawing.Size(1041, 267);
            this.dgvSavedAddresses.TabIndex = 1;
            // 
            // lblTitleSaved
            // 
            this.lblTitleSaved.AutoSize = true;
            this.lblTitleSaved.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleSaved.ForeColor = System.Drawing.Color.White;
            this.lblTitleSaved.Location = new System.Drawing.Point(700, 9);
            this.lblTitleSaved.Name = "lblTitleSaved";
            this.lblTitleSaved.Size = new System.Drawing.Size(150, 33);
            this.lblTitleSaved.TabIndex = 1;
            this.lblTitleSaved.Text = "Saved IPs";
            this.lblTitleSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitleSaved
            // 
            this.pnlTitleSaved.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlTitleSaved.Controls.Add(this.lblTitleSaved);
            this.pnlTitleSaved.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleSaved.ForeColor = System.Drawing.Color.White;
            this.pnlTitleSaved.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleSaved.Name = "pnlTitleSaved";
            this.pnlTitleSaved.Size = new System.Drawing.Size(1696, 50);
            this.pnlTitleSaved.TabIndex = 0;
            // 
            // UcSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSavedAddresses);
            this.Controls.Add(this.pnlTitleSaved);
            this.Name = "UcSaved";
            this.Size = new System.Drawing.Size(1696, 732);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedAddresses)).EndInit();
            this.pnlTitleSaved.ResumeLayout(false);
            this.pnlTitleSaved.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSavedAddresses;
        private System.Windows.Forms.Label lblTitleSaved;
        private System.Windows.Forms.Panel pnlTitleSaved;
    }
}
