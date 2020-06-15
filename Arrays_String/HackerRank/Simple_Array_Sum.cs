namespace Arrays_String.HackerRank
{
    public class Simple_Array_Sum
    {
        private int _sum = 0;
        public int simpleArraySum(int[] ar)
        {
            if (ar.Length == 0)
                return 0;
            return Recursive(ar, ar.Length);
        }
        private int Recursive(int[] ar, int len)
        {
            if (len - 1 < 0)
                return 0;

            return _sum + ar[len - 1] + Recursive(ar, len - 1);
        }


    }
}