using System;

namespace CertificateCreator.Infrastructure.Ui
{
    public interface IDispatchEventCommand<in T>
    {
        public bool CanExecute();
        void Execute(T eventArgs);
        public Action<T> ExecuteCommand { get; }
    }

    public interface IDispatchEventCommand
    {
        public bool CanExecute();
        void Execute();
        public Action ExecuteCommand { get; }
    }
}
