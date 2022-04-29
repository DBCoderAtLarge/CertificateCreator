using CertificateCreator.Domain;
using CertificateCreator.Events.EventArgs;
using CertificateCreator.Services;
using CertificateCreator.Views;
using WinFormsMVP.NET;

namespace CertificateCreator.Presenters
{
    public class IdpCertPresenter : Presenter<IdpCertView>
    {
        private readonly ICertificateGenerator _certificateGenerator;

        public IdpCertPresenter(
            IdpCertView view,
            ICertificateGenerator certificateGenerator) 
            : base(view)
        {
            _certificateGenerator = certificateGenerator;
            view.SendCertificateDetails += ViewSendCertificateDetailsHandler;
        }

        private void ViewSendCertificateDetailsHandler(IdpCertificateDetailEventArgs eventArgs)
        {
            var vm = eventArgs.ViewModel;

            var certificateDetailsDto = new SelfSignedCertificateDetailsDto
            {
                CountryText = vm.Country.Trim(),
                DnsNameText = vm.DnsName.Trim(),
                FriendlyNameText = vm.FriendlyName?.Trim(),
                PasswordText = vm.Password,
                ValidityPeriodInYears = vm.ValidityPeriodInYears
            };

            var certificate = 
                _certificateGenerator.CreateSelfSignedCertificate(certificateDetailsDto);

            View.PersistCertificate(certificate.certificateBytes);
        }
    }
}
