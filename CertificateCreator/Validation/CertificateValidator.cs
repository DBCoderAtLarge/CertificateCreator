using CertificateCreator.Infrastructure.Extensions;
using CertificateCreator.Models;
using FluentValidation;

namespace CertificateCreator.Validation
{
    public class CertificateValidator : AbstractValidator<CertDetailsViewModel>
    {
        public CertificateValidator()
        {
            RuleFor(m => m.CommonName).NotEmpty();
            RuleFor(m => m.Country).NotEmpty();
            RuleFor(m => m.DnsName)
                .NotEmpty()
                .NotContainSpaceCharacter();
            RuleFor(m => m.Password).NotEmpty();
        }
    }
}
