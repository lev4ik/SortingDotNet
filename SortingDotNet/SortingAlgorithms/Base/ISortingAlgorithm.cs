using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public interface ISortingAlgorithm
    {
        IList<T> Sort<T>(IList<T> arrayToSort) where T : IComparable, IComparable<T>;
    }
}
