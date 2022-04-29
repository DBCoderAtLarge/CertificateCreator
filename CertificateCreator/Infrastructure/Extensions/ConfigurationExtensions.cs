using CertificateCreator.Infrastructure.Config;
using Microsoft.Extensions.Configuration;

namespace CertificateCreator.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        public static ApplicationConfiguration GetApplicationConfiguration(this IConfiguration configuration)
        {
            var applicationConfiguration = new ApplicationConfiguration();
            configuration.Bind("Application", applicationConfiguration);

            return applicationConfiguration;
        }
    }
}
