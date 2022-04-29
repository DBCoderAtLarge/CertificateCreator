using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CertificateCreator.Events.Delegates;
using CertificateCreator.Events.EventArgs;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Infrastructure.Logging;
using CertificateCreator.Infrastructure.Ui;
using CertificateCreator.Models;
using CertificateCreator.Properties;
using CertificateCreator.Validation;
using CertificateCreator.Views;
using FluentValidation;
using WinFormsMVP.NET.Forms;

namespace CertificateCreator.UserControls
{
    public partial class IdpCertUserControl : MvpUserControl, IdpCertView
    {
        private readonly IdpCertDetailsViewModel _idpCertDetailsViewModel;
        private readonly ErrorTracker _errorTracker;
        private readonly IDispatchEventCommand<IdpCertificateDetailEventArgs> _submitCommand;
        private readonly IValidator<IdpCertDetailsViewModel> _idpFormValidator = new IdpCertificateValidator();

        public IdpCertUserControl()
        {
            InitializeComponent();

            _errorTracker = new ErrorTracker(IdpFormErrorProvider);

            _submitCommand = new DispatchEventCommand<IdpCertificateDetailEventArgs>(
                CreateCertAction,
                ValidateChildren,
                () => _errorTracker.None()
            );

            _idpCertDetailsViewModel = new IdpCertDetailsViewModel();

            SetupDataBindings();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IdpFormErrorProvider.SetIcon(SystemIcons.Warning, new Size(32, 32));
        }

        private void SetupDataBindings()
        {
            DnsNameTextBox.DataBindings.Add(nameof(TextBox.Text), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.DnsName), false, DataSourceUpdateMode.OnPropertyChanged);
            FriendlyNameTextBox.DataBindings.Add(nameof(TextBox.Text), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.FriendlyName), false, DataSourceUpdateMode.OnPropertyChanged);
            CountryTextBox.DataBindings.Add(nameof(TextBox.Text), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.Country), false, DataSourceUpdateMode.OnPropertyChanged);
            PasswordTextBox.DataBindings.Add(nameof(TextBox.Text), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);
            PasswordTextBox.DataBindings.Add(nameof(TextBox.PasswordChar), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.PasswordMask), false, DataSourceUpdateMode.OnPropertyChanged);
            ShowPasswordPictureBox.DataBindings.Add(nameof(PictureBox.BackgroundImage), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.PasswordHover), false, DataSourceUpdateMode.OnPropertyChanged);
            ValidityNumericUpDown.DataBindings.Add(nameof(NumericUpDown.Value), _idpCertDetailsViewModel,
                nameof(IdpCertDetailsViewModel.ValidityPeriodInYears), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public event CertificateSenderDelegate SendCertificateDetails;
        public event EventHandler<string> LogMessage;

        public void ConfigureDefaults(IApplicationConfiguration applicationConfiguration)
        {
            if (applicationConfiguration == null) throw new ArgumentNullException(nameof(applicationConfiguration));

            _idpCertDetailsViewModel.Country = applicationConfiguration.Country ?? string.Empty;

            _idpCertDetailsViewModel.ValidityPeriodInYears = 
                (int)(applicationConfiguration.DefaultFutureDateSpan ?? UiConstants.DefaultNumericUpDownValue);
        }

        private void CreateCertButtonClick(object sender, EventArgs e)
        {
            if (_submitCommand.CanExecute())
            {
                var certificateDetailEventArgs = new IdpCertificateDetailEventArgs(_idpCertDetailsViewModel);
                _submitCommand.Execute(certificateDetailEventArgs);
            }
        }

        private void CreateCertAction(IdpCertificateDetailEventArgs eventArgs)
        {
            if (eventArgs == null) throw new ArgumentNullException(nameof(eventArgs));

            SendCertificateDetails?.Invoke(eventArgs);
        }

        public void PersistCertificate(byte[] certificateInBytes)
        {
            if (CertSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(CertSaveFileDialog.FileName, certificateInBytes);
                LogMessage?.Invoke(this, string.Format(LogMessages.CertificateCreated, CertSaveFileDialog.FileName));
            }
            else
            {
                LogMessage?.Invoke(this, LogMessages.OperationCancelled);
            }
        }

        private void ShowPasswordPictureBoxClick(object sender, EventArgs e)
        {
            _idpCertDetailsViewModel.PasswordMask =
                _idpCertDetailsViewModel.PasswordMask.Equals(UiConstants.PasswordMask)
                    ? UiConstants.PasswordNullMask
                    : UiConstants.PasswordMask;
        }

        private void ShowPasswordPictureBoxMouseEvents(object sender, EventArgs e)
        {
            if (Cursor == Cursors.Arrow)
            {
                Cursor = Cursors.Hand;
                _idpCertDetailsViewModel.PasswordHover = Resources.eye_icon_hover;
            }
            else
            {
                Cursor = Cursors.Arrow;
                _idpCertDetailsViewModel.PasswordHover = Resources.eye_icon;
            }
        }

        private void DnsNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var val = _idpFormValidator.Validate(_idpCertDetailsViewModel, 
                o => o.IncludeProperties(nameof(_idpCertDetailsViewModel.DnsName))
                    );

            _errorTracker.ProcessValidationResult(val, DnsNameTextBox);
        }

        private void CountryTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var val = _idpFormValidator.Validate(_idpCertDetailsViewModel,
                o => o.IncludeProperties(nameof(_idpCertDetailsViewModel.Country))
            );

            _errorTracker.ProcessValidationResult(val, CountryTextBox);
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var val = _idpFormValidator.Validate(_idpCertDetailsViewModel,
                o => o.IncludeProperties(nameof(_idpCertDetailsViewModel.Password))
            );

            _errorTracker.ProcessValidationResult(val, PasswordTextBox);
        }
    }
}
