using System;
using System.Collections.Generic;

namespace SortingAlgorithms.ComparisonBased
{
    public class BubbleSort : ISortingAlgorithm
    {
        #region ISortingAlgorithm Members

        public IList<T> Sort<T>(IList<T> list) where T : IComparable, IComparable<T>
        {
            var arrayToSort = list;
            for (var i = 0; i < arrayToSort.Count; i++)
            {
                for (var j = i + 1; j < arrayToSort.Count; j++)
                {
                    if (arrayToSort[i].CompareTo(arrayToSort[j]) > 0)
                    {
                        arrayToSort.Exchange(i, j);
                    }
                }                
            }
            return arrayToSort;
        }

        #endregion
    }
}
