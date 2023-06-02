using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    internal class Refactor
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
                MaximumFinder<int> intMaximumFinder = new MaximumFinder<int>();

                // Test Case 1: Max Number at 1st position
                int maxInt1 = intMaximumFinder.FindMaximum(5, 2, 3);
                Console.WriteLine("Max number: " + maxInt1);

                // Test Case 2: Max Number at 2nd position
                int maxInt2 = intMaximumFinder.FindMaximum(1, 4, 2);
                Console.WriteLine("Max number: " + maxInt2);

                // Test Case 3: Max Number at 3rd position
                int maxInt3 = intMaximumFinder.FindMaximum(3, 1, 6);
                Console.WriteLine("Max number: " + maxInt3);

                MaximumFinder<float> floatMaximumFinder = new MaximumFinder<float>();

                // Test Case 4: Max Number at 1st position (Float)
                float maxFloat1 = floatMaximumFinder.FindMaximum(5.2f, 2.3f, 3.8f);
                Console.WriteLine("Max number: " + maxFloat1);

                // Test Case 5: Max Number at 2nd position (Float)
                float maxFloat2 = floatMaximumFinder.FindMaximum(1.1f, 4.4f, 2.2f);
                Console.WriteLine("Max number: " + maxFloat2);

                // Test Case 6: Max Number at 3rd position (Float)
                float maxFloat3 = floatMaximumFinder.FindMaximum(3.7f, 1.5f, 6.2f);
                Console.WriteLine("Max number: " + maxFloat3);

                MaximumFinder<string> stringMaximumFinder = new MaximumFinder<string>();

                // Test Case 7: Max String at 1st position
                string maxString1 = stringMaximumFinder.FindMaximum("Apple", "Peach", "Banana");
                Console.WriteLine("Max string: " + maxString1);

                // Test Case 8: Max String at 2nd position
                string maxString2 = stringMaximumFinder.FindMaximum("Cherry", "Pineapple", "Orange");
                Console.WriteLine("Max string: " + maxString2);

                // Test Case 9: Max String at 3rd position
                string maxString3 = stringMaximumFinder.FindMaximum("Grape", "Kiwi", "Watermelon");
                Console.WriteLine("Max string: " + maxString3);
            }
        }
    }
}
