using CertificateCreator.Events.EventArgs;

namespace CertificateCreator.Events.Delegates
{
    public delegate void CertificateSenderDelegate(IdpCertificateDetailEventArgs eventArgs);
}
