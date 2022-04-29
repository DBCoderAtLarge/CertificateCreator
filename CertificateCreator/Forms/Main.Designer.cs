
namespace CertificateCreator.Forms
{
    partial class Main
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
            this.CertSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CreateCertsTabControl = new System.Windows.Forms.TabControl();
            this.TlsTabPage = new System.Windows.Forms.TabPage();
            this.AppTlsCertUserControl = new CertificateCreator.UserControls.TlsCertUserControl();
            this.IdpTabPage = new System.Windows.Forms.TabPage();
            this.OpenIdPictureBox = new System.Windows.Forms.PictureBox();
            this.AppIdpCertUserControl = new CertificateCreator.UserControls.IdpCertUserControl();
            this.AppLogTextBox = new System.Windows.Forms.TextBox();
            this.CertificatePictureBox = new System.Windows.Forms.PictureBox();
            this.AppLogLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateCertsTabControl.SuspendLayout();
            this.TlsTabPage.SuspendLayout();
            this.IdpTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenIdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CertSaveFileDialog
            // 
            this.CertSaveFileDialog.Filter = "\"Prvt Certs|*.pfx|All Files|*.*\"";
            // 
            // CreateCertsTabControl
            // 
            this.CreateCertsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCertsTabControl.Controls.Add(this.TlsTabPage);
            this.CreateCertsTabControl.Controls.Add(this.IdpTabPage);
            this.CreateCertsTabControl.Location = new System.Drawing.Point(420, 40);
            this.CreateCertsTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateCertsTabControl.Name = "CreateCertsTabControl";
            this.CreateCertsTabControl.SelectedIndex = 0;
            this.CreateCertsTabControl.Size = new System.Drawing.Size(1416, 844);
            this.CreateCertsTabControl.TabIndex = 9;
            // 
            // TlsTabPage
            // 
            this.TlsTabPage.Controls.Add(this.AppTlsCertUserControl);
            this.TlsTabPage.Location = new System.Drawing.Point(4, 39);
            this.TlsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TlsTabPage.Name = "TlsTabPage";
            this.TlsTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TlsTabPage.Size = new System.Drawing.Size(1408, 801);
            this.TlsTabPage.TabIndex = 0;
            this.TlsTabPage.Text = "TLS Cert";
            this.TlsTabPage.UseVisualStyleBackColor = true;
            // 
            // AppTlsCertUserControl
            // 
            this.AppTlsCertUserControl.BackColor = System.Drawing.Color.Transparent;
            this.AppTlsCertUserControl.Location = new System.Drawing.Point(29, 18);
            this.AppTlsCertUserControl.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.AppTlsCertUserControl.Model = null;
            this.AppTlsCertUserControl.Name = "AppTlsCertUserControl";
            this.AppTlsCertUserControl.Size = new System.Drawing.Size(1354, 740);
            this.AppTlsCertUserControl.TabIndex = 0;
            // 
            // IdpTabPage
            // 
            this.IdpTabPage.Controls.Add(this.OpenIdPictureBox);
            this.IdpTabPage.Controls.Add(this.AppIdpCertUserControl);
            this.IdpTabPage.Location = new System.Drawing.Point(4, 39);
            this.IdpTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdpTabPage.Name = "IdpTabPage";
            this.IdpTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdpTabPage.Size = new System.Drawing.Size(1408, 801);
            this.IdpTabPage.TabIndex = 1;
            this.IdpTabPage.Text = "Idp Cert (Token Stamping)";
            this.IdpTabPage.UseVisualStyleBackColor = true;
            // 
            // OpenIdPictureBox
            // 
            this.OpenIdPictureBox.BackgroundImage = global::CertificateCreator.Properties.Resources.openid_connect;
            this.OpenIdPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenIdPictureBox.Location = new System.Drawing.Point(787, 60);
            this.OpenIdPictureBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.OpenIdPictureBox.Name = "OpenIdPictureBox";
            this.OpenIdPictureBox.Size = new System.Drawing.Size(300, 300);
            this.OpenIdPictureBox.TabIndex = 1;
            this.OpenIdPictureBox.TabStop = false;
            // 
            // AppIdpCertUserControl
            // 
            this.AppIdpCertUserControl.Location = new System.Drawing.Point(9, 68);
            this.AppIdpCertUserControl.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.AppIdpCertUserControl.Name = "AppIdpCertUserControl";
            this.AppIdpCertUserControl.Size = new System.Drawing.Size(595, 518);
            this.AppIdpCertUserControl.TabIndex = 0;
            // 
            // AppLogTextBox
            // 
            this.AppLogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppLogTextBox.Location = new System.Drawing.Point(19, 334);
            this.AppLogTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppLogTextBox.Multiline = true;
            this.AppLogTextBox.Name = "AppLogTextBox";
            this.AppLogTextBox.Size = new System.Drawing.Size(381, 476);
            this.AppLogTextBox.TabIndex = 10;
            // 
            // CertificatePictureBox
            // 
            this.CertificatePictureBox.BackgroundImage = global::CertificateCreator.Properties.Resources.cert;
            this.CertificatePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CertificatePictureBox.Location = new System.Drawing.Point(99, 26);
            this.CertificatePictureBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CertificatePictureBox.Name = "CertificatePictureBox";
            this.CertificatePictureBox.Size = new System.Drawing.Size(223, 182);
            this.CertificatePictureBox.TabIndex = 11;
            this.CertificatePictureBox.TabStop = false;
            // 
            // AppLogLabel
            // 
            this.AppLogLabel.AutoSize = true;
            this.AppLogLabel.Location = new System.Drawing.Point(19, 298);
            this.AppLogLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AppLogLabel.Name = "AppLogLabel";
            this.AppLogLabel.Size = new System.Drawing.Size(96, 30);
            this.AppLogLabel.TabIndex = 12;
            this.AppLogLabel.Text = "App Log:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.Coral;
            this.TitleLabel.Location = new System.Drawing.Point(22, 222);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(397, 45);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Certificate Creation Tool";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1702, 896);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(129, 46);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 956);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AppLogLabel);
            this.Controls.Add(this.CertificatePictureBox);
            this.Controls.Add(this.AppLogTextBox);
            this.Controls.Add(this.CreateCertsTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(3405, 1020);
            this.MinimumSize = new System.Drawing.Size(1863, 1020);
            this.Name = "Main";
            this.Text = "Certificate Creator";
            this.Shown += new System.EventHandler(this.MainShown);
            this.CreateCertsTabControl.ResumeLayout(false);
            this.TlsTabPage.ResumeLayout(false);
            this.IdpTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OpenIdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog CertSaveFileDialog;
        private System.Windows.Forms.TabControl CreateCertsTabControl;
        private System.Windows.Forms.TabPage TlsTabPage;
        private System.Windows.Forms.TabPage IdpTabPage;
        private UserControls.IdpCertUserControl AppIdpCertUserControl;
        private UserControls.TlsCertUserControl AppTlsCertUserControl;
        private System.Windows.Forms.TextBox AppLogTextBox;
        private System.Windows.Forms.PictureBox CertificatePictureBox;
        private System.Windows.Forms.Label AppLogLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox OpenIdPictureBox;
        private System.Windows.Forms.Button ExitButton;
    }
}