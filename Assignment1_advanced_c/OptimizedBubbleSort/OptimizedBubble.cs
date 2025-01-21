using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_advanced_c.OptimizedBubbleSort
{
    internal class OptimizedBubble
    {
        public static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
       
    }
}
