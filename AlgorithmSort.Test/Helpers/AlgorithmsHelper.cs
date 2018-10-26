using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort.Helpers
{
    /// <summary>
    /// Class involve simple mathematical algorithms for calculating 
    /// </summary>
    public static class AlgorithmsHelper
    {
        /// <summary>
        /// Calculate sum elements in array
        /// </summary>
        /// <param name="array">source array</param>
        /// <returns>sum elements in array</returns>
        public static int CalculateSum(int[] array)
        {
            if (IsCheck(array))
            {
                return int.MinValue;
            }

            int sumElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumElements += array[i];
            }

            return sumElements;
        }

        /// <summary>
        /// Find min value in integer array
        /// </summary>
        /// <param name="array">source array</param>
        /// <returns>min value in integer array</returns>
        public static int FindMinElementInArray(int[] array)
        {
            if (IsCheck(array))
            {
                return int.MinValue;
            }

            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        /// <summary>
        /// Find max value in integer array
        /// </summary>
        /// <param name="array">source array</param>
        /// <returns>max value in integer array</returns>
        public static int FindMaxElementInArray(int[] array)
        {
            if (IsCheck(array))
            {
                return int.MinValue;
            }

            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        private static bool IsCheck(int[] array)
        {
            return array == null || array.Length == 0;
        }
    }
}
