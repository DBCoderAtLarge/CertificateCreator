using System;
using System.Linq;
using FluentValidation.Results;

namespace CertificateCreator.Infrastructure.Extensions
{
    public static class ValidationResultExtensions
    {
        public static string ToDelimitedString(this ValidationResult source)
        {
            return source.Errors
                .Select(e => e.ErrorMessage)
                .Aggregate((curr, next) => curr += Environment.NewLine + next);
        }
    }
}
