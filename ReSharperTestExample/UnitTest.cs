using Microsoft.QualityTools.Testing.Fakes;
using Xunit;

namespace ReSharperTestExample
{

    public class UnitTest
    {
        [Fact]
        public void TestMethod()
        {
            using (ShimsContext.Create())
            {
                Assert.True(true);
            }
        }
    }
}
