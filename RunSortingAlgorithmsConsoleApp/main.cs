using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Sorting;
class MainClass
{
    public static bool TestSortingAlgorithm(ISortingAlgorithm sortingAlgorithm)
    {
        Console.WriteLine($"## Testing sorting algorithm {sortingAlgorithm.GetType().Name}");
        Console.WriteLine("1. Checking the algorithm works");
        if (!sortingAlgorithm.CheckIsCorrect())
            return false;

        Console.WriteLine("2. Measuring speed");
        Stopwatch stopwatch = new Stopwatch();


        int maxSize = 100000;
        int size = 10;
        while (size <= maxSize)
        {
            int[] A = Utils.CreateIntArray(size);

            stopwatch.Start();
            sortingAlgorithm.Sort(A);

            stopwatch.Stop();

            if (!Utils.IsOrdered(A))
                return false;

            Console.WriteLine($"n={size} => {stopwatch.Elapsed.TotalSeconds}s");

            size *= 10;
        }
        Console.WriteLine();
        return true;
    }

    private static bool RunTestsWithTimeout(Func<ISortingAlgorithm, bool> testFunc, ISortingAlgorithm algorithm, int timeoutSecs)
    {
        Task<bool> testTask = Task.Factory.StartNew(() => { return testFunc(algorithm); });
        Task timeoutTask = Task.Delay(timeoutSecs * 1000);
        Task winner = Task.WhenAny(testTask, timeoutTask).Result;
        if (winner == testTask)
        {
            return true;
        }
        return false;
    }

    public static void Main(string[] args)
    {
        bool success = RunTestsWithTimeout(TestSortingAlgorithm, new SelectionSort(), 20);
        if (!success)
        {
            Console.WriteLine("The tests took too long. Try to make the algorithm faster");
            return;
        }

        success = RunTestsWithTimeout(TestSortingAlgorithm, new QuickSort(), 20);
        if (!success)
        {
            Console.WriteLine("The tests took too long. Try to make the algorithm faster");
            return;
        }

        success = RunTestsWithTimeout(TestSortingAlgorithm, new MergeSort(), 20);
        if (!success)
        {
            Console.WriteLine("The tests took too long. Try to make the algorithm faster");
            return;
        }
    }
}