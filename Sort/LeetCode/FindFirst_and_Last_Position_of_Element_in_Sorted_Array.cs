
namespace Sort.LeetCode
{
    public class Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        public int[] SearchRange(int[] nums, int target)
        {

            var result = new int[2] { -1, -1 };
            var leftIndex = GetIndex(nums, target, true);
            if (leftIndex == nums.Length || nums[leftIndex] != target)
            {
                return result;
            }
            result[0] = leftIndex;
            result[1] = GetIndex(nums, target, false) - 1;

            return result;

        }
        private int GetIndex(int[] nums, int target, bool isLeft)
        {
            int left = 0; int right = nums.Length;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var cmp = nums[mid].CompareTo(target);

                if (cmp > 0 || (isLeft && cmp == 0))
                {
                    right = mid;
                }
                else { left = mid + 1; }
            }
            return left;

        }
    }
}
