using System;

namespace SubstringHW
{
    class Program
    {
        static void Main(string[] args)
        {
            String value = "This is a string.";
            int startIndex = 5;
            int length = 2;
            String substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);
        }
    }
}
