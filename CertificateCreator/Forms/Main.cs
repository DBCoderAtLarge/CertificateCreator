using System;
using System.Drawing;
using System.Windows.Forms;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Infrastructure.Logging;
using CertificateCreator.Infrastructure.Messaging;
using CertificateCreator.Views;
using WinFormsMVP.NET.Binder;
using WinFormsMVP.NET.Forms;

namespace CertificateCreator.Forms
{
    public partial class Main : MvpForm, IMainView
    {
        private readonly IApplicationConfiguration _applicationConfiguration;
        private readonly ILogMessageProcessor _logMessageProcessor;

        public Main(IApplicationConfiguration applicationConfiguration, ILogMessageProcessor logMessageProcessor)
        {
            _applicationConfiguration = applicationConfiguration;
            _logMessageProcessor = logMessageProcessor;

            InitializeComponent();

            Icon = Icon.FromHandle(Properties.Resources.cert.GetHicon());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // subscribe to events on UserControls to write emitted log messages.
            AppIdpCertUserControl.LogMessage += IdpCertUserControl1LogMessage;
            AppTlsCertUserControl.LogMessage += IdpCertUserControl1LogMessage;

            AppTlsCertUserControl.ConfigureDefaults(_applicationConfiguration);
            AppIdpCertUserControl.ConfigureDefaults(_applicationConfiguration);
        }


        private void IdpCertUserControl1LogMessage(object sender, string logMessage)
        {
            AppLogTextBox.Text = _logMessageProcessor.ProcessMessage(logMessage);
        }

        private void MainShown(object sender, EventArgs e)
        {
            PresenterBinder.MessageBus.Send(true, MessageTokens.SetFocusedControlOnStartup);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            OnFormClosing(new FormClosingEventArgs(CloseReason.UserClosing, false));
            Close();
        }
    }
}
