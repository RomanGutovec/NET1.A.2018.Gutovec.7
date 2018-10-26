using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort.Helpers
{
    /// <summary>
    /// Class for comparison two arrays in ascending order by min element in a row
    /// </summary>
    public class SortByMinElementHelper : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null)
            {
                return -1;
            }

            if (AlgorithmsHelper.FindMinElementInArray(firstArray) > AlgorithmsHelper.FindMinElementInArray(secondArray))
            {
                return 1;
            }
            else if (AlgorithmsHelper.FindMinElementInArray(firstArray) == AlgorithmsHelper.FindMinElementInArray(secondArray))
            {
                return 0;
            }

            return -1;
        }
    }
}
