namespace IP_WhoIs {
    partial class FrmSearch {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnNavSaved = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNavSearch = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtTimezone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountryCapital = new System.Windows.Forms.TextBox();
            this.txtContinentCode = new System.Windows.Forms.TextBox();
            this.txtContinet = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblTimezone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountryCapital = new System.Windows.Forms.Label();
            this.lblContinentCode = new System.Windows.Forms.Label();
            this.lblContinent = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.pnlTitleSearch = new System.Windows.Forms.Panel();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlTitleSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlSide.Controls.Add(this.btnNavSaved);
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.Controls.Add(this.btnNavSearch);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(241, 732);
            this.pnlSide.TabIndex = 3;
            // 
            // btnNavSaved
            // 
            this.btnNavSaved.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNavSaved.FlatAppearance.BorderSize = 0;
            this.btnNavSaved.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnNavSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSaved.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNavSaved.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNavSaved.Location = new System.Drawing.Point(0, 269);
            this.btnNavSaved.Name = "btnNavSaved";
            this.btnNavSaved.Size = new System.Drawing.Size(241, 40);
            this.btnNavSaved.TabIndex = 1;
            this.btnNavSaved.Text = "Saved";
            this.btnNavSaved.UseVisualStyleBackColor = false;
            this.btnNavSaved.Click += new System.EventHandler(this.btnNavSaved_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(43, 95);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(157, 100);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnNavSearch
            // 
            this.btnNavSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNavSearch.FlatAppearance.BorderSize = 0;
            this.btnNavSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnNavSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNavSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNavSearch.Location = new System.Drawing.Point(0, 223);
            this.btnNavSearch.Name = "btnNavSearch";
            this.btnNavSearch.Size = new System.Drawing.Size(241, 40);
            this.btnNavSearch.TabIndex = 0;
            this.btnNavSearch.Text = "Search";
            this.btnNavSearch.UseVisualStyleBackColor = false;
            this.btnNavSearch.Click += new System.EventHandler(this.btnNavSearch_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlTitleSearch);
            this.pnlMain.Controls.Add(this.txtTimezone);
            this.pnlMain.Controls.Add(this.txtCity);
            this.pnlMain.Controls.Add(this.txtCountryCapital);
            this.pnlMain.Controls.Add(this.txtContinentCode);
            this.pnlMain.Controls.Add(this.txtContinet);
            this.pnlMain.Controls.Add(this.txtIPAddress);
            this.pnlMain.Controls.Add(this.lblTimezone);
            this.pnlMain.Controls.Add(this.lblCity);
            this.pnlMain.Controls.Add(this.lblCountryCapital);
            this.pnlMain.Controls.Add(this.lblContinentCode);
            this.pnlMain.Controls.Add(this.lblContinent);
            this.pnlMain.Controls.Add(this.lblIPAddress);
            this.pnlMain.Controls.Add(this.btnSearch);
            this.pnlMain.Controls.Add(this.lblSearch);
            this.pnlMain.Controls.Add(this.txtSearchInput);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Transparent;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1482, 732);
            this.pnlMain.TabIndex = 5;
            // 
            // txtTimezone
            // 
            this.txtTimezone.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTimezone.Location = new System.Drawing.Point(482, 432);
            this.txtTimezone.Margin = new System.Windows.Forms.Padding(1);
            this.txtTimezone.Multiline = true;
            this.txtTimezone.Name = "txtTimezone";
            this.txtTimezone.ReadOnly = true;
            this.txtTimezone.Size = new System.Drawing.Size(500, 30);
            this.txtTimezone.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCity.Location = new System.Drawing.Point(482, 382);
            this.txtCity.Margin = new System.Windows.Forms.Padding(1);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(500, 30);
            this.txtCity.TabIndex = 14;
            // 
            // txtCountryCapital
            // 
            this.txtCountryCapital.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCountryCapital.Location = new System.Drawing.Point(482, 332);
            this.txtCountryCapital.Margin = new System.Windows.Forms.Padding(1);
            this.txtCountryCapital.Multiline = true;
            this.txtCountryCapital.Name = "txtCountryCapital";
            this.txtCountryCapital.ReadOnly = true;
            this.txtCountryCapital.Size = new System.Drawing.Size(500, 30);
            this.txtCountryCapital.TabIndex = 13;
            // 
            // txtContinentCode
            // 
            this.txtContinentCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtContinentCode.Location = new System.Drawing.Point(482, 283);
            this.txtContinentCode.Margin = new System.Windows.Forms.Padding(1);
            this.txtContinentCode.Multiline = true;
            this.txtContinentCode.Name = "txtContinentCode";
            this.txtContinentCode.ReadOnly = true;
            this.txtContinentCode.Size = new System.Drawing.Size(500, 30);
            this.txtContinentCode.TabIndex = 12;
            // 
            // txtContinet
            // 
            this.txtContinet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtContinet.Location = new System.Drawing.Point(482, 232);
            this.txtContinet.Margin = new System.Windows.Forms.Padding(1);
            this.txtContinet.Multiline = true;
            this.txtContinet.Name = "txtContinet";
            this.txtContinet.ReadOnly = true;
            this.txtContinet.Size = new System.Drawing.Size(500, 30);
            this.txtContinet.TabIndex = 11;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIPAddress.Location = new System.Drawing.Point(482, 181);
            this.txtIPAddress.Margin = new System.Windows.Forms.Padding(1);
            this.txtIPAddress.Multiline = true;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.ReadOnly = true;
            this.txtIPAddress.Size = new System.Drawing.Size(500, 30);
            this.txtIPAddress.TabIndex = 10;
            // 
            // lblTimezone
            // 
            this.lblTimezone.AutoSize = true;
            this.lblTimezone.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimezone.ForeColor = System.Drawing.Color.Black;
            this.lblTimezone.Location = new System.Drawing.Point(310, 443);
            this.lblTimezone.Name = "lblTimezone";
            this.lblTimezone.Size = new System.Drawing.Size(88, 18);
            this.lblTimezone.TabIndex = 9;
            this.lblTimezone.Text = "Timezone :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(310, 393);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(56, 18);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City :";
            // 
            // lblCountryCapital
            // 
            this.lblCountryCapital.AutoSize = true;
            this.lblCountryCapital.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCountryCapital.ForeColor = System.Drawing.Color.Black;
            this.lblCountryCapital.Location = new System.Drawing.Point(310, 343);
            this.lblCountryCapital.Name = "lblCountryCapital";
            this.lblCountryCapital.Size = new System.Drawing.Size(144, 18);
            this.lblCountryCapital.TabIndex = 7;
            this.lblCountryCapital.Text = "Country capital :";
            // 
            // lblContinentCode
            // 
            this.lblContinentCode.AutoSize = true;
            this.lblContinentCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContinentCode.ForeColor = System.Drawing.Color.Black;
            this.lblContinentCode.Location = new System.Drawing.Point(310, 294);
            this.lblContinentCode.Name = "lblContinentCode";
            this.lblContinentCode.Size = new System.Drawing.Size(136, 18);
            this.lblContinentCode.TabIndex = 6;
            this.lblContinentCode.Text = "Continent code :";
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblContinent.ForeColor = System.Drawing.Color.Black;
            this.lblContinent.Location = new System.Drawing.Point(310, 243);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(96, 18);
            this.lblContinent.TabIndex = 5;
            this.lblContinent.Text = "Contitnet :";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIPAddress.ForeColor = System.Drawing.Color.Black;
            this.lblIPAddress.Location = new System.Drawing.Point(310, 192);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(112, 18);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP address : ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(1057, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 41);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(309, 110);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "IP address :";
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchInput.ForeColor = System.Drawing.Color.Black;
            this.txtSearchInput.Location = new System.Drawing.Point(482, 108);
            this.txtSearchInput.Multiline = true;
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(500, 30);
            this.txtSearchInput.TabIndex = 0;
            this.txtSearchInput.Text = "https://ipwhois.app/json/193.198.57.183";
            // 
            // pnlTitleSearch
            // 
            this.pnlTitleSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlTitleSearch.Controls.Add(this.lblTitleSearch);
            this.pnlTitleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleSearch.ForeColor = System.Drawing.Color.White;
            this.pnlTitleSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleSearch.Name = "pnlTitleSearch";
            this.pnlTitleSearch.Size = new System.Drawing.Size(1482, 50);
            this.pnlTitleSearch.TabIndex = 16;
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleSearch.ForeColor = System.Drawing.Color.White;
            this.lblTitleSearch.Location = new System.Drawing.Point(700, 9);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(150, 33);
            this.lblTitleSearch.TabIndex = 2;
            this.lblTitleSearch.Text = "Search IP";
            this.lblTitleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 732);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Who Is";
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlTitleSearch.ResumeLayout(false);
            this.pnlTitleSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnNavSaved;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnNavSearch;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lblTimezone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountryCapital;
        private System.Windows.Forms.Label lblContinentCode;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox txtTimezone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountryCapital;
        private System.Windows.Forms.TextBox txtContinentCode;
        private System.Windows.Forms.TextBox txtContinet;
        private System.Windows.Forms.Panel pnlTitleSearch;
        private System.Windows.Forms.Label lblTitleSearch;
    }
}

