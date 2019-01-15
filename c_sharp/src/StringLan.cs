namespace c_sharp
{
    public class StringLan
    {
        public string GetFormatString(string name)
        {
            return $"Hello, {name}";
        }

        public string CreateStringByConstructRepeat(char testChar)
        {
            return new string(testChar, 10);
        }
        
    }
}