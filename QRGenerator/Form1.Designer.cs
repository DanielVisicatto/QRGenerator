namespace QRGenerator
{
    partial class QRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGenerator));
            this.QRGenerated = new System.Windows.Forms.PictureBox();
            this.ssid = new System.Windows.Forms.TextBox();
            this.cmbSecurityType = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.GenerateAndSaveQRCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRGenerated)).BeginInit();
            this.SuspendLayout();
            // 
            // QRGenerated
            // 
            this.QRGenerated.BackColor = System.Drawing.Color.Transparent;
            this.QRGenerated.Location = new System.Drawing.Point(29, 29);
            this.QRGenerated.Name = "QRGenerated";
            this.QRGenerated.Size = new System.Drawing.Size(247, 283);
            this.QRGenerated.TabIndex = 0;
            this.QRGenerated.TabStop = false;
            this.QRGenerated.BackgroundImageChanged += new System.EventHandler(this.QRGenerated_BackgroundImageChanged);
            // 
            // ssid
            // 
            this.ssid.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ssid.Location = new System.Drawing.Point(12, 336);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(100, 20);
            this.ssid.TabIndex = 1;
            this.ssid.Text = "Wireless SSID";
            this.ssid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ssid_MouseClick);
            this.ssid.MouseEnter += new System.EventHandler(this.ssid_MouseEnter);
            this.ssid.MouseHover += new System.EventHandler(this.ssid_MouseHover);
            // 
            // cmbSecurityType
            // 
            this.cmbSecurityType.Items.AddRange(new object[] {
            "WPA",
            "WPA2",
            "WEP"});
            this.cmbSecurityType.Location = new System.Drawing.Point(12, 362);
            this.cmbSecurityType.Name = "cmbSecurityType";
            this.cmbSecurityType.Size = new System.Drawing.Size(100, 21);
            this.cmbSecurityType.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 389);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Wireless Password";
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.MouseEnter += new System.EventHandler(this.password_MouseEnter);
            this.password.MouseHover += new System.EventHandler(this.password_MouseHover);
            // 
            // GenerateAndSaveQRCode
            // 
            this.GenerateAndSaveQRCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateAndSaveQRCode.Location = new System.Drawing.Point(170, 336);
            this.GenerateAndSaveQRCode.Name = "GenerateAndSaveQRCode";
            this.GenerateAndSaveQRCode.Size = new System.Drawing.Size(124, 73);
            this.GenerateAndSaveQRCode.TabIndex = 4;
            this.GenerateAndSaveQRCode.Text = "Generate / Save QRCode";
            this.GenerateAndSaveQRCode.UseVisualStyleBackColor = true;
            this.GenerateAndSaveQRCode.Click += new System.EventHandler(this.GenerateAndSaveQRCode_Click);
            // 
            // QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.GenerateAndSaveQRCode);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cmbSecurityType);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.QRGenerated);
            this.DoubleBuffered = true;
            this.Name = "QRCodeGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCodeGenerator";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            ((System.ComponentModel.ISupportInitialize)(this.QRGenerated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRGenerated;
        private System.Windows.Forms.TextBox ssid;
        private System.Windows.Forms.ComboBox cmbSecurityType;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button GenerateAndSaveQRCode;
    }
}

