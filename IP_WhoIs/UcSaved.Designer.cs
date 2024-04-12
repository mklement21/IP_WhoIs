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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleSaved = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.lblTitleSaved);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 50);
            this.panel1.TabIndex = 0;
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
            // UcSaved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UcSaved";
            this.Size = new System.Drawing.Size(1400, 700);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitleSaved;
    }
}
