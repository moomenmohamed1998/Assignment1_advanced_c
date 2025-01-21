using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_advanced_c.Generics
{
    internal  class Helper<T>
    {

        #region 1-
        //1-Create a generic class named Range<T> where T represents the type of values.
        //public static void Range<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //} 
        #endregion

        #region 2-

        //2-Implement a constructor that takes the minimum and maximum values to define the range.
        //public class Range<T> where T : IComparable<T>
        //{
        //    public T Min { get;  set; }
        //    public T Max { get;  set; }

        //    public Range(T minimum, T maximum)
        //    {
        //        if (minimum.CompareTo(maximum) > 0)
        //        {
        //            throw new ArgumentException("Minimum value must be less than or equal to the maximum value.");
        //        }

        //        Min = minimum;
        //        Max = maximum;
        //    }

        //    public bool Contains(T value)
        //    {
        //        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        //    }

        //    public T GetLength()
        //    {
        //        dynamic min = Min;
        //        dynamic max = Max;
        //        return max - min;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Range: [{Min}, {Max}]";
        //    }
        //} 
        #endregion





    }
}
