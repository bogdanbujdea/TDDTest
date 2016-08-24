using System;

namespace TDDTestString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddLineBreaks("abcdefghijkl", 4));
        }

        public static string AddLineBreaks(string str, int column)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            if (str.Length < column)
                return str;
            var newString = string.Empty;
            for (int index = 0; index < str.Length; index++)
            {
                newString += str[index];
                if (index%column == 0 && index != 0)
                    newString += "\n";
            }
            return newString;
        }
    }
}
