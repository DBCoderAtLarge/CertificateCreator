using CertificateCreator.Infrastructure.Extensions;
using CertificateCreator.Models;
using FluentValidation;

namespace CertificateCreator.Validation
{
    public class IdpCertificateValidator : AbstractValidator<IdpCertDetailsViewModel>
    {
        public IdpCertificateValidator()
        {
            RuleFor(m => m.Country).NotEmpty();
            RuleFor(m => m.DnsName)
                .NotEmpty()
                .NotContainSpaceCharacter();
            RuleFor(m => m.Password).NotEmpty();
        }
    }
}
