using System.Security.Cryptography.X509Certificates;

namespace CertificateCreator.Models
{
    public class TlsCertDetailsViewModel
    {
        public CertDetailsViewModel CertDetailsViewModelForTls { get; set; }
        public CertDetailsViewModel CertDetailsViewModelForRoot { get; set; }

        public TlsCertDetailsViewModel()
        {
            CertDetailsViewModelForTls = new CertDetailsViewModel();
            CertDetailsViewModelForRoot = new CertDetailsViewModel();
        }


        public X509Certificate2 RootCertificate { get; set; }
        public byte[] RootCertificateInBytes { get; set; }
        public byte[] RootPublicKeyInBytes { get; set; }
        public byte[] TlsCertificateInBytes { get; set; }
    }
}
