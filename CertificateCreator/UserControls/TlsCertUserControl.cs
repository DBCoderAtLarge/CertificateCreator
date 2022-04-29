using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Infrastructure.Logging;
using CertificateCreator.Infrastructure.Messaging;
using CertificateCreator.Infrastructure.Ui;
using CertificateCreator.Models;
using CertificateCreator.Properties;
using CertificateCreator.Validation;
using CertificateCreator.Views;
using FluentValidation;
using WinFormsMVP.NET.Binder;
using WinFormsMVP.NET.Forms;

namespace CertificateCreator.UserControls
{
    public partial class TlsCertUserControl : MvpUserControl, ITlsCertView
    {
        private const string TlsPrefix = "Tls";
        private const string ExistingRootCertGroupBoxName = "ExistingRootCertGroupBox";
        private readonly ErrorTracker _errorTrackerRoot;
        private readonly ErrorTracker _errorTrackerTls;
        private readonly IDispatchEventCommand _submitRootCommand;
        private readonly IDispatchEventCommand _submitTlsCommand;
        private readonly IValidator<CertDetailsViewModel> _rootCertificateValidator = new CertificateValidator();
        private readonly IValidator<CertDetailsViewModel> _tlsCertificateValidator = new CertificateValidator();
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        private GroupBox _existingRootGroupBox;

        private Button _setRootFromExistingCertButton;
        private TextBox _existingCertPasswordTextBox;
        private string _selectedCertificatePath;

        public TlsCertUserControl()
        {
            // Register for the event which sets the focus for the app on start. In this case, the RootDnsNameTextBox.
            PresenterBinder.MessageBus.Register<bool>(
                this,
                MessageTokens.SetFocusedControlOnStartup,
                msg =>
            {
                RootDnsNameTextBox.Focus();
            });

            InitializeComponent();

            _errorTrackerRoot = new ErrorTracker(RootErrorProvider);
            _errorTrackerTls = new ErrorTracker(TlsErrorProvider);

            _submitRootCommand = new DispatchEventCommand(
                CreateRootCertAction,
                ValidateRootGroupBox,
                () => _errorTrackerRoot.None()
            );

            _submitTlsCommand = new DispatchEventCommand(
                CreateTlsCertAction,
                ValidateTlsGroupBox,
                () => _errorTrackerTls.None()
            );

            Model = new TlsCertDetailsViewModel();
            Model.CertDetailsViewModelForRoot = new CertDetailsViewModel();
            Model.CertDetailsViewModelForTls = new CertDetailsViewModel();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RootErrorProvider.SetIcon(SystemIcons.Warning, new Size(32, 32));
            TlsErrorProvider.SetIcon(SystemIcons.Warning, new Size(32, 32));

            Model.CertDetailsViewModelForRoot.FormEnabled = true;

            SetupDataBindings(Model);
        }

        public TlsCertDetailsViewModel Model { get; set; }

        public event Action<TlsControlState> ProceedToTlsCreation;
        public event Action Reset;
        public event Action SendRootCertificateDetails;
        public event Action SendTlsCertificateDetails;
        public event EventHandler<string> LogMessage;
        public event Action<string, string> SendTlsCertificateFromExistingRoot;
        public event Action SendExistingRootCertificateDetails;

        public void SetupDataBindings(TlsCertDetailsViewModel viewModel)
        {
            var tlsControls = TlsCertGroupBox.Controls;
            var rootControls = RootCertGroupBox.Controls;

            ClearBindings(tlsControls);
            ClearBindings(rootControls);
            BindEnabledPropertyToControls(tlsControls, Model.CertDetailsViewModelForTls);
            BindEnabledPropertyToControls(rootControls, Model.CertDetailsViewModelForRoot);

            RootCommonNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.CommonName), false, DataSourceUpdateMode.OnPropertyChanged);
            RootCountryTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.Country), false, DataSourceUpdateMode.OnPropertyChanged);
            RootDnsNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.DnsName), false, DataSourceUpdateMode.OnPropertyChanged);
            RootFriendlyNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.FriendlyName), false, DataSourceUpdateMode.OnPropertyChanged);
            RootPasswordTextBox.DataBindings.Add(nameof(TextBox.PasswordChar), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.PasswordMask), false, DataSourceUpdateMode.OnPropertyChanged);
            RootPasswordTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            RootShowPasswordPictureBox.DataBindings.Add(nameof(PictureBox.BackgroundImage), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.PasswordHover), false, DataSourceUpdateMode.OnPropertyChanged);
            RootValidFromDateTimePicker.DataBindings.Add(nameof(DateTimePicker.Value), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.ValidFrom), false, DataSourceUpdateMode.OnPropertyChanged);
            RootValidToDateTimePicker.DataBindings.Add(nameof(DateTimePicker.Value), viewModel.CertDetailsViewModelForRoot,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForRoot.ValidTo), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsCommonNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.CommonName), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsCountryTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.Country), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsFriendlyNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.FriendlyName), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsDnsNameTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.DnsName), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsPasswordTextBox.DataBindings.Add(nameof(TextBox.PasswordChar), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.PasswordMask), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsPasswordTextBox.DataBindings.Add(nameof(TextBox.Text), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsShowPasswordPictureBox.DataBindings.Add(nameof(PictureBox.BackgroundImage), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.PasswordHover), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsValidFromDateTimePicker.DataBindings.Add(nameof(DateTimePicker.Value), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.ValidFrom), false, DataSourceUpdateMode.OnPropertyChanged);
            TlsValidToDateTimePicker.DataBindings.Add(nameof(DateTimePicker.Value), viewModel.CertDetailsViewModelForTls,
                nameof(TlsCertDetailsViewModel.CertDetailsViewModelForTls.ValidTo), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void ClearBindings(IEnumerable controls)
        {
            foreach (var formControls in controls.OfType<TextBox>()
                    .Concat(controls.OfType<DateTimePicker>().Cast<Control>())
                    .Concat(controls.OfType<PictureBox>())
                    .Concat(controls.OfType<Button>()))
            {
                formControls.DataBindings.Clear();
            }
        }

        private void BindEnabledPropertyToControls(IEnumerable controls, CertDetailsViewModel viewModel)
        {
            // Bind FormEnabled for all formControl.
            foreach (var formControl in
                controls.OfType<TextBox>()
                    .Concat(controls.OfType<DateTimePicker>().Cast<Control>())
                    .Concat(controls.OfType<Button>())
            )
            {
                formControl.DataBindings.Add(
                    nameof(Enabled),
                    viewModel,
                    nameof(CertDetailsViewModel.FormEnabled),
                    false,
                    DataSourceUpdateMode.OnPropertyChanged
                );
            }
        }

        public void ConfigureDefaults(IApplicationConfiguration applicationConfiguration)
        {
            if (applicationConfiguration == null) throw new ArgumentNullException(nameof(applicationConfiguration));

            Model.CertDetailsViewModelForRoot.Country = applicationConfiguration.Country ?? string.Empty;
            Model.CertDetailsViewModelForTls.Country = applicationConfiguration.Country ?? string.Empty;

            var span = (int)(applicationConfiguration.DefaultFutureDateSpan ?? UiConstants.DefaultNumericUpDownValue);

            Model.CertDetailsViewModelForRoot.ValidFrom = DateTime.Today;
            Model.CertDetailsViewModelForTls.ValidFrom = DateTime.Today;
            Model.CertDetailsViewModelForRoot.ValidTo = DateTime.Today.AddYears(span);
            Model.CertDetailsViewModelForTls.ValidTo = DateTime.Today.AddYears(span);
        }

        public void PersistRootCertificate()
        {
            if (SaveCertificateFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(
                    SaveCertificateFileDialog.FileName,
                    Model.RootCertificateInBytes
                    );

                LogMessage?.Invoke(
                    this,
                   string.Format(LogMessages.RootCertificateCreated, SaveCertificateFileDialog.FileName)
                    );

                ProceedToTlsCreation?.Invoke(TlsControlState.TlsEnabledFromNewRoot);
            }
            else
            {
                LogMessage?.Invoke(this, LogMessages.RootCertOperationCancelled);
            }
        }

        public void PersistTlsCertificate()
        {
            if (SaveCertificateFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(
                    SaveCertificateFileDialog.FileName,
                    Model.TlsCertificateInBytes
                );

                LogMessage?.Invoke(
                    this,
                    string.Format(LogMessages.TlsCertificateCreated, SaveCertificateFileDialog.FileName)
                    );

                ProceedToTlsCreation?.Invoke(TlsControlState.FullReset);
            }
            else
            {
                LogMessage?.Invoke(this, LogMessages.TlsCertOperationCancelled);
            }
        }

        private void CreateRootCertButtonClick(object sender, EventArgs e)
        {
            if (_submitRootCommand.CanExecute())
                _submitRootCommand.ExecuteCommand();
        }

        private void CreateTlsCertButton_Click(object sender, EventArgs e)
        {
            if (_submitTlsCommand.CanExecute())
                _submitTlsCommand.ExecuteCommand();
        }

        private void CreateRootCertAction()
        {
            SendRootCertificateDetails?.Invoke();
        }

        private void CreateTlsCertAction()
        {
            SendTlsCertificateDetails?.Invoke();
        }

        private void DnsNameTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Tag is string prefix)
            {
                if (prefix.Equals(TlsPrefix))
                {
                    Model.CertDetailsViewModelForTls.CommonName = Model.CertDetailsViewModelForTls.DnsName;
                }
                else
                {
                    Model.CertDetailsViewModelForRoot.CommonName = Model.CertDetailsViewModelForRoot.DnsName;
                }
            }
        }

        private void DnsNameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            var dnsTextBox = (TextBox)sender;
            var name = dnsTextBox.Name;
            var prefix = name.Substring(0, name.IndexOf("Dns", StringComparison.Ordinal));

            if (char.IsControl(e.KeyChar))
            {
                ((TextBox)sender).Tag = prefix;
            }
            else
            {
                ((TextBox)sender).Tag = null;

                if (prefix.Equals(TlsPrefix))
                    Model.CertDetailsViewModelForTls.CommonName += e.KeyChar;
                else
                    Model.CertDetailsViewModelForRoot.CommonName += e.KeyChar;
            }
        }

        private void ShowPasswordPictureBoxMouseEvents(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            var name = pictureBox.Name;

            if (Cursor == Cursors.Arrow)
            {
                // transition from not hovering to hovering
                Cursor = Cursors.Hand;
                if (name.StartsWith(TlsPrefix))
                {
                    Model.CertDetailsViewModelForTls.PasswordHover = Resources.eye_icon_hover;
                }
                else
                {
                    Model.CertDetailsViewModelForRoot.PasswordHover = Resources.eye_icon_hover;
                }
            }
            else
            {
                // transition from hovering to not hovering
                Cursor = Cursors.Arrow;
                if (name.StartsWith(TlsPrefix))
                {
                    Model.CertDetailsViewModelForTls.PasswordHover = Resources.eye_icon;
                }
                else
                {
                    Model.CertDetailsViewModelForRoot.PasswordHover = Resources.eye_icon;
                }
            }
        }

        private void ShowPasswordPictureBoxClick(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            var name = pictureBox.Name;

            if (name.StartsWith(TlsPrefix))
            {
                Model.CertDetailsViewModelForTls.PasswordMask =
                    Model.CertDetailsViewModelForTls.PasswordMask.Equals(UiConstants.PasswordMask)
                        ? UiConstants.PasswordNullMask
                        : UiConstants.PasswordMask;
            }
            else
            {
                Model.CertDetailsViewModelForRoot.PasswordMask =
                    Model.CertDetailsViewModelForRoot.PasswordMask.Equals(UiConstants.PasswordMask)
                        ? UiConstants.PasswordNullMask
                        : UiConstants.PasswordMask;
            }
        }

        private bool ValidateRootGroupBox()
        {
            foreach (Control c in RootCertGroupBox.Controls)
                c.Focus();

            return _errorTrackerRoot.None();
        }

        private bool ValidateTlsGroupBox()
        {
            foreach (Control c in TlsCertGroupBox.Controls)
                c.Focus();

            return _errorTrackerTls.None();
        }

        private void RootDnsNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _rootCertificateValidator.Validate(
                Model.CertDetailsViewModelForRoot,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForRoot.DnsName))
            );

            _errorTrackerRoot.ProcessValidationResult(validationResult, RootDnsNameTextBox);
        }


        private void RootCommonNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _rootCertificateValidator.Validate(
                Model.CertDetailsViewModelForRoot,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForRoot.CommonName))
            );

            _errorTrackerRoot.ProcessValidationResult(validationResult, RootCommonNameTextBox);
        }

        private void RootCountryTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _rootCertificateValidator.Validate(
                Model.CertDetailsViewModelForRoot,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForRoot.Country))
            );

            _errorTrackerRoot.ProcessValidationResult(validationResult, RootCountryTextBox);
        }

        private void RootPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _rootCertificateValidator.Validate(
                Model.CertDetailsViewModelForRoot,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForRoot.Password))
            );

            _errorTrackerRoot.ProcessValidationResult(validationResult, RootPasswordTextBox);
        }

        private void TlsDnsNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _tlsCertificateValidator.Validate(
                Model.CertDetailsViewModelForTls,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForTls.DnsName))
            );

            _errorTrackerTls.ProcessValidationResult(validationResult, TlsDnsNameTextBox);
        }

        private void TlsCommonNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _tlsCertificateValidator.Validate(
                Model.CertDetailsViewModelForTls,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForTls.CommonName))
            );

            _errorTrackerTls.ProcessValidationResult(validationResult, TlsCommonNameTextBox);
        }

        private void TlsCountryTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _tlsCertificateValidator.Validate(
                Model.CertDetailsViewModelForTls,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForTls.Country))
            );

            _errorTrackerTls.ProcessValidationResult(validationResult, TlsCountryTextBox);
        }

        private void TlsPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var validationResult = _tlsCertificateValidator.Validate(
                Model.CertDetailsViewModelForTls,
                o => o.IncludeProperties(nameof(Model.CertDetailsViewModelForTls.Password))
            );

            _errorTrackerTls.ProcessValidationResult(validationResult, TlsPasswordTextBox);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset?.Invoke();
        }

        public void Rebind(IApplicationConfiguration applicationConfiguration)
        {
            SetupDataBindings(Model);
            ConfigureDefaults(applicationConfiguration);
        }

        private void chkUseExistingRootCert_CheckedChanged(object sender, EventArgs e)
        {
            var chkBox = (CheckBox)sender;

            if (chkBox.Checked)
            {
                Controls.RemoveByKey("RootCertGroupBox");
                AddExistingRootGroupBox();
            }
            else
            {
                if(_existingRootGroupBox == null)
                    _existingRootGroupBox = Controls[ExistingRootCertGroupBoxName] as GroupBox;

                Controls.RemoveByKey(ExistingRootCertGroupBoxName);
                Controls.Add(RootCertGroupBox);
            }

            //rootCertGroupBox.Dispose();
        }

        public void SetControlState(TlsControlState state)
        {
            if (state == TlsControlState.TlsEnabledFromExistingRoot)
            {
                _existingCertPasswordTextBox.Enabled = false;
                _setRootFromExistingCertButton.Enabled = false;

                Model.CertDetailsViewModelForTls.FormEnabled = true;
            }
            else
            {
                switch (state)
                {
                    case TlsControlState.TlsEnabledFromNewRoot:
                        Model.CertDetailsViewModelForRoot.FormEnabled = false;
                        Model.CertDetailsViewModelForTls.FormEnabled = true;
                        break;
                    case TlsControlState.FullReset:
                    default:

                        if (chkUseExistingRootCert.Checked)
                        {
                            _existingRootGroupBox = Controls[ExistingRootCertGroupBoxName] as GroupBox;
                            Controls.RemoveByKey(ExistingRootCertGroupBoxName);
                            Controls.Add(RootCertGroupBox);

                            chkUseExistingRootCert.Checked = false;
                        }

                        Model.CertDetailsViewModelForRoot.FormEnabled = true;
                        Model.CertDetailsViewModelForTls.FormEnabled = false;
                        break;
                }
            }
        }

        private void AddExistingRootGroupBox()
        {
            if(_existingRootGroupBox == null)
            {
                _existingRootGroupBox = new GroupBox();
                var chooseCertFile = new Button();
                _existingCertPasswordTextBox = new TextBox();
                _setRootFromExistingCertButton = new Button();

                _existingRootGroupBox.SuspendLayout();

                _existingRootGroupBox.Location = new Point(11, 12);
                _existingRootGroupBox.Name = ExistingRootCertGroupBoxName;
                _existingRootGroupBox.Size = new Size(380, 320);
                _existingRootGroupBox.TabIndex = 1;
                _existingRootGroupBox.TabStop = false;
                _existingRootGroupBox.Text = "Existing Root Certificate";


                chooseCertFile.Location = new Point(20, 20);
                chooseCertFile.Size = new Size(160, 26);
                chooseCertFile.Name = "ChooseCertFile";
                chooseCertFile.Text = "Choose Root Cert File";
                chooseCertFile.Click += ChooseCertFile_Click;

                _existingCertPasswordTextBox.Location = new Point(20, 60);
                _existingCertPasswordTextBox.Name = "existingCertPasswordTextBox";
                _existingCertPasswordTextBox.PasswordChar = '*';
                _existingCertPasswordTextBox.Size = new Size(100, 23);

                _setRootFromExistingCertButton.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
                _setRootFromExistingCertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                _setRootFromExistingCertButton.ForeColor = Color.White;
                _setRootFromExistingCertButton.Location = new Point(20, 100);
                _setRootFromExistingCertButton.Name = "setRootFromExistingCertButton";
                _setRootFromExistingCertButton.Size = new Size(166, 52);
                //setRootFromExistingCertButton.TabIndex = 200;
                _setRootFromExistingCertButton.Text = "Set Root Certificate";
                _setRootFromExistingCertButton.UseVisualStyleBackColor = false;
                _setRootFromExistingCertButton.Click += _setRootFromExistingCertButton_Click;

                _existingRootGroupBox.Controls.Add(_setRootFromExistingCertButton);
                _existingRootGroupBox.Controls.Add(chooseCertFile);
                _existingRootGroupBox.Controls.Add(_existingCertPasswordTextBox);

                _existingRootGroupBox.ResumeLayout(false);
                _existingRootGroupBox.PerformLayout();
            }

            Controls.Add(_existingRootGroupBox);
        }

        private void _setRootFromExistingCertButton_Click(object sender, EventArgs e)
        {
            SendTlsCertificateFromExistingRoot?.Invoke(_selectedCertificatePath, _existingCertPasswordTextBox.Text.Trim());
        }

        private void ChooseCertFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedCertificatePath = openFileDialog.FileName.Trim();
            }
        }
    }
}
