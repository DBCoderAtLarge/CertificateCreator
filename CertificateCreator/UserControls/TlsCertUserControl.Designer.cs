
namespace CertificateCreator.UserControls
{
    partial class TlsCertUserControl
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
            this.RootCertGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RootShowPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.RootPasswordLabel = new System.Windows.Forms.Label();
            this.RootFriendlyNameLabel = new System.Windows.Forms.Label();
            this.RootCountryLabel = new System.Windows.Forms.Label();
            this.RootCommonNameLabel = new System.Windows.Forms.Label();
            this.RootDnsNameLabel = new System.Windows.Forms.Label();
            this.RootPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RootFriendlyNameTextBox = new System.Windows.Forms.TextBox();
            this.RootCountryTextBox = new System.Windows.Forms.TextBox();
            this.RootCommonNameTextBox = new System.Windows.Forms.TextBox();
            this.RootDnsNameTextBox = new System.Windows.Forms.TextBox();
            this.RootValidToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RootValidFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateRootCertButton = new System.Windows.Forms.Button();
            this.TlsCertGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TlsShowPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.TlsPasswordLabel = new System.Windows.Forms.Label();
            this.TlsFriendlyNameLabel = new System.Windows.Forms.Label();
            this.TlsCountryLabel = new System.Windows.Forms.Label();
            this.TlsCommonNameLabel = new System.Windows.Forms.Label();
            this.TlsDnsNameLabel = new System.Windows.Forms.Label();
            this.TlsPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TlsFriendlyNameTextBox = new System.Windows.Forms.TextBox();
            this.TlsCountryTextBox = new System.Windows.Forms.TextBox();
            this.TlsCommonNameTextBox = new System.Windows.Forms.TextBox();
            this.TlsDnsNameTextBox = new System.Windows.Forms.TextBox();
            this.TlsValidToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TlsValidFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateTlsCertButton = new System.Windows.Forms.Button();
            this.SaveCertificateFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RootErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TlsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.chkUseExistingRootCert = new System.Windows.Forms.CheckBox();
            this.RootCertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootShowPasswordPictureBox)).BeginInit();
            this.TlsCertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TlsShowPasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TlsErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // RootCertGroupBox
            // 
            this.RootCertGroupBox.Controls.Add(this.label3);
            this.RootCertGroupBox.Controls.Add(this.label1);
            this.RootCertGroupBox.Controls.Add(this.RootShowPasswordPictureBox);
            this.RootCertGroupBox.Controls.Add(this.RootPasswordLabel);
            this.RootCertGroupBox.Controls.Add(this.RootFriendlyNameLabel);
            this.RootCertGroupBox.Controls.Add(this.RootCountryLabel);
            this.RootCertGroupBox.Controls.Add(this.RootCommonNameLabel);
            this.RootCertGroupBox.Controls.Add(this.RootDnsNameLabel);
            this.RootCertGroupBox.Controls.Add(this.RootPasswordTextBox);
            this.RootCertGroupBox.Controls.Add(this.RootFriendlyNameTextBox);
            this.RootCertGroupBox.Controls.Add(this.RootCountryTextBox);
            this.RootCertGroupBox.Controls.Add(this.RootCommonNameTextBox);
            this.RootCertGroupBox.Controls.Add(this.RootDnsNameTextBox);
            this.RootCertGroupBox.Controls.Add(this.RootValidToDateTimePicker);
            this.RootCertGroupBox.Controls.Add(this.RootValidFromDateTimePicker);
            this.RootCertGroupBox.Controls.Add(this.CreateRootCertButton);
            this.RootCertGroupBox.Location = new System.Drawing.Point(11, 12);
            this.RootCertGroupBox.Name = "RootCertGroupBox";
            this.RootCertGroupBox.Size = new System.Drawing.Size(380, 320);
            this.RootCertGroupBox.TabIndex = 0;
            this.RootCertGroupBox.TabStop = false;
            this.RootCertGroupBox.Text = "Root Certificate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 102;
            this.label3.Text = "Valid To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 101;
            this.label1.Text = "Valid From:";
            // 
            // RootShowPasswordPictureBox
            // 
            this.RootShowPasswordPictureBox.BackgroundImage = global::CertificateCreator.Properties.Resources.eye_icon;
            this.RootShowPasswordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RootShowPasswordPictureBox.Location = new System.Drawing.Point(245, 156);
            this.RootShowPasswordPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.RootShowPasswordPictureBox.Name = "RootShowPasswordPictureBox";
            this.RootShowPasswordPictureBox.Size = new System.Drawing.Size(26, 22);
            this.RootShowPasswordPictureBox.TabIndex = 13;
            this.RootShowPasswordPictureBox.TabStop = false;
            this.RootShowPasswordPictureBox.Tag = "";
            this.RootShowPasswordPictureBox.Click += new System.EventHandler(this.ShowPasswordPictureBoxClick);
            this.RootShowPasswordPictureBox.MouseEnter += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            this.RootShowPasswordPictureBox.MouseLeave += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            // 
            // RootPasswordLabel
            // 
            this.RootPasswordLabel.AutoSize = true;
            this.RootPasswordLabel.Location = new System.Drawing.Point(50, 156);
            this.RootPasswordLabel.Name = "RootPasswordLabel";
            this.RootPasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.RootPasswordLabel.TabIndex = 12;
            this.RootPasswordLabel.Text = "Password:";
            // 
            // RootFriendlyNameLabel
            // 
            this.RootFriendlyNameLabel.AutoSize = true;
            this.RootFriendlyNameLabel.Location = new System.Drawing.Point(23, 126);
            this.RootFriendlyNameLabel.Name = "RootFriendlyNameLabel";
            this.RootFriendlyNameLabel.Size = new System.Drawing.Size(87, 15);
            this.RootFriendlyNameLabel.TabIndex = 11;
            this.RootFriendlyNameLabel.Text = "Friendly Name:";
            // 
            // RootCountryLabel
            // 
            this.RootCountryLabel.AutoSize = true;
            this.RootCountryLabel.Location = new System.Drawing.Point(57, 96);
            this.RootCountryLabel.Name = "RootCountryLabel";
            this.RootCountryLabel.Size = new System.Drawing.Size(53, 15);
            this.RootCountryLabel.TabIndex = 10;
            this.RootCountryLabel.Text = "Country:";
            // 
            // RootCommonNameLabel
            // 
            this.RootCommonNameLabel.AutoSize = true;
            this.RootCommonNameLabel.Location = new System.Drawing.Point(14, 65);
            this.RootCommonNameLabel.Name = "RootCommonNameLabel";
            this.RootCommonNameLabel.Size = new System.Drawing.Size(96, 15);
            this.RootCommonNameLabel.TabIndex = 9;
            this.RootCommonNameLabel.Text = "Common Name:";
            // 
            // RootDnsNameLabel
            // 
            this.RootDnsNameLabel.AutoSize = true;
            this.RootDnsNameLabel.Location = new System.Drawing.Point(45, 34);
            this.RootDnsNameLabel.Name = "RootDnsNameLabel";
            this.RootDnsNameLabel.Size = new System.Drawing.Size(65, 15);
            this.RootDnsNameLabel.TabIndex = 8;
            this.RootDnsNameLabel.Text = "Dns Name:";
            // 
            // RootPasswordTextBox
            // 
            this.RootPasswordTextBox.Location = new System.Drawing.Point(114, 157);
            this.RootPasswordTextBox.Name = "RootPasswordTextBox";
            this.RootPasswordTextBox.PasswordChar = '*';
            this.RootPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.RootPasswordTextBox.TabIndex = 4;
            this.RootPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RootPasswordTextBox_Validating);
            // 
            // RootFriendlyNameTextBox
            // 
            this.RootFriendlyNameTextBox.Location = new System.Drawing.Point(114, 126);
            this.RootFriendlyNameTextBox.Name = "RootFriendlyNameTextBox";
            this.RootFriendlyNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.RootFriendlyNameTextBox.TabIndex = 3;
            // 
            // RootCountryTextBox
            // 
            this.RootCountryTextBox.Location = new System.Drawing.Point(114, 95);
            this.RootCountryTextBox.Name = "RootCountryTextBox";
            this.RootCountryTextBox.Size = new System.Drawing.Size(100, 23);
            this.RootCountryTextBox.TabIndex = 2;
            this.RootCountryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RootCountryTextBox_Validating);
            // 
            // RootCommonNameTextBox
            // 
            this.RootCommonNameTextBox.Location = new System.Drawing.Point(114, 64);
            this.RootCommonNameTextBox.Name = "RootCommonNameTextBox";
            this.RootCommonNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.RootCommonNameTextBox.TabIndex = 1;
            this.RootCommonNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RootCommonNameTextBox_Validating);
            // 
            // RootDnsNameTextBox
            // 
            this.RootDnsNameTextBox.Location = new System.Drawing.Point(114, 33);
            this.RootDnsNameTextBox.Name = "RootDnsNameTextBox";
            this.RootDnsNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.RootDnsNameTextBox.TabIndex = 0;
            this.RootDnsNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DnsNameTextBoxKeyPress);
            this.RootDnsNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DnsNameTextBoxKeyUp);
            this.RootDnsNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RootDnsNameTextBox_Validating);
            // 
            // RootValidToDateTimePicker
            // 
            this.RootValidToDateTimePicker.Location = new System.Drawing.Point(114, 216);
            this.RootValidToDateTimePicker.Name = "RootValidToDateTimePicker";
            this.RootValidToDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.RootValidToDateTimePicker.TabIndex = 6;
            // 
            // RootValidFromDateTimePicker
            // 
            this.RootValidFromDateTimePicker.Location = new System.Drawing.Point(114, 186);
            this.RootValidFromDateTimePicker.Name = "RootValidFromDateTimePicker";
            this.RootValidFromDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.RootValidFromDateTimePicker.TabIndex = 5;
            // 
            // CreateRootCertButton
            // 
            this.CreateRootCertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.CreateRootCertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateRootCertButton.ForeColor = System.Drawing.Color.White;
            this.CreateRootCertButton.Location = new System.Drawing.Point(114, 255);
            this.CreateRootCertButton.Name = "CreateRootCertButton";
            this.CreateRootCertButton.Size = new System.Drawing.Size(166, 52);
            this.CreateRootCertButton.TabIndex = 100;
            this.CreateRootCertButton.Text = "Create Root Certificate";
            this.CreateRootCertButton.UseVisualStyleBackColor = false;
            this.CreateRootCertButton.Click += new System.EventHandler(this.CreateRootCertButtonClick);
            // 
            // TlsCertGroupBox
            // 
            this.TlsCertGroupBox.Controls.Add(this.label4);
            this.TlsCertGroupBox.Controls.Add(this.label2);
            this.TlsCertGroupBox.Controls.Add(this.TlsShowPasswordPictureBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsPasswordLabel);
            this.TlsCertGroupBox.Controls.Add(this.TlsFriendlyNameLabel);
            this.TlsCertGroupBox.Controls.Add(this.TlsCountryLabel);
            this.TlsCertGroupBox.Controls.Add(this.TlsCommonNameLabel);
            this.TlsCertGroupBox.Controls.Add(this.TlsDnsNameLabel);
            this.TlsCertGroupBox.Controls.Add(this.TlsPasswordTextBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsFriendlyNameTextBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsCountryTextBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsCommonNameTextBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsDnsNameTextBox);
            this.TlsCertGroupBox.Controls.Add(this.TlsValidToDateTimePicker);
            this.TlsCertGroupBox.Controls.Add(this.TlsValidFromDateTimePicker);
            this.TlsCertGroupBox.Controls.Add(this.CreateTlsCertButton);
            this.TlsCertGroupBox.Location = new System.Drawing.Point(397, 12);
            this.TlsCertGroupBox.Name = "TlsCertGroupBox";
            this.TlsCertGroupBox.Size = new System.Drawing.Size(380, 320);
            this.TlsCertGroupBox.TabIndex = 1;
            this.TlsCertGroupBox.TabStop = false;
            this.TlsCertGroupBox.Text = "TLS Certificate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 103;
            this.label4.Text = "Valid To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 102;
            this.label2.Text = "Valid From:";
            // 
            // TlsShowPasswordPictureBox
            // 
            this.TlsShowPasswordPictureBox.BackgroundImage = global::CertificateCreator.Properties.Resources.eye_icon;
            this.TlsShowPasswordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TlsShowPasswordPictureBox.Location = new System.Drawing.Point(276, 155);
            this.TlsShowPasswordPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.TlsShowPasswordPictureBox.Name = "TlsShowPasswordPictureBox";
            this.TlsShowPasswordPictureBox.Size = new System.Drawing.Size(26, 22);
            this.TlsShowPasswordPictureBox.TabIndex = 21;
            this.TlsShowPasswordPictureBox.TabStop = false;
            this.TlsShowPasswordPictureBox.Tag = "";
            this.TlsShowPasswordPictureBox.Click += new System.EventHandler(this.ShowPasswordPictureBoxClick);
            this.TlsShowPasswordPictureBox.MouseEnter += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            this.TlsShowPasswordPictureBox.MouseLeave += new System.EventHandler(this.ShowPasswordPictureBoxMouseEvents);
            // 
            // TlsPasswordLabel
            // 
            this.TlsPasswordLabel.AutoSize = true;
            this.TlsPasswordLabel.Location = new System.Drawing.Point(79, 156);
            this.TlsPasswordLabel.Name = "TlsPasswordLabel";
            this.TlsPasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.TlsPasswordLabel.TabIndex = 20;
            this.TlsPasswordLabel.Text = "Password:";
            // 
            // TlsFriendlyNameLabel
            // 
            this.TlsFriendlyNameLabel.AutoSize = true;
            this.TlsFriendlyNameLabel.Location = new System.Drawing.Point(52, 125);
            this.TlsFriendlyNameLabel.Name = "TlsFriendlyNameLabel";
            this.TlsFriendlyNameLabel.Size = new System.Drawing.Size(87, 15);
            this.TlsFriendlyNameLabel.TabIndex = 19;
            this.TlsFriendlyNameLabel.Text = "Friendly Name:";
            // 
            // TlsCountryLabel
            // 
            this.TlsCountryLabel.AutoSize = true;
            this.TlsCountryLabel.Location = new System.Drawing.Point(86, 94);
            this.TlsCountryLabel.Name = "TlsCountryLabel";
            this.TlsCountryLabel.Size = new System.Drawing.Size(53, 15);
            this.TlsCountryLabel.TabIndex = 18;
            this.TlsCountryLabel.Text = "Country:";
            // 
            // TlsCommonNameLabel
            // 
            this.TlsCommonNameLabel.AutoSize = true;
            this.TlsCommonNameLabel.Location = new System.Drawing.Point(43, 64);
            this.TlsCommonNameLabel.Name = "TlsCommonNameLabel";
            this.TlsCommonNameLabel.Size = new System.Drawing.Size(96, 15);
            this.TlsCommonNameLabel.TabIndex = 17;
            this.TlsCommonNameLabel.Text = "Common Name:";
            // 
            // TlsDnsNameLabel
            // 
            this.TlsDnsNameLabel.AutoSize = true;
            this.TlsDnsNameLabel.Location = new System.Drawing.Point(74, 34);
            this.TlsDnsNameLabel.Name = "TlsDnsNameLabel";
            this.TlsDnsNameLabel.Size = new System.Drawing.Size(65, 15);
            this.TlsDnsNameLabel.TabIndex = 16;
            this.TlsDnsNameLabel.Text = "Dns Name:";
            // 
            // TlsPasswordTextBox
            // 
            this.TlsPasswordTextBox.Location = new System.Drawing.Point(145, 157);
            this.TlsPasswordTextBox.Name = "TlsPasswordTextBox";
            this.TlsPasswordTextBox.PasswordChar = '*';
            this.TlsPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.TlsPasswordTextBox.TabIndex = 11;
            this.TlsPasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TlsPasswordTextBox_Validating);
            // 
            // TlsFriendlyNameTextBox
            // 
            this.TlsFriendlyNameTextBox.Location = new System.Drawing.Point(145, 126);
            this.TlsFriendlyNameTextBox.Name = "TlsFriendlyNameTextBox";
            this.TlsFriendlyNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.TlsFriendlyNameTextBox.TabIndex = 10;
            // 
            // TlsCountryTextBox
            // 
            this.TlsCountryTextBox.Location = new System.Drawing.Point(145, 95);
            this.TlsCountryTextBox.Name = "TlsCountryTextBox";
            this.TlsCountryTextBox.Size = new System.Drawing.Size(100, 23);
            this.TlsCountryTextBox.TabIndex = 9;
            this.TlsCountryTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TlsCountryTextBox_Validating);
            // 
            // TlsCommonNameTextBox
            // 
            this.TlsCommonNameTextBox.Location = new System.Drawing.Point(145, 64);
            this.TlsCommonNameTextBox.Name = "TlsCommonNameTextBox";
            this.TlsCommonNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.TlsCommonNameTextBox.TabIndex = 8;
            this.TlsCommonNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TlsCommonNameTextBox_Validating);
            // 
            // TlsDnsNameTextBox
            // 
            this.TlsDnsNameTextBox.Location = new System.Drawing.Point(145, 33);
            this.TlsDnsNameTextBox.Name = "TlsDnsNameTextBox";
            this.TlsDnsNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.TlsDnsNameTextBox.TabIndex = 7;
            this.TlsDnsNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DnsNameTextBoxKeyPress);
            this.TlsDnsNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DnsNameTextBoxKeyUp);
            this.TlsDnsNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TlsDnsNameTextBox_Validating);
            // 
            // TlsValidToDateTimePicker
            // 
            this.TlsValidToDateTimePicker.Location = new System.Drawing.Point(145, 216);
            this.TlsValidToDateTimePicker.Name = "TlsValidToDateTimePicker";
            this.TlsValidToDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.TlsValidToDateTimePicker.TabIndex = 13;
            // 
            // TlsValidFromDateTimePicker
            // 
            this.TlsValidFromDateTimePicker.Location = new System.Drawing.Point(145, 186);
            this.TlsValidFromDateTimePicker.Name = "TlsValidFromDateTimePicker";
            this.TlsValidFromDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.TlsValidFromDateTimePicker.TabIndex = 12;
            // 
            // CreateTlsCertButton
            // 
            this.CreateTlsCertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.CreateTlsCertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTlsCertButton.ForeColor = System.Drawing.Color.White;
            this.CreateTlsCertButton.Location = new System.Drawing.Point(145, 255);
            this.CreateTlsCertButton.Name = "CreateTlsCertButton";
            this.CreateTlsCertButton.Size = new System.Drawing.Size(166, 52);
            this.CreateTlsCertButton.TabIndex = 101;
            this.CreateTlsCertButton.Text = "Create TLS Certificate";
            this.CreateTlsCertButton.UseVisualStyleBackColor = false;
            this.CreateTlsCertButton.Click += new System.EventHandler(this.CreateTlsCertButton_Click);
            // 
            // SaveCertificateFileDialog
            // 
            this.SaveCertificateFileDialog.Filter = "\"Prvt Certs|*.pfx|Prvt Keys|*.cer|All Files|*.*\"";
            this.SaveCertificateFileDialog.RestoreDirectory = true;
            // 
            // RootErrorProvider
            // 
            this.RootErrorProvider.ContainerControl = this;
            // 
            // TlsErrorProvider
            // 
            this.TlsErrorProvider.ContainerControl = this;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(701, 338);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(76, 27);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // chkUseExistingRootCert
            // 
            this.chkUseExistingRootCert.AutoSize = true;
            this.chkUseExistingRootCert.Location = new System.Drawing.Point(10, 345);
            this.chkUseExistingRootCert.Name = "chkUseExistingRootCert";
            this.chkUseExistingRootCert.Size = new System.Drawing.Size(174, 19);
            this.chkUseExistingRootCert.TabIndex = 3;
            this.chkUseExistingRootCert.Text = "Use Existing Root Certificate";
            this.chkUseExistingRootCert.UseVisualStyleBackColor = true;
            //this.chkUseExistingRootCert.Visible = false;
            this.chkUseExistingRootCert.CheckedChanged += new System.EventHandler(this.chkUseExistingRootCert_CheckedChanged);
            // 
            // TlsCertUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUseExistingRootCert);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TlsCertGroupBox);
            this.Controls.Add(this.RootCertGroupBox);
            this.Name = "TlsCertUserControl";
            this.Size = new System.Drawing.Size(790, 376);
            this.RootCertGroupBox.ResumeLayout(false);
            this.RootCertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootShowPasswordPictureBox)).EndInit();
            this.TlsCertGroupBox.ResumeLayout(false);
            this.TlsCertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TlsShowPasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TlsErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RootCertGroupBox;
        private System.Windows.Forms.GroupBox TlsCertGroupBox;
        private System.Windows.Forms.Button CreateRootCertButton;
        private System.Windows.Forms.DateTimePicker RootValidToDateTimePicker;
        private System.Windows.Forms.DateTimePicker RootValidFromDateTimePicker;
        private System.Windows.Forms.TextBox RootPasswordTextBox;
        private System.Windows.Forms.TextBox RootFriendlyNameTextBox;
        private System.Windows.Forms.TextBox RootCountryTextBox;
        private System.Windows.Forms.TextBox RootCommonNameTextBox;
        private System.Windows.Forms.TextBox RootDnsNameTextBox;
        private System.Windows.Forms.TextBox TlsPasswordTextBox;
        private System.Windows.Forms.TextBox TlsFriendlyNameTextBox;
        private System.Windows.Forms.TextBox TlsCountryTextBox;
        private System.Windows.Forms.TextBox TlsCommonNameTextBox;
        private System.Windows.Forms.TextBox TlsDnsNameTextBox;
        private System.Windows.Forms.DateTimePicker TlsValidToDateTimePicker;
        private System.Windows.Forms.DateTimePicker TlsValidFromDateTimePicker;
        private System.Windows.Forms.Button CreateTlsCertButton;
        private System.Windows.Forms.SaveFileDialog SaveCertificateFileDialog;
        private System.Windows.Forms.Label RootPasswordLabel;
        private System.Windows.Forms.Label RootFriendlyNameLabel;
        private System.Windows.Forms.Label RootCountryLabel;
        private System.Windows.Forms.Label RootCommonNameLabel;
        private System.Windows.Forms.Label RootDnsNameLabel;
        private System.Windows.Forms.Label TlsPasswordLabel;
        private System.Windows.Forms.Label TlsFriendlyNameLabel;
        private System.Windows.Forms.Label TlsCountryLabel;
        private System.Windows.Forms.Label TlsCommonNameLabel;
        private System.Windows.Forms.Label TlsDnsNameLabel;
        private System.Windows.Forms.PictureBox RootShowPasswordPictureBox;
        private System.Windows.Forms.PictureBox TlsShowPasswordPictureBox;
        private System.Windows.Forms.ErrorProvider RootErrorProvider;
        private System.Windows.Forms.ErrorProvider TlsErrorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.CheckBox chkUseExistingRootCert;
    }
}
