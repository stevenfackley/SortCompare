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
/*This implementation of bubble sort has a time complexity of O(n^2) in the worst case, but it can be optimized by adding a flag to keep track of whether any swaps were made during a pass through the array. If no swaps were made, the array is already sorted and the sorting can be stopped. This optimization reduces the time complexity to O(n) in the best case.


*/
        static void BubbleSort(int[] array)
        {
          bool swapped;
    do
    {
        swapped = false;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                // Swap the elements
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                swapped = true;
            }
        }
    } while (swapped);
}


/*This implementation of selection sort has a time complexity of O(n^2) in the worst case and average case, but it has a space complexity of O(1) as it only requires a single extra variable to store the index of the minimum element. It is generally not as efficient as other sorting algorithms such as quicksort or mergesort, but it can be useful in certain situations where the space complexity is a concern.
*/

static void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }
        if (minIndex != i)
        {
            // Swap the elements
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
    }
}

/*
This implementation of insertion sort has a time complexity of O(n^2) in the worst case and average case, but it has a space complexity of O(1) as it only requires a single extra variable to store the current element being inserted. It is generally more efficient than bubble sort and selection sort for small arrays, but it becomes less efficient as the size of the array increases.
*/
static void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int current = array[i];
        int j = i - 1;
        while (j >= 0 && array[j] > current)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = current;
    }
}

/*
This implementation of merge sort has a time complexity of O(n*log(n)) in the worst case and average case, and a space complexity of O(n) as it requires additional arrays to store the left and right halves of the array being sorted. It is a stable sort, meaning that the relative order of elements with equal values is preserved. It is also generally faster and more efficient than bubble sort and selection sort for large arrays.
*/
static void MergeSort(int[] array, int start, int end)
{
    if (start < end)
    {
        int mid = (start + end) / 2;
        MergeSort(array, start, mid);
        MergeSort(array, mid + 1, end);
        Merge(array, start, mid, end);
    }
}

static void Merge(int[] array, int start, int mid, int end)
{
    int n1 = mid - start + 1;
    int n2 = end - mid;

    int[] left = new int[n1];
    int[] right = new int[n2];

    for (int i = 0; i < n1; i++)
    {
        left[i] = array[start + i];
    }
    for (int j = 0; j < n2; j++)
    {
        right[j] = array[mid + 1 + j];
    }

    int i = 0;
    int j = 0;
    int k = start;
    while (i < n1 && j < n2)
    {
        if (left[i] <= right[j])
        {
            array[k] = left[i];
            i++;
        }
        else
        {
            array[k] = right[j];
            j++;
        }
        k++;
    }

    while (i < n1)
    {
        array[k] = left[i];
        i++;
        k++;
    }

    while (j < n2)
    {
        array[k] = right[j];
        j++;
        k++;
    }
}

	}
}
