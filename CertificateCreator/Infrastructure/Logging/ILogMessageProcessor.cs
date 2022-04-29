namespace CertificateCreator.Infrastructure.Logging
{
    public interface ILogMessageProcessor
    {
        string ProcessMessage(string logMessage);
        string[] ProcessMessageToArray(string logMessage);
    }
}