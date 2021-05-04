using Xunit;

namespace TitleCase.Tests
{
    public class TitleCaseTests
    {
        [Theory]
        [InlineData("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [InlineData("a clash of KINGS", null, "A Clash Of Kings")]
        [InlineData("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.Equal(expected, Case.TitleCaseMethod(sampleTitle, sampleMinorWords));
        }

        [Fact]
        public void MyTest2()
        {
            Assert.Equal("", Case.TitleCaseMethod(""));
        }

        [Fact]
        public void MyTest3()
        {
            Assert.Equal("The Quick Brown Fox", Case.TitleCaseMethod("the quick brown fox"));
        }
    }
}