using System;
using CertificateCreator.Events.Delegates;
using WinFormsMVP.NET;

namespace CertificateCreator.Views
{
    public interface IdpCertView : IView
    {
        event CertificateSenderDelegate SendCertificateDetails;
        event EventHandler<string> LogMessage;
        void PersistCertificate(byte[] certificateInBytes);
    }
}
