using System;

namespace Isogram
{
    public class isogram
    {
        public static bool Isisogram(string input)
        {
            for (int i = 0; i<input.Length - 1; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    if (input.IndexOf(input[i], i + 1) != -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}