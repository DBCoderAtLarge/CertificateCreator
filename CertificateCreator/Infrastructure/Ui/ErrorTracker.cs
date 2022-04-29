using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CertificateCreator.Infrastructure.Extensions;
using FluentValidation.Results;

namespace CertificateCreator.Infrastructure.Ui
{
    public class ErrorTracker
    {
        private readonly ISet<Control> _errors = new HashSet<Control>();
        private readonly ErrorProvider _errorProvider;

        public ErrorTracker(ErrorProvider errorProvider)
        {
            _errorProvider = errorProvider;
        }

        public void SetError(Control control, string text)
        {
            if (!_errors.Contains(control))
                _errors.Add(control);

            _errorProvider.SetError(control, text);
        }

        public void ClearError(Control control)
        {
            _errors.Remove(control);

            _errorProvider.SetError(control, string.Empty);
        }

        public void ProcessValidationResult(ValidationResult validationResult, Control controlToValidate)
        {
            if (validationResult.IsValid)
                ClearError(controlToValidate);
            else
                SetError(controlToValidate, validationResult.ToDelimitedString());
        }

        public bool Any() => _errors.Any();
        public bool None() => !_errors.Any();
    }
}
