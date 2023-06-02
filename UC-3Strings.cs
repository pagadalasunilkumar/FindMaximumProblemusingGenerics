using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    internal class UC_3Strings
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
                MaximumFinder<string> maximumFinder = new MaximumFinder<string>();

                // Test Case 1: Max String at 1st position
                string max1 = maximumFinder.FindMaximum("Apple", "Peach", "Banana");
                Console.WriteLine("Max string: " + max1);

                // Test Case 2: Max String at 2nd position
                string max2 = maximumFinder.FindMaximum("Cherry", "Pineapple", "Orange");
                Console.WriteLine("Max string: " + max2);

                // Test Case 3: Max String at 3rd position
                string max3 = maximumFinder.FindMaximum("Grape", "Kiwi", "Watermelon");
                Console.WriteLine("Max string: " + max3);

                // Test Case 4: Max String at 1st position (Repeated from UC 1)
                int max4 = maximumFinder.FindMaximum(5, 2, 3);
                Console.WriteLine("Max number: " + max4);

                // Test Case 5: Max String at 2nd position (Repeated from UC 1)
                int max5 = maximumFinder.FindMaximum(1, 4, 2);
                Console.WriteLine("Max number: " + max5);

                // Test Case 6: Max String at 3rd position (Repeated from UC 1)
                int max6 = maximumFinder.FindMaximum(3, 1, 6);
                Console.WriteLine("Max number: " + max6);
            }
        }
    }
}
