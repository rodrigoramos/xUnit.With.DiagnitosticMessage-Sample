using System;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace xUnit.With.DiagnosticMessages
{
    public class TestFixture : IDisposable
    {
        private readonly IMessageSink _messageSink;

        public TestFixture(IMessageSink messageSink)
        {
            _messageSink = messageSink;
            _messageSink.OnMessage(new DiagnosticMessage("Start up Test Fixture"));
        }

        public void Dispose() => _messageSink.OnMessage(new DiagnosticMessage("Clean Up Test Fixure"));
    }
}