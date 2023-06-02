﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumProblemUsingGenerics
{
    internal class UC_5TestMaximum
    {
        public class MaximumFinder<T> where T : IComparable<T>
        {
            public T FindMaximum(params T[] values)
            {
                if (values == null || values.Length == 0)
                {
                    throw new ArgumentException("At least one value must be provided.");
                }

                List<T> valueList = new List<T>(values);
                valueList.Sort();

                T max = valueList[valueList.Count - 1];
                PrintMax(max);

                return max;
            }

            private void PrintMax(T max)
            {
                Console.WriteLine("Max value: " + max);
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                MaximumFinder<int> intMaximumFinder = new MaximumFinder<int>();

                // Test Case 1: Max Number among 4 integers
                int maxInt1 = intMaximumFinder.FindMaximum(5, 2, 3, 9);

                MaximumFinder<float> floatMaximumFinder = new MaximumFinder<float>();

                // Test Case 2: Max Number among 5 floats
                float maxFloat1 = floatMaximumFinder.FindMaximum(5.2f, 2.3f, 3.8f, 7.1f, 4.6f);

                MaximumFinder<string> stringMaximumFinder = new MaximumFinder<string>();

                // Test Case 3: Max String among 6 strings
                string maxString1 = stringMaximumFinder.FindMaximum("Apple", "Peach", "Banana", "Cherry", "Grape", "Watermelon");
            }
        }
    }
}
