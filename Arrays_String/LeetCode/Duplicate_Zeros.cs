namespace Arrays_String.LeetCode
{
    public class Duplicate_Zeros
    {
        public void DuplicateZeros(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                if ((i + 1) < arr.Length - 1)
                    arr[i + 1] = 0;
                }

            }
        }
    }
}