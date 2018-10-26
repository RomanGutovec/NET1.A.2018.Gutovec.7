using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort.Helpers
{
    /// <summary>
    /// Class for comparison two arrays in ascending order by sum elements in a row
    /// </summary>
    public class SortArraysBySumDescendingHelper : IComparer<int[]>
    {
        /// <summary>
        /// Compare two integer arrays
        /// </summary>
        /// <param name="firstArray">first source array</param>
        /// <param name="secondArray">second source array</param>
        /// <returns>value for sorting</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null)
            {
                return 1;
            }

            if (AlgorithmsHelper.CalculateSum(firstArray) > AlgorithmsHelper.CalculateSum(secondArray))
            {
                return -1;
            }
            else if (AlgorithmsHelper.CalculateSum(firstArray) == AlgorithmsHelper.CalculateSum(secondArray))
            {
                return 0;
            }

            return 1;
        }
    }
}
