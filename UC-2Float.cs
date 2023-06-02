using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    internal class UC_2Float
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
                MaximumFinder<float> maximumFinder = new MaximumFinder<float>();

                // Test Case 1: Max Number at 1st position
                float max1 = maximumFinder.FindMaximum(5.2f, 2.3f, 3.8f);
                Console.WriteLine("Max number: " + max1);

                // Test Case 2: Max Number at 2nd position
                float max2 = maximumFinder.FindMaximum(1.1f, 4.4f, 2.2f);
                Console.WriteLine("Max number: " + max2);

                // Test Case 3: Max Number at 3rd position
                float max3 = maximumFinder.FindMaximum(3.7f, 1.5f, 6.2f);
                Console.WriteLine("Max number: " + max3);

                // Test Case 4: Max Number at 1st position (Repeated from the first problem)
                int max4 = maximumFinder.FindMaximum(5, 2, 3);
                Console.WriteLine("Max number: " + max4);

                // Test Case 5: Max Number at 2nd position (Repeated from the first problem)
                int max5 = maximumFinder.FindMaximum(1, 4, 2);
                Console.WriteLine("Max number: " + max5);

                // Test Case 6: Max Number at 3rd position (Repeated from the first problem)
                int max6 = maximumFinder.FindMaximum(3, 1, 6);
                Console.WriteLine("Max number: " + max6);
            }
        }
    }
}
