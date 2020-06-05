

namespace Arrays_String.LeetCode
{
    public class Product_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            // The length of the input array 
            int length = nums.Length;

            // Final answer array to be returned
            int[] answer = new int[length];

            // answer[i] contains the product of all the elements to the left
            // Note: for the element at index '0', there are no elements to the left,
            // so the answer[0] would be 1
            answer[0] = 1;
            for (int i = 1; i < length; i++)
            {

                // answer[i - 1] already contains the product of elements to the left of 'i - 1'
                // Simply multiplying it with nums[i - 1] would give the product of all 
                // elements to the left of index 'i'
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            // R contains the product of all the elements to the right
            // Note: for the element at index 'length - 1', there are no elements to the right,
            // so the R would be 1
            int R = 1;
            for (int i = length - 1; i >= 0; i--)
            {

                // For the index 'i', R would contain the 
                // product of all elements to the right. We update R accordingly
                answer[i] = answer[i] * R;
                R *= nums[i];
            }

            return answer;





            //TIME OUT ERROR

            // int[] _result = Enumerable.Repeat(1, nums.Length).ToArray();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     int j = 0;
            //     while (j >= 0 && j < nums.Length)
            //     {
            //         if (j != i)
            //             _result[i] *= nums[j];
            //         j++;
            //     }

            // }
            // return _result;

        }
    }
}