using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SimpleInjector;

namespace CertificateCreator.Infrastructure.Boot
{
    public static class Startup
    {
        public static void SetVisualConfiguration()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public static IHost BuildHost(Container container) =>
            new HostBuilder()
                .ConfigureAppConfiguration(configurationBuilder =>
                    configurationBuilder.SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: true)
                )
                .ConfigureServices(services =>
                    services.AddSimpleInjector(container, options =>
                        {
                            options.AutoCrossWireFrameworkComponents = true;
                            options.AddLogging();
                        })
                        .BuildServiceProvider(true)
                )
                .UseSerilog((hostBuilderContext, loggerConfiguration) =>
                {
                    loggerConfiguration.ReadFrom.Configuration(hostBuilderContext.Configuration);
                }) // <- Add this line
                .Build();
    }
}
