using System;

namespace CertificateCreator.Domain
{
    public class CertificateDetailsDto
    {
        public string CommonNameText { get; set; }
        public string CountryText { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string DnsNameText { get; set; }
        public string FriendlyNameText { get; set; }
        public int PathLengthConstraint { get; set; }
        public string PasswordText { get; set; }
    }
}
