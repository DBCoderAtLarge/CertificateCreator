using System;
using FluentValidation;

namespace CertificateCreator.Infrastructure.Extensions
{
    public static class RuleBuilderExtensions
    {
        public static IRuleBuilderOptions<T, string> NotContainSpaceCharacter<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .Must((rootObject, stringProperty, context) => !stringProperty.Contains(' ', StringComparison.OrdinalIgnoreCase))
                .WithMessage("\'{PropertyName}\' must not have any spaces.");
        }
    }
}
