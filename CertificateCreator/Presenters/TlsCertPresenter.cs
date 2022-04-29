using CertificateCreator.Domain;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Models;
using CertificateCreator.Services;
using CertificateCreator.Views;
using System.Security.Cryptography.X509Certificates;
using WinFormsMVP.NET;

namespace CertificateCreator.Presenters
{
    public class TlsCertPresenter : Presenter<ITlsCertView>
    {
        private readonly ICertificateGenerator _certificateGenerator;
        private readonly IApplicationConfiguration _applicationConfiguration;
        private int _pathLengthConstraint = 3; // hard coded

        public TlsCertPresenter(
            ITlsCertView view,
            ICertificateGenerator certificateGenerator,
            IApplicationConfiguration applicationConfiguration)
            : base(view)
        {
            _certificateGenerator = certificateGenerator;
            _applicationConfiguration = applicationConfiguration;

            View.ProceedToTlsCreation += ProceedToTlsCreationHandler;
            View.Reset += ResetFormsHandler;
            View.SendRootCertificateDetails += SendRootCertificateDetailsHandler;
            View.SendTlsCertificateDetails += SendTlsCertificateDetailsHandler;
            View.SendTlsCertificateFromExistingRoot += SendTlsCertificateFromExistingRootHandler;           
            View.Load += ViewLoad;
        }

        private void ProceedToTlsCreationHandler(TlsControlState state)
        {
            View.SetControlState(state);
        }

        private void ResetFormsHandler()
        {
            View.Model = new TlsCertDetailsViewModel();
            View.SetControlState(TlsControlState.FullReset);
            View.Rebind(_applicationConfiguration);
        }

        private void ViewLoad(object sender, System.EventArgs e)
        {
            View.Model = new TlsCertDetailsViewModel();
        }

        private void SendRootCertificateDetailsHandler()
        {
            var vm = View.Model.CertDetailsViewModelForRoot;

            var certificateDetailsDto = new CertificateDetailsDto
            {
                CommonNameText = vm.CommonName?.Trim(),
                CountryText = vm.Country.Trim(),
                DnsNameText = vm.DnsName.Trim(),
                FriendlyNameText = vm.FriendlyName?.Trim(),
                PasswordText = vm.Password,
                PathLengthConstraint = _pathLengthConstraint,
                ValidFrom = vm.ValidFrom,
                ValidTo = vm.ValidTo,
            };

            var rootCertificate = 
                _certificateGenerator.CreateRootCertificate(certificateDetailsDto);

            View.Model.RootCertificate = rootCertificate.x509Certificate2;
            View.Model.RootCertificateInBytes = rootCertificate.certificateBytes;
            View.Model.RootPublicKeyInBytes = rootCertificate.publicKeyBytes;

            View.PersistRootCertificate();            
        }

        private void SendTlsCertificateDetailsHandler()
        {
            var vm = View.Model.CertDetailsViewModelForTls;

            var certificateDetailsDto = new CertificateDetailsDto
            {
                CommonNameText = vm.CommonName?.Trim(),
                CountryText = vm.Country.Trim(),
                DnsNameText = vm.DnsName.Trim(),
                FriendlyNameText = vm.FriendlyName?.Trim(),
                PasswordText = vm.Password,
                PathLengthConstraint = _pathLengthConstraint,
                ValidFrom = vm.ValidFrom,
                ValidTo = vm.ValidTo
            };

            var rootCertificate = View.Model.RootCertificate;
            var tlsCertificateLevel1 =
                _certificateGenerator.CreateTlsCertificate(certificateDetailsDto, rootCertificate);

            View.Model.TlsCertificateInBytes = tlsCertificateLevel1.certificateBytes;

            View.PersistTlsCertificate();            
        }

        private void SendTlsCertificateFromExistingRootHandler(string fileName, string password)
        {
            var fileNameTrimmed = fileName.Trim();
            var passwordTrimmed = password.Trim();

            View.Model.RootCertificate = new X509Certificate2(fileNameTrimmed, passwordTrimmed);

            ProceedToTlsCreationHandler(TlsControlState.TlsEnabledFromExistingRoot);
        }
    }
}
