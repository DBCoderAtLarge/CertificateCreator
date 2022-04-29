namespace CertificateCreator.Infrastructure.Logging
{
    public sealed class LogMessages
    {
        public const string RootCertificateCreated = "Root " + CertificateCreated;
        public const string TlsCertificateCreated = "TLS " + CertificateCreated;
        public const string CertificateCreated = "Certificate successfully created at {0}";
        public const string OperationCancelled = "Operation cancelled";
        public const string RootCertOperationCancelled = OperationCancelled + " for creation of Root certificate.";
        public const string TlsCertOperationCancelled = OperationCancelled + " for creation of Tls certificate.";
    }
}
