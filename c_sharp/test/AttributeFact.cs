using System;
using Xunit;

namespace c_sharp.test
{
    public class AttributeFact
    {

        [Fact]
        public void should_get_attribute()
        {
            var attributeLan = new AttributeLan();
            Type type = attributeLan.GetType();
               
            Assert.True(type.IsPublic);
            Assert.Equal("c_sharp.AttributeLan", type.FullName);
            Assert.Equal(new object(), type.Attributes);
        }

    }
}