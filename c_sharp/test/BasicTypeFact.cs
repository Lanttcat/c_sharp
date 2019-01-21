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

        [Fact]
        public void should_get_new_line_for_string()
        {
            var todo = @"a
b";
            Assert.Equal("a\nb", todo);
        }

        [Fact]
        public void should_get_var_value_for_string()
        {
            var todo1 = "Ingram";
            var todo2 = $"my name is {todo1}";
            var expectValue = $"my name is Ingram";
            
            Assert.Equal(expectValue, todo2);
        }
    }
}