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
            //Console.WriteLine(new CrackingTheCodingInterview.One_Away().IsOneEditDistance("pale", "ple"));

            //new HackerRank.Circular_Array_Rotation().circularArrayRotation(new int[3]{1,2,3},2,new int[3]{0,1,2});
            var res=new Arrays_String.HackerRank.Missing_Numbers().missingNumbers(new int[10]{203 ,204 ,205, 206 ,207 ,208 ,203, 204 ,205 ,206},
            new int[14]{203 ,204 ,204 ,205 ,206,205 ,207 ,205 ,208 ,203 ,206 ,205 ,206, 204});
            foreach (var item in res)
            {
            Console.WriteLine(item);    
            }
            
        }


    }
}
