using Xunit;

namespace c_sharp.test
{
    public class KeywordsFact
    {
        
        [Fact]
        public void should_get_int_max_value_of_over_when_use_uncheck()
        {

            var keywords = new Keywords();
            const int expectValue = int.MinValue + 100 - 1;
            Assert.Equal(expectValue, keywords.HandleUnCheckedInt());
        }
    }
}