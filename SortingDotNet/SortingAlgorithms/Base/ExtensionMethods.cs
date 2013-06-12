using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class ExtensionMethods
    {
        public static void Exchange<T>(this IList<T> a, int i, int j) where T : IComparable<T>
        {
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

    }
}
