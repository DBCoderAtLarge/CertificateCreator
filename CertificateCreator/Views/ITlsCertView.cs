using System;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Models;
using WinFormsMVP.NET;

namespace CertificateCreator.Views
{
    public interface ITlsCertView : IView<TlsCertDetailsViewModel>
    {
        event Action<TlsControlState> ProceedToTlsCreation;
        event Action Reset;
        event Action SendExistingRootCertificateDetails;
        event Action SendRootCertificateDetails;
        event Action SendTlsCertificateDetails;
        event Action<string, string> SendTlsCertificateFromExistingRoot;

        void PersistRootCertificate();
        void PersistTlsCertificate();
        void SetControlState(TlsControlState state);
        void Rebind(IApplicationConfiguration applicationConfiguration);
    }

    public enum TlsControlState
    {
        FullReset,
        RootEnabled,
        TlsEnabledFromNewRoot,
        TlsEnabledFromExistingRoot
    }
}
