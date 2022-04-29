
namespace CertificateCreator.UserControls
{
    partial class IdpCertUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CreateCertButton = new System.Windows.Forms.Button();
            this.DnsNameTextBox = new System.Windows.Forms.TextBox();
            this.ValidityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CertSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.FriendlyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.IdpFormErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValidityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdpFormErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateCertButton
            // 
            this.CreateCertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.CreateCertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateCertButton.ForeColor = System.Drawing.Color.White;
            this.CreateCertButton.Location = new System.Drawing.Point(199, 364);
            this.CreateCertButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CreateCertButton.Name = "CreateCertButton";
            this.CreateCertButton.Size = new System.Drawing.Size(228, 80);
            this.CreateCertButton.TabIndex = 5;
            this.CreateCertButton.Text = "Create";
            this.CreateCertButton.UseVisualStyleBackColor = false;
            this.CreateCertButton.Click += new System.EventHandler(this.CreateCertButtonClick);
            // 
            // DnsNameTextBox
            // 
            this.DnsNameTextBox.Location = new System.Drawing.Point(199, 18);
            this.DnsNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DnsNameTextBox.Name = "DnsNameTextBox";
            this.DnsNameTextBox.Size = new System.Drawing.Size(301, 35);
            this.DnsNameTextBox.TabIndex = 0;
            this.DnsNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DnsNameTextBox_Validating);
            // 
            // ValidityNumericUpDown
            // 
            this.ValidityNumericUpDown.Location = new System.Drawing.Point(199, 302);
            this.ValidityNumericUpDown.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ValidityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ValidityNumericUpDown.Name = "ValidityNumericUpDown";
            this.ValidityNumericUpDown.Size = new System.Drawing.Size(93, 35);
            this.ValidityNumericUpDown.TabIndex = 4;
            this.ValidityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CertSaveFileDialog
            // 
            this.CertSaveFileDialog.Filter = "\"Prvt Certs|*.pfx|All Files|*.*\"";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(199, 232);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(301, 35);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // FriendlyNameTextBox
            // 
            this.FriendlyNameTextBox.Location = new System.Drawing.Point(199, 160);
            this.FriendlyNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.FriendlyNameTextBox.Name = "FriendlyNameTextBox";
            this.FriendlyNameTextBox.Size = new System.Drawing.Size(301, 35);
            this.FriendlyNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dns Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Friendly Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Validity (in years):";
            // 
            // ShowPasswordPictureBox
            // 
            this.ShowPasswordPictureBox.BackgroundImage = global::CertificateCreator.Properties.Resources.eye_icon;
            this.ShowPasswordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowPasswordPictureBox.Location = new System.Drawing.Point(537, 234);
            this.ShowPasswordPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowPasswordPictureBox.Name = "ShowPasswordPictureBox";
            this.ShowPasswordPictureBox.Size = new System.Drawing.Size(45, 44);
            this.ShowPasswordPictureBox.TabIndex = 9;
            this.ShowPasswordPictureBox.TabStop = false;
            this.ShowPasswordPictureBox.Tag = "";
            this.ShowPasswordPictureBox.Click += new System.EventHandler(this.ShowPasswordPictureBoxClick);
            this.ShowPasswordPictureBox.MouseEnter += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            this.ShowPasswordPictureBox.MouseLeave += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(199, 88);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(301, 35);
            this.CountryTextBox.TabIndex = 1;
            this.CountryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CountryTextBox_Validating);
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(105, 92);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(91, 30);
            this.CountryLabel.TabIndex = 11;
            this.CountryLabel.Text = "Country:";
            // 
            // IdpFormErrorProvider
            // 
            this.IdpFormErrorProvider.ContainerControl = this;
            // 
            // IdpCertUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.ShowPasswordPictureBox);
            this.Controls.Add(this.CreateCertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DnsNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValidityNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FriendlyNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "IdpCertUserControl";
            this.Size = new System.Drawing.Size(605, 510);
            ((System.ComponentModel.ISupportInitialize)(this.ValidityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdpFormErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button CreateCertButton;
        private System.Windows.Forms.TextBox DnsNameTextBox;
        private System.Windows.Forms.NumericUpDown ValidityNumericUpDown;
        private System.Windows.Forms.SaveFileDialog CertSaveFileDialog;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox FriendlyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


        #endregion

        private System.Windows.Forms.PictureBox ShowPasswordPictureBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.ErrorProvider IdpFormErrorProvider;
    }
}
