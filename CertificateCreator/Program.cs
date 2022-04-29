using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CertificateCreator.Forms;
using CertificateCreator.Infrastructure.Boot;
using CertificateCreator.Infrastructure.Config;
using CertificateCreator.Infrastructure.Ioc;
using CertificateCreator.Infrastructure.Logging;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using WinFormsMVP.NET.Binder;
using WinFormsMVP.NET.SimpleInjector;

namespace CertificateCreator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Startup.SetVisualConfiguration();

            var container = new Container();
            container.RegisterAbstractions();

            using var host = Startup.BuildHost(container);
            using var scope = AsyncScopedLifestyle.BeginScope(container);

            host.Services.UseSimpleInjector(container);

            PresenterBinder.Factory = new SimpleInjectorPresenterFactory(container);

            PresenterBinder.TraceLogger = container.GetInstance<Microsoft.Extensions.Logging.ILogger>();

            var appConfig = container.GetInstance<IApplicationConfiguration>();

            Application.Run(new Main(
                    appConfig,
                    new LogMessageProcessor(new Queue<string>(), appConfig.MaxNumberOfVisibleLogLines)
                )
            );
        }
    }
}
