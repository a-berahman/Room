using System;

namespace Arrays_String.LeetCode
{
    public class Task_Scheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {

            int maxFrequency = 0;
            int countOfTasksWithMaxFrequency = 0;
            int[] taskFreq = new int[26];
            foreach (char task in tasks)
            {
                int index = task - 'A';
                taskFreq[index]++;
                if (maxFrequency < taskFreq[index])         //New Max
                {
                    maxFrequency = taskFreq[index];
                    countOfTasksWithMaxFrequency = 1;
                }
                else if (maxFrequency == taskFreq[index])    //Same Max
                {
                    countOfTasksWithMaxFrequency++;
                }
            }

            int countOfFramesBetweenMostFrequentTask = maxFrequency - 1;
            int frameLengthToBeFilledByTasksWithLessThanMaxFrequency = n - (countOfTasksWithMaxFrequency - 1);
            int emptySlotsToBeFilledByTasksWithLessThanMaxFrequency = countOfFramesBetweenMostFrequentTask * frameLengthToBeFilledByTasksWithLessThanMaxFrequency;
            int countOfTasksWithLessThanMaxFrequency = tasks.Length - (maxFrequency * countOfTasksWithMaxFrequency);
            int idles = Math.Max(0, emptySlotsToBeFilledByTasksWithLessThanMaxFrequency - countOfTasksWithLessThanMaxFrequency);
            return tasks.Length + idles;
        }
    }
}