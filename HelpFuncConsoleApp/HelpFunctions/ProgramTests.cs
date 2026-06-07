using Xunit;

namespace HelpFuncConsoleApp
{
    public class ProgramTests
    {
        [Fact]
        public void ExampleTest()
        {
            int result = 2 + 2;
            Assert.Equal(4, result);
        }
    }
}
