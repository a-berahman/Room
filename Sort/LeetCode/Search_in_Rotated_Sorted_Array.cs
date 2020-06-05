
namespace Sort.LeetCode
{
    public class Search_in_Rotated_Sorted_Array
    {
        public int Search(int[] nums, int target)
        {
            int low = 0; int high = nums.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var cmp = target.CompareTo(nums[mid]);
                if (cmp == 0) return mid;
                else if (nums[mid] >= nums[low])
                {
                    if (target >= nums[low] && cmp < 0) high = mid - 1;
                    else low = mid + 1;
                }
                else
                {
                    if (target <= nums[high] && cmp > 0) low = mid + 1;
                    else high = mid - 1;
                }
            }

            return -1;
        }
    }
}
