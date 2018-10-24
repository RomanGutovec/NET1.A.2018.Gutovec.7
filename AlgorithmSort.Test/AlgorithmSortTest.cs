using System;
using NUnit.Framework;

namespace Algorithm.Tests
{
    [TestFixture]
    public class AlgorithmSortTest
    {
        [Test]
        public void SortJaggedMethod()
        {
            int[][] actualArray =
                {
                new int[] { 9, 1, 2 },
                new int[] { 15, -1, 2 },
                new int[] { 11, 1, 2, -4 },
                };
            int[][] expectedArray =
            {
                new int[] { 1, 2, 9 },
                new int[] { -1, 2, 15 },
                new int[] { -4, 1, 2, 11 },
            };
            AlgorithmSort.Sort.SortJagged(actualArray);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodDescendingOrder()
        {
            int[][] actualArray =
            {
                new int[] { 9, 1, 2 },
                new int[] { 15, -1, 2 },
                new int[] { 11, 1, 2, -4 }
            };
            int[][] expectedArray =
            {
                new int[] { 9, 2, 1 },
                new int[] { 15, 2, -1 },
                new int[] { 11, 2, 1, -4 }
            };
            AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.OrderBy.Descending);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodBySum()
        {
            int[][] actualArray =
            {
                new int[] { 15, 3, 9, -4 },
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
            };
            int[][] expectedArray =
            {
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
                new int[] { 15, 3, 9, -4 },
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.Sum);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodBySumDescendingOrder()
        {
            int[][] actualArray =
            {
                new int[] { 15, 3, 9, -4 },
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
            };
            int[][] expectedArray =
            {
                new int[] { 15, 3, 9, -4 },
                new int[] { 18, -1, -2 },
                new int[] { 1, 1, 2 }
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.Sum, AlgorithmSort.Sort.OrderBy.Descending);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMin()
        {
            int[][] actualArray =
            {
                new int[] { 3, 4 },
                new int[] { 12, 11 },
                new int[] { 1, 0, 1 }
            };
            int[][] expectedArray =
            {
                 new int[] { 1, 0, 1 },
                 new int[] { 3, 4 },
                 new int[] { 12, 11 }
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.MinElementInRow);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMinDescendingOrder()
        {
            int[][] actualArray =
            {
                new int[] { 3, 4 },
                new int[] { 12, 11 },
                new int[] { 1, 0, 1 }
            };
            int[][] expectedArray =
            {
                new int[] { 12, 11 },
                new int[] { 3, 4 },
                new int[] { 1, 0, 1 },
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.MinElementInRow, AlgorithmSort.Sort.OrderBy.Descending);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMax()
        {
            int[][] actualArray =
            {
                new int[] { 10, 9, 8 },
                new int[] { 5, 3, 1 },
                new int[] { 2, 4 }
            };
            int[][] expectedArray =
            {
                new int[] { 5, 3, 1 },
                new int[] { 2, 4 },
                new int[] { 10, 9, 8 },
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.MinElementInRow);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMaxDescendOrder()
        {
            int[][] actualArray =
            {
                new int[] { 1, 3, 5 },
                new int[] { 11, 28, 15 },
                new int[] { 10, 10, 10 }
            };
            int[][] expectedArray =
            {
                new int[] { 11, 28, 15 },
                new int[] { 10, 10, 10 },
                new int[] { 1, 3, 5 },
            };
            actualArray = AlgorithmSort.Sort.SortJagged(actualArray, AlgorithmSort.Sort.SortBy.MinElementInRow, AlgorithmSort.Sort.OrderBy.Descending);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethod_NullReference_ArgumentNullException()
        => Assert.Throws<ArgumentNullException>(() => AlgorithmSort.Sort.SortJagged(null));

        [Test]
        public void SortJaggedMethod_ArrayWithZeroLength_ArgumentException()
        => Assert.Throws<ArgumentException>(() => AlgorithmSort.Sort.SortJagged(new int[0][]));
    }
}
