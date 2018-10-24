using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    /// <summary>
    /// Class which sorts "jagged" array by insert method
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Kinds of sorting jagged array
        /// </summary>
        public enum SortBy
        {
            Sum = 0,
            MinElementInRow,
            MaxElementInRow,
        }

        /// <summary>
        /// Kinds of order rows in jagged array
        /// </summary>
        public enum OrderBy
        {
            Ascending = 0,
            Descending
        }

        /// <summary>
        /// Sort jagged array by insert method
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when jagged array have null value</exception>
        /// <exception cref="ArgumentException">Thrown when jagged array have zero length</exception>
        /// <param name="jaggedArray">source jugged array to sort</param>
        public static void SortJagged(int[][] jaggedArray)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentNullException($"Array {nameof(jaggedArray)} have null value");
            }

            if (jaggedArray.Length == 0)
            {
                throw new ArgumentException($"Array {nameof(jaggedArray)} have no elements");
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = SortInserts(jaggedArray[i]);
            }
        }

        /// <summary>
        /// Sort jagged array by insert method with chosen order of the rows
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when jagged array have null value</exception>
        /// <exception cref="ArgumentException">Thrown when jagged array have zero length</exception>
        /// <param name="jaggedArray">source jugged array to sort</param>
        public static void SortJagged(int[][] jaggedArray, OrderBy nameOrder)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentNullException($"Array {nameof(jaggedArray)} have null reference");
            }

            if (jaggedArray.Length == 0)
            {
                throw new ArgumentException($"Array {nameof(jaggedArray)} have no elements");
            }

            SortJagged(jaggedArray);
            if ((int)nameOrder == 1)
            {
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    jaggedArray[i] = Reverse(jaggedArray[i]);
                }
            }
        }

        /// <summary>
        /// Sort jagged array by insert method with chosen operation of the each row
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when jagged array have null value</exception>
        /// <exception cref="ArgumentException">Thrown when jagged array have zero length</exception>
        /// <param name="jaggedArray">source jugged array to sort</param>
        public static int[][] SortJagged(int[][] jaggedArray, SortBy nameSortby)
        {
            Console.WriteLine("(int)nameSortby {0}", (int)nameSortby);
            if (jaggedArray == null)
            {
                throw new ArgumentNullException($"Array {nameof(jaggedArray)} have null reference");
            }

            if (jaggedArray.Length == 0)
            {
                throw new ArgumentException($"Array {nameof(jaggedArray)} have no elements");
            }

            switch ((int)nameSortby)
            {
                case 0: jaggedArray = SortInsertsBySum(jaggedArray); break;
                case 1: jaggedArray = SortInsertsByMin(jaggedArray); break;
                case 2: jaggedArray = SortInsertsByMax(jaggedArray); break;
            }

            return jaggedArray;
        }

        /// <summary>
        /// Sort jagged array by insert method with chosen operation and order of the each row
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when jagged array have null value</exception>
        /// <exception cref="ArgumentException">Thrown when jagged array have zero length</exception>
        /// <param name="jaggedArray">source jugged array to sort</param>
        public static int[][] SortJagged(int[][] jaggedArray, SortBy nameSortBy, OrderBy nameOrder)
        {
            jaggedArray = SortJagged(jaggedArray, nameSortBy);
            if ((int)nameOrder == 1)
            {
                int[][] tempArray = new int[jaggedArray.Length][];
                Array.Copy(jaggedArray, tempArray, jaggedArray.Length);

                for (int i = jaggedArray.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    jaggedArray[j] = tempArray[i];
                }
            }

            return jaggedArray;
        }

        private static int[] SortInserts(int[] arraySource)
        {
            int[] result = new int[arraySource.Length];
            for (int i = 0; i < arraySource.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > arraySource[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }

                result[j] = arraySource[i];
            }

            return result;
        }

        private static int[] Reverse(int[] arraySource)
        {
            int[] result = new int[arraySource.Length];

            for (int i = 0, j = arraySource.Length - 1; i < arraySource.Length; i++, j--)
            {
                result[i] = arraySource[j];
            }

            return result;
        }

        private static int[][] SortInsertsBySum(int[][] array)
        {
            int[] arraySum = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arraySum[i] = CalculateSum(array[i]);
            }

            arraySum = SortInserts(arraySum);
            int[][] resultArray = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (arraySum[i] == CalculateSum(array[j]))
                    {
                        resultArray[i] = array[j];
                    }
                }
            }

            return resultArray;
        }

        private static int[][] SortInsertsByMin(int[][] array)
        {
            int[] arrayMinElInRow = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayMinElInRow[i] = FindMinElement(array[i]);
            }

            arrayMinElInRow = SortInserts(arrayMinElInRow);
            int[][] resultArray = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (arrayMinElInRow[i] == FindMinElement(array[j]))
                    {
                        resultArray[i] = array[j];
                    }
                }
            }

            return resultArray;
        }

        private static int[][] SortInsertsByMax(int[][] array)
        {
            int[] arrayMaxElInRow = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayMaxElInRow[i] = FindMaxElement(array[i]);
            }

            int[][] resultArray = new int[array.Length][];
            arrayMaxElInRow = SortInserts(arrayMaxElInRow);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (arrayMaxElInRow[i] == FindMinElement(array[j]))
                    {
                        resultArray[i] = array[j];
                    }
                }
            }

            return resultArray;
        }

        private static int CalculateSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        private static int FindMaxElement(int[] array)
        {
            int tempMax = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > tempMax)
                {
                    tempMax = array[i];
                }
            }

            return tempMax;
        }

        private static int FindMinElement(int[] array)
        {
            int tempMin = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < tempMin)
                {
                    tempMin = array[i];
                }
            }

            return tempMin;
        }
    }
}
