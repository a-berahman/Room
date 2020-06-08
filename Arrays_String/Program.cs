using System;

namespace Arrays_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //const string input = "Mr John Smith";
            // var characterArray = new char[input.Length + 3 * 2 + 1];

            // for (var i = 0; i < input.Length; i++)
            // {
            //     characterArray[i] = input[i];
            // }
            // var temp = input.ToCharArray();
            // var ans=new URLify().ReplaceSpaces(temp, input.Length);
            // Console.WriteLine("{0} -> {1}", input, ans);

            // Console.WriteLine(new CrackingTheCodingInterview.Palindrome_Permutation().IsPermutationOfPalindrome("Tact Coa"));
            Console.WriteLine(new CrackingTheCodingInterview.One_Away().IsOneEditDistance("pale", "ple"));
        }
    }
}
