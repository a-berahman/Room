using System;

namespace Dynamic_Programming.HackerRank
{
    public class Max_Array_Sum
    {

        public int maxSubsetSum(int[] arr)
        {

            var _include = arr[0]; //max sum including the previous elemnt
            var _exclude = 0;//max sum excluding the previus element

            //we have 2 formul for this statment
            //we should calculate the include and exclude with below formul
            // include=exclude+arr[i] , the first question ? where is exlude ?
            //exclude is a first element before first element so every time at the first is 0
            // exclude=max(include,exclude)

            //set i equals 1 , becuase we take first elment from array in above  
            for (int i = 1; i < arr.Length; i++)
            {
                //store max _include and _Exclude before set new _exclude value
                //because we need compute _include with previus _exclude plus current element
                var _tempExclude = Math.Max(_include, _exclude);
                _include = _exclude + arr[i];
                _exclude = _tempExclude;
            }

            //finally return max as a maximum sum
            return Math.Max(_include, _exclude);
        }

    }
}