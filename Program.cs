using System;
using System.Diagnostics;

namespace BigOComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the Big O complexity of the given method
            TestMethodComplexity();

            // Test the top 5 sorting algorithms
            TestSortingAlgorithms();
        }

        static void TestMethodComplexity()
        {
            // Create a Stopwatch to measure the execution time of the method
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();

            // Call the method to be tested
            MethodToTest();

            // Stop the stopwatch
            stopwatch.Stop();

            // Print the elapsed time
            Console.WriteLine("Method execution time: " + stopwatch.ElapsedMilliseconds + "ms");
        }

        static void MethodToTest()
        {
            // Add the code for the method to be tested here
        }

        static void TestSortingAlgorithms()
        {
            // Test bubble sort
            int[] array = { 3, 5, 1, 2, 4 };
            Console.WriteLine("Original array: [3, 5, 1, 2, 4]");
            BubbleSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            // Test selection sort
            array = new int[] { 3, 5, 1, 2, 4 };
            Console.WriteLine("Original array: [3, 5, 1, 2, 4]");
            SelectionSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            // Test insertion sort
            array = new int[] { 3, 5, 1, 2, 4 };
            Console.WriteLine("Original array: [3, 5, 1, 2, 4]");
            InsertionSort(array);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            // Test merge sort
            array = new int[] { 3, 5, 1, 2, 4 };
            Console.WriteLine("Original array: [3, 5, 1, 2, 4]");
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));

            // Test quick sort
            array = new int[] { 3, 5, 1, 2, 4 };
            Console.WriteLine("Original array: [3, 5, 1, 2, 4]");
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        static void BubbleSort(int[] array)
        {
            // Add the code for bubble sort here
        }

        static void SelectionSort(int[] array)
        {
            // Add the code for selection sort here
        }

        static void InsertionSort(int[] array)
        {
            // Add the code for insertion sort here
        }

        static void MergeSort(int[] array, int start, int end)
        {
            // Add
		}
	}
}
