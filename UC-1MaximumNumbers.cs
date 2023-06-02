using System;

namespace FindMaximumProblemUsingGenerics
{
    public class MaximumFinder<T> where T : IComparable<T>
    {
        public T FindMaximum(T a, T b, T c)
        {
            T max = a;

            if (b.CompareTo(max) > 0)
            {
                max = b;
            }

            if (c.CompareTo(max) > 0)
            {
                max = c;
            }

            return max;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MaximumFinder<int> maximumFinder = new MaximumFinder<int>();

            // Test Case 1: Max Number at 1st position
            int max1 = maximumFinder.FindMaximum(5, 2, 3);
            Console.WriteLine("Max number: " + max1);

            // Test Case 2: Max Number at 2nd position
            int max2 = maximumFinder.FindMaximum(1, 4, 2);
            Console.WriteLine("Max number: " + max2);

            // Test Case 3: Max Number at 3rd position
            int max3 = maximumFinder.FindMaximum(3, 1, 6);
            Console.WriteLine("Max number: " + max3);
        }
    }
}
