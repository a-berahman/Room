using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
public static int right { get; set; }
public static int left { get; set; }
    public static int diagonalDifference(List<List<int>> arr)
    {
        right=0;
left=0;
        return recursive(arr, 0);
    }
    public static int recursive(List<List<int>> arr, int index)
    {
        if (index > 2)
            return 0;

        
        switch (index)
        {
            case 0:
                right += arr[index][2];
                left += arr[index][0];
                break;
            case 1:
                right += arr[index][1];
                left += arr[index][1];
                break;
            case 2:
                right += arr[index][0];
                left += arr[index][2];
                break;
            default:
                break;
        }
        recursive(arr, index++);
        return left - right;

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
