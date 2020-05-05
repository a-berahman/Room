using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Algorithm.SelectionSort().DoSort();            
            // new Algorithm.InsertionSort().DoSort();
            // new Algorithm.ShellSort().DoSort();
            new Algorithm.MergeSort().DoSort(new int[13] { 2, 3, 1, 6, 9, 10, 19, 25, 5, 39, 1000, 53, 901 });
        }
    }
}
