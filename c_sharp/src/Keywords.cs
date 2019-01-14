using System;

namespace c_sharp
{
    public class Keywords
    {
        public int HandleUnCheckedInt()
        {
            // The following statements are checked by default at compile time. They do not
            // compile.
            //int1 = 2147483647 + 10;
            //int1 = ConstantMax + 10;
            const int maxInt = int.MaxValue;
            return unchecked(maxInt + 100);
        }
    }
}