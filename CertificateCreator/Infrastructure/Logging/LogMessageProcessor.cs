using System;
using System.Collections.Generic;
using System.Linq;

namespace CertificateCreator.Infrastructure.Logging
{
    public class LogMessageProcessor : ILogMessageProcessor
    {
        private readonly Queue<string> _logMessages;
        private readonly int _maxNumberMessages;

        public LogMessageProcessor(Queue<string> logMessages, int maxNumberMessages)
        {
            _logMessages = logMessages;
            _maxNumberMessages = maxNumberMessages;
        }

        public string ProcessMessage(string logMessage)
        {
            var messagesArray = ProcessMessageToArray(logMessage);
            var messagesString = string.Join(Environment.NewLine, messagesArray);

            return messagesString;
        }

        public string[] ProcessMessageToArray(string logMessage)
        {
            _logMessages.Enqueue(logMessage);

            if (_maxNumberMessages < _logMessages.Count)
                _logMessages.Dequeue();

            return _logMessages.ToArray().Reverse().ToArray();
        }
    }
}
