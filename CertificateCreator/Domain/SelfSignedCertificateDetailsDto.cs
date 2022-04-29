namespace CertificateCreator.Domain
{
    public class SelfSignedCertificateDetailsDto : CertificateDetailsDto
    {
        public int ValidityPeriodInYears { get; set; }
    }
}
