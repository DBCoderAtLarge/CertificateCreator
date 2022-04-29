namespace CertificateCreator.Infrastructure.Config
{
    public class ApplicationConfiguration : IApplicationConfiguration
    {
        public string Country { get; set; }
        public decimal? DefaultFutureDateSpan { get; set; }
        public int MaxNumberOfVisibleLogLines { get; set; }
    }
}
