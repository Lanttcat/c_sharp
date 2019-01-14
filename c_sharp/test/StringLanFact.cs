using System;
using Xunit;

namespace c_sharp
{
    public class StringLanFact
    {
        [Fact]
        public void should_get_format_string()
        {
            var stringLan = new StringLan();
            Assert.Equal("Hello, Ingram", stringLan.GetFormatString("Ingram"));
        }

    }
}