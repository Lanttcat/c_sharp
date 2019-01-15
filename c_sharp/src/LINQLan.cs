using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp
{
    public class LinqLan
    {
        public string[] OrderStringByLength(string[] strings)
        {
            IEnumerable<string> stringQuery =
                from item in strings
                orderby item.Length descending, item.Substring(0, 1)
                select item;

            return stringQuery.ToArray();
        }

        public List<int> getScoresFilter()
        {
            // Specify the data source.
            int[] scores = new int[] {97, 92, 81, 60};

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            return scoreQuery.ToList();
        }
        
        
    }
}