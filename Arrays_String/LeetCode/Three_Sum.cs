using System;
using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Three_Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            int target = 0;
            IList<IList<int>> triplets = new List<IList<int>>();
            HashSet<string> keys = new HashSet<string>();
            var flag = true;
            if (nums == null || nums.Length == 0 || nums.Length < 3)
                return triplets;

            //if all input are target value
            foreach (var item in nums)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                triplets.Add(new List<int> { 0, 0, 0 });
                return triplets;
            }

            Array.Sort(nums);

            int len = nums.Length;

            for (int i = 0; i < len - 2; i++)
            {
                int[] trialTriplet = new int[3];
                trialTriplet[0] = nums[i];


                int newTarget = target - trialTriplet[0];
                int head = i + 1;
                int tail = len - 1;

                while (head < tail)
                {
                    trialTriplet[1] = nums[head];
                    trialTriplet[2] = nums[tail];

                    int twoSumValue = trialTriplet[1] + trialTriplet[2];

                    if (twoSumValue == newTarget)
                    {
                        string key = getKey(trialTriplet, 3);

                        if (!keys.Contains(key))
                        {
                            keys.Add(key);

                            IList<int> triplet = new List<int>();

                            for (int j = 0; j < 3; j++)
                                triplet.Add(trialTriplet[j]);

                            triplets.Add(triplet);
                        }


                        head++;
                        tail--;

                    }
                    else if (twoSumValue > newTarget)
                    {
                        tail--;
                    }
                    else if (twoSumValue < newTarget)
                    {
                        head++;
                    }
                }
            }

            return triplets;
        }

        private static string getKey(int[] arr, int len)
        {
            string key = "";

            for (int j = 0; j < 3; j++)
            {
                key += arr[j].ToString();
                key += ",";
            }

            return key;
        }
    }
}