namespace Arrays_String.CrackingTheCodingInterview
{
    public class One_Away
    {
        public bool IsOneEditDistance(string str1, string str2)
        {

            if (str1.Length > str2.Length)
                return IsOneEditDistance(str2, str1);

            if (str1.Length - str2.Length > 1)
                return false;

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    if (str1.Length == str2.Length)
                        return str1.Substring(i + 1).Equals(str2.Substring(i + 1));
                    else return str1.Substring(i).Equals(str2.Substring(i + 1));
                }
            }

            return str1.Length + 1 == str2.Length;
        }

    }
}