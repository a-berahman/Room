namespace Arrays_String.CrackingTheCodingInterview
{
    public class URLify
    {
        int Count_the_number_of_spaces(char[] input)
        {
            var spaceCount = 0;
            foreach (var character in input)
            {
                if (character == ' ')
                    spaceCount++;
            }
            return spaceCount;
        }
        public string ReplaceSpaces(char[] input, int length)
        {
            var space = new[] { '0', '2', '%' };
            var spaceCount = Count_the_number_of_spaces(input);
            // calculate new string size
            var index = length + spaceCount * 2;
            var temp = new char[index];
            for (int i = 0; i < length; i++)
            {
                temp[i] = input[i];
            }

            void SetCharsAndMoveIndex(params char[] chars)
            {
                foreach (var c in chars)
                    temp[--index] = c;
            }
            // copying the characters backwards and inserting %20
            for (var indexSource = length - 1; indexSource >= 0; indexSource--)
                if (temp[indexSource] == ' ')
                    SetCharsAndMoveIndex(space);
                else SetCharsAndMoveIndex(temp[indexSource]);
            return new string(temp);
        }
    }
}