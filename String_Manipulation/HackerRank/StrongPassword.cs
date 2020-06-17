using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Manipulation.HackerRank
{
    public class StrongPassword
    {
        public int minimumNumber(int n, string password)
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            int count = 0;
            
            if (!numbers.ToCharArray().Any(password.Contains))
                count++;
            if (!lower_case.ToCharArray().Any(password.Contains))
                count++;
            if (!upper_case.ToCharArray().Any(password.Contains))
                count++;
            if (!special_characters.ToCharArray().Any(password.Contains))
                count++;
            return Math.Max(6 - n, count);
        }
    }
}