namespace Arrays_String.LeetCode
{
    public class Replace_Elements_with_Greatest_Element_on_Right_Side
    {
        public int[] ReplaceElements(int[] arr)
        {
            var last = arr[arr.Length - 1];
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                var temp=arr[i];
                arr[i]=last;
                if(last<temp)
                last=temp;


            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}