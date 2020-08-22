using System.Collections.Generic;

namespace Arrays_String.LeetCode
{
    public class Check_If_N_and_Its_Double_Exist
    {
    public bool CheckIfExist(int[] arr) {
            var hash=new HashSet<double>();
            foreach (var item in arr)
            {
                if(hash.Contains(item/2.0) || hash.Contains(item*2) )
                    return true;
                    hash.Add(item);
                
            }
            return false;
    }
    }
}