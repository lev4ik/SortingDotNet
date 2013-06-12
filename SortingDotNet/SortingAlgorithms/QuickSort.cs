using System;
using System.Collections.Generic;

namespace SortingAlgorithms.ComparisonBased
{
    public class QuickSort : ISortingAlgorithm
    {
        #region ISortingAlgorithm Members

        public IList<T> Sort<T>(IList<T> list) where T : IComparable, IComparable<T>
        {
            var arrayToSort = list;
            Sort(ref arrayToSort, 0, arrayToSort.Count - 1);
            return arrayToSort;
        }

        #endregion

        #region Methods

        private void Sort<T>(ref IList<T> list, int low, int high) where T : IComparable, IComparable<T>
        {
            if (low >= high) 
                return;
            var pivotLocation = Partition(list, low, high);
            Sort(ref list, low, pivotLocation);
            Sort(ref list, pivotLocation + 1, high);
        }

        private int Partition<T>(IList<T> list, int low, int high) where T : IComparable, IComparable<T>
        {
            var pivot = list[low];
            var leftfall = low;

            for (var i = low + 1; i < high; i++)
            {
                if (list[i].CompareTo(pivot) < 0)
                {
                    ++leftfall;
                    list.Exchange(i, leftfall);
                }
            }

            list.Exchange(low, leftfall);

            return leftfall;         
        }

        #endregion        
    }
}
