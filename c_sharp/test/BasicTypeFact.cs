using Xunit;

namespace c_sharp.test
{
    public class BasicTypeFact
    {

        [Fact]
        public void should_get_same_char()
        {
            var todo1 = '\0';
            var todo2 = '\u0000';
            Assert.Equal(todo1, todo1);
        }
    }
}