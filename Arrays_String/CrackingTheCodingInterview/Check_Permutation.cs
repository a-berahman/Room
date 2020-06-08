using System;
namespace Arrays_String.CrackingTheCodingInterview
{
    public class Check_Permutation
    {
        public bool IsPermutation(string original, string valueToTest)
        {
            var originalArray = original.ToCharArray();
            Array.Sort(originalArray);
            original = new string(originalArray);

            var valueToTestArr = valueToTest.ToCharArray();
            Array.Sort(valueToTestArr);
            valueToTest = new string(valueToTestArr);

            return original.Equals(valueToTest);
        }
    }
}