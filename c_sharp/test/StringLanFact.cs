using Xunit;

namespace c_sharp.test
{
    public class StringLanFact
    {
        [Fact]
        public void should_get_format_string()
        {
            var stringLan = new StringLan();
            Assert.Equal("Hello, Ingram", stringLan.GetFormatString("Ingram"));
        }

        [Fact]
        public void should_get_repeat_char_by_new_string()
        {
            var stringLan = new StringLan();
            Assert.Equal("aaaaaaaaaa", stringLan.CreateStringByConstructRepeat('a'));
        }

    }
}