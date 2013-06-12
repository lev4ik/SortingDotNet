using System;
using System.Collections.Generic;
using SortingAlgorithms;
using SortingAlgorithms.ComparisonBased;

namespace SortingAlgorithmsComparison.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random(10000);
            var sortingContext = new List<ISortingAlgorithm>();
            sortingContext.Add(new BubbleSort());
            sortingContext.Add(new MergeSort());
            sortingContext.Add(new QuickSort());

            Console.Write("Please Insert Array Size : ");
            var arrsize = Console.ReadLine();

            var arrToSort = new List<int>();

            for (int i = 0; i < Convert.ToInt32(arrsize); i++)
            {
                int num = rand.Next(0, int.MaxValue);
                arrToSort.Add(num);
            }

            foreach (var sortingAlgorithm in sortingContext)
            {
                var algoName = sortingAlgorithm.GetType().Name;
                var start = DateTime.Now;
                Console.WriteLine("Starting " + algoName + " [" + arrsize + "] records");
                var sortedArr = sortingAlgorithm.Sort(arrToSort);
                var end = DateTime.Now;
                Console.WriteLine("Finished " + algoName + ", sorting time is : " + end.Subtract(start).TotalMilliseconds + "ms. with ");
                //Console.WriteLine(sortedArr.Convert());
            }

            Console.Read();
        }
    }
}
