using System;
using System.Collections.Generic;

namespace SortingAlgorithms.ComparisonBased
{
    public class MergeSort : ISortingAlgorithm
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
            {
                return;
            }
            var m = (int)Math.Floor((decimal)(low + high) / 2);
            Sort(ref list, low, m);
            Sort(ref list, m + 1, high);
            Merge(ref list, low, m, high);
        }

        private void Merge<T>(ref IList<T> list, int lo, int m, int high) where T : IComparable, IComparable<T>
        {
            int rightSideIndex = m+1, leftSideIndex = lo;
            while (leftSideIndex <= m && rightSideIndex <= high)
            {
                if (list[rightSideIndex].CompareTo(list[leftSideIndex]) < 0)
                {
                    list.Exchange(rightSideIndex, leftSideIndex);
                    rightSideIndex++;
                }
                else
                {
                    leftSideIndex++;
                }
            }
        }

        #endregion
    }
}