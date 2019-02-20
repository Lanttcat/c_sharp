using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace c_sharp.test
{
    public class LinqLanFact
    {
        [Fact]
        public void should_get_more_than_80_scores_by_linq()
        {
            var linqLan = new LinqLan();
            Assert.Equal(3, linqLan.getScoresFilter().Count);
        }

        [Fact]
        public void should_get_order_list_by_length_and_char()
        {
            var linqLan = new LinqLan();
            string[] todo = {"bbbb", "aaa", "ccc", "dd", "eeeee"};

            string[] expectValue = { "eeeee", "bbbb", "aaa", "ccc", "dd"};
            Assert.Equal(expectValue, linqLan.OrderStringByLength(todo));
        }

        [Fact]
        public void should_exe_twice_when_only_use_select_in_linq()
        {
            var numbers = new List<int> {1, 2, 3};

            var selectNumber = numbers.Where(number => number > 2);
            
            Assert.Equal(1, selectNumber.Count());
            
            numbers.Add(4);
            Assert.Equal(2, selectNumber.Count());
        }

    }
}