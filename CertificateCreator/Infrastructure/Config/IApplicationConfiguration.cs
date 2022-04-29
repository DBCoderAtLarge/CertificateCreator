namespace CertificateCreator.Infrastructure.Config
{
    public interface IApplicationConfiguration
    {
        string Country { get; set; }
        decimal? DefaultFutureDateSpan { get; set; }
        int MaxNumberOfVisibleLogLines { get; set; }
    }
}