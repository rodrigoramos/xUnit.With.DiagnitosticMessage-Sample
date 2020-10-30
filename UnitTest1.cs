using Xunit;

namespace xUnit.With.DiagnosticMessages
{
    public class UnitTest1 : IClassFixture<TestFixture>
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
    }
}