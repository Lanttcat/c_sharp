using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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

//        [Fact]
//        public void should_not_change_value_when_use_using_key()
//        {
//            var todo = false;
//
//            using (FileStream file = File.OpenRead("/readme.md"))
//            {
//                if (file != null)
//                {
//                    todo = true;
//                }
//            }
//
//            Assert.False(todo);
//        }

        [Fact]
        public void should_get_one_string_from_list()
        {
            object[] todo = new object[]{new classA(), new classB(), "test", 12, 1.1};

            var value = todo.Select(item => item as string).ToArray();
            Assert.Equal(value, new string[]
            {
                null, null, "test", null, null
            });
        }
    }
}
class classA{}
class classB{}
