namespace Arrays_String.LeetCode
{
    public class Valid_Mountain_Array
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;

            var index = FindIndex(A);
            if (index == A.Length - 1 || index == 0) return false;

            for (int i = index + 1; i < A.Length; i++)
            {
                if (A[i] >= A[i - 1])
                    return false;
            }
            for (int i = index - 1; i >= 0; i--)
            {
                if (A[i] >= A[i + 1])
                    return false;
            }

            return true;
        }

        private int FindIndex(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                if (arr[mid] > arr[mid + 1])
                    right = mid;
                else left = mid + 1;
            }

            return right;
        }
    }
}