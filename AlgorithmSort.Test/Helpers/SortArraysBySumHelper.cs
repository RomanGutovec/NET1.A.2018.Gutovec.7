using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort.Helpers
{
    /// <summary>
    /// Class for comparison two arrays in descending order by sum elements in a row
    /// </summary>
    public class SortArraysBySumHelper : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null)
            {
                return -1;
            }

            if (AlgorithmsHelper.CalculateSum(firstArray) > AlgorithmsHelper.CalculateSum(secondArray))
            {
                return 1;
            }
            else if (AlgorithmsHelper.CalculateSum(firstArray) == AlgorithmsHelper.CalculateSum(secondArray))
            {
                return 0;
            }

            return -1;
        }
    }
}
