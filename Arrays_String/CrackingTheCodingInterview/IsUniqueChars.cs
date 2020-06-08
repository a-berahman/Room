using System.Collections.Generic;

namespace Arrays_String.CrackingTheCodingInterview
{
    public class isUniqueChars
    {
        public bool IsUnique(string str)
        {
            var marked = new HashSet<char>();
            foreach (var ch in str)
            {
                if (marked.Contains(ch))
                    return false;

                marked.Add(ch);
            }
            return true;
        }
    }
}