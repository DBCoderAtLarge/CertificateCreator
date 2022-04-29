using System;

namespace CertificateCreator.Infrastructure.Ui
{
    public class DispatchEventCommand<T> : IDispatchEventCommand<T>
    {
        private readonly Func<bool> _formValidateMethod;
        private readonly Func<bool> _canExecute;

        public DispatchEventCommand(Action<T> execute, Func<bool> formValidateMethod, Func<bool> canExecute = null)
        {
            ExecuteCommand = execute ?? throw new ArgumentNullException(nameof(execute));
            _formValidateMethod = formValidateMethod;
            _canExecute = canExecute;
        }

        public Action<T> ExecuteCommand { get; }

        public bool CanExecute() => _formValidateMethod() && (_canExecute?.Invoke() ?? true);

        public void Execute(T eventArgs)
        {
            ExecuteCommand?.Invoke(eventArgs);
        }
    }
}
