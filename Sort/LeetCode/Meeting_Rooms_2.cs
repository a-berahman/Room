using System;
using System.Linq;

namespace Sort.LeetCode
{
    public class Meeting_Rooms_2
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length <= 1) return intervals.Length;
            var list = intervals.ToList();
            var start = new int[intervals.Length];
            var end = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = list[i][0];
                end[i] = list[i][1];
            }

            Array.Sort(start);
            Array.Sort(end);



            // The two pointers in the algorithm: e_ptr and s_ptr.
            int startPointer = 0, endPointer = 0;

            // Variables to keep track of maximum number of rooms used.
            int usedRooms = 0;

            // Iterate over intervals.
            while (startPointer < intervals.Length)
            {

                // If there is a meeting that has ended by the time the meeting at `start_pointer` starts
                if (start[startPointer] >= end[endPointer])
                {
                    usedRooms -= 1;
                    endPointer += 1;
                }

                // We do this irrespective of whether a room frees up or not.
                // If a room got free, then this used_rooms += 1 wouldn't have any effect. used_rooms would
                // remain the same in that case. If no room was free, then this would increase used_rooms
                usedRooms += 1;
                startPointer += 1;
            }
            return usedRooms;
        }
    }

}