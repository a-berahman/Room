namespace Implementation.HackerRank
{
    public class Breaking_the_Records
    {    // Complete the breakingRecords function below.
        public int[] breakingRecords(int[] scores)
        {
            var min = scores[0];
            var max = scores[0];
            var record = new int[2] { 0, 0 };
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    record[0]++;
                }
                else
                if (scores[i] < min)
                {
                    min = scores[i];
                    record[1]++;
                }
            }
            return record;
        }

    }
}