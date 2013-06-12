using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class ExtensionMethods
    {
        public static void Exchange<T>(this IList<T> list, int i, int j) where T : IComparable<T>
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

        public static string Convert<T>(this IList<T> list) where T : IComparable<T>
        {
            var builder = new StringBuilder();
            foreach (var item in list)
            {
                builder.Append(item + ",");
            }
            return builder.ToString().TrimEnd(',');
        }
    }
}
