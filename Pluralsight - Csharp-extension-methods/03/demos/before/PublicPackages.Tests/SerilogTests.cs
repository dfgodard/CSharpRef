using NUnit.Framework;
using Serilog;

namespace PublicPackages.Tests
{
    public class SerilogTests
    {
        [Test]
        public void ConfigureFileSink()
        {
            //TODO - configure file sink
            var log = new LoggerConfiguration()
                           .CreateLogger();

            log.Information("Log configured");
        }
    }
}
