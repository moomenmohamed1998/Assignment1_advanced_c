using Assignment1_advanced_c.Generics;
using Assignment1_advanced_c.OptimizedBubbleSort;

namespace Assignment1_advanced_c
{
    internal class Program
    {
         static void Main(string[] args)
        {
            #region The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm  And implement the code of this optimized bubble sort algorithm

            //int[] arr = { 10, 20, 30, 40, 50, 60, 70 };

            //Console.WriteLine("Original array:");
            //Console.WriteLine(string.Join(", ", arr));
            //Console.WriteLine("=============================");
            //OptimizedBubble.OptimizedBubbleSort(arr);
            //Console.WriteLine("Sorted array:");
            //Console.WriteLine(string.Join(", ", arr));
            //Console.WriteLine("============================="); 
            #endregion

            #region Create a generic class named Range<T> where T represents the type of values.

            int A = 3, B = 5;
            Console.WriteLine($"A={A}");
            Console.WriteLine($"B={B}");
            Console.WriteLine("===============");
            Helper.Range<int>(ref A, ref B);
            Console.WriteLine($"A={A}");
            Console.WriteLine($"B={B}");

            #endregion


        }
    }
}

