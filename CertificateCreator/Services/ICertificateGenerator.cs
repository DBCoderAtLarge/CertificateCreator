using System.Security.Cryptography.X509Certificates;
using CertificateCreator.Domain;

namespace CertificateCreator.Services
{
    public interface ICertificateGenerator
    {
        (X509Certificate2 x509Certificate2, byte[] certificateBytes, byte[] publicKeyBytes) CreateRootCertificate(CertificateDetailsDto dto);
        (X509Certificate2 x509Certificate2, byte[] certificateBytes) CreateSelfSignedCertificate(SelfSignedCertificateDetailsDto dto);
        (X509Certificate2 x509Certificate2, byte[] certificateBytes) CreateTlsCertificate(CertificateDetailsDto dto, X509Certificate2 rootCertificate);
    }
}
