using System;

namespace Arrays_String.LeetCode
{
    public class K_Closest_Points_to_Origin
    {
        public int[][] KClosest(int[][] points, int K)
        {
            int N = points.Length;
            int[] dists = new int[N];
            for (int i = 0; i < N; ++i)
                dists[i] = dist(points[i]);

            Array.Sort(dists);
            int distK = dists[K - 1];

            int[][] ans = new int[K][];
            int t = 0;
            for (int i = 0; i < N; ++i)
                if (dist(points[i]) <= distK)
                    ans[t++] = points[i];
            return ans;
        }

        public int dist(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }
}