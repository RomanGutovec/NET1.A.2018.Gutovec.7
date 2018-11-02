using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    /// <summary>
    /// This class represents opportunity to sort jagged array by bubble method
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Sort jagged array by bubble method
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when jagged array and condition of comparison have null value</exception>
        /// <exception cref="ArgumentException">Thrown when jagged array have zero length</exception>
        /// <param name="jaggedArray"></param>
        /// <param name="comparer">condition of comparison</param>
        public static void SortJaggedArray(int[][] jaggedArray, IComparer<int[]> comparer)
        {
            ChekInputArray(jaggedArray);

            if (comparer == null)
            {
                throw new ArgumentNullException($"Condition of comparison '{nameof(comparer)}' have null value");
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        public static void SortJaggedArray(int[][] jaggedArray, Comparison<int[]> comparer)
        {
            ChekInputArray(jaggedArray);

            if (comparer == null)
            {
                throw new ArgumentNullException($"Condition of comparison '{nameof(comparer)}' have null value");
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i - 1; j++)
                {
                    if (comparer(jaggedArray[j], jaggedArray[j + 1]) > 0)
                    {
                        Swap(ref jaggedArray[j], ref jaggedArray[j + 1]);
                    }
                }
            }
        }

        private static void ChekInputArray(int[][] jaggedArray)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentNullException($"Array {nameof(jaggedArray)} have null value");
            }

            if (jaggedArray.Length == 0)
            {
                throw new ArgumentException($"Array {nameof(jaggedArray)} have no elements");
            }
        }

        private static void Swap(ref int[] firstArray, ref int[] secondArray)
        {
            int[] temp = firstArray;
            firstArray = secondArray;
            secondArray = temp;
        }
    }
}