using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Infrastructure.Extensions;
using CertificateCreator.Presenters;
using CertificateCreator.Services;
using CertificateManager;
using Microsoft.Extensions.Configuration;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace CertificateCreator.Infrastructure.Ioc
{
    public static class AppRegistry
    {
        public static void RegisterAbstractions(this Container container)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.Options.EnableAutoVerification = false;

            // internal
            container.Register<CertificateUtility>(Lifestyle.Scoped);

            // public
            container.Register<ImportExportCertificate>(Lifestyle.Scoped);
            container.Register<CreateCertificates>(Lifestyle.Scoped);
            container.Register<CreateCertificatesClientServerAuth>(Lifestyle.Scoped);
            container.Register<CreateCertificatesRsa>(Lifestyle.Scoped);
            container.Register<ICertificateGenerator, CertificateGenerator>(Lifestyle.Scoped);

            container.Register<IApplicationConfiguration>(() =>
            {
                var configuration = container.GetInstance<IConfiguration>();
                return configuration.GetApplicationConfiguration();
            }, Lifestyle.Scoped);
            
            container.Register<TlsCertPresenter>(Lifestyle.Scoped);
            container.Register<IdpCertPresenter>(Lifestyle.Scoped);
            container.Register<MainPresenter>(Lifestyle.Scoped);
        }
    }
}
