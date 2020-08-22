namespace Sort.LeetCode
{
    public class Find_Pick_Element
    {
        public int FindPeakElement(int[] nums)
        {
           int l=0; int r=nums.Length-1;
           while(l<r)
           {
               var mid=l+(r-l)/2;
               if(nums[mid]>nums[mid+1])
               r=mid;
               else l=mid+1;
           }
           return r;
        }
    }
}