using System.Collections.Generic;

namespace Implementation.HackerRank
{
    public class GradingStudents
    {
        public List<int> gradingStudents(List<int> grades)
        {

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                    continue;
                var temp = grades[i];
                while (temp % 5 != 0)
                    temp++;

                if (temp - grades[i] < 3) grades[i] = temp;
            }
            return grades;
        }
    }
}