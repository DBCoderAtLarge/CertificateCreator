using CertificateCreator.Models;

namespace CertificateCreator.Events.EventArgs
{
    public class IdpCertificateDetailEventArgs : System.EventArgs
    {
        public IdpCertDetailsViewModel ViewModel;

        public IdpCertificateDetailEventArgs(IdpCertDetailsViewModel viewModel)
        {
            ViewModel = viewModel;
        }
    }
}
