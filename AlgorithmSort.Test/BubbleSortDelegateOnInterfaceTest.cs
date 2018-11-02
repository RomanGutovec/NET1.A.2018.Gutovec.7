using System;
using AlgorithmSort.Helpers;
using NUnit.Framework;

namespace Algorithm.Tests
{
    [TestFixture]
    public class BubbleSortDelegateOnIntefaceTest
    {
        [Test]
        public void SortJaggedMethodBySum()
        {
            int[][] actualArray =
            {
                new int[] { 15, 3, 9, -4 },
                null,
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
            };
            int[][] expectedArray =
            {
                null,
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
                new int[] { 15, 3, 9, -4 },
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortArraysBySumHelper().Compare);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodBySumDescendingOrder()
        {
            int[][] actualArray =
            {
                null,
                new int[] { 15, 3, 9, -4 },
                new int[] { 1, 1, 2 },
                new int[] { 18, -1, -2 },
            };
            int[][] expectedArray =
            {
                new int[] { 15, 3, 9, -4 },
                new int[] { 18, -1, -2 },
                new int[] { 1, 1, 2 },
                null
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortArraysBySumDescendingHelper().Compare);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMin()
        {
            int[][] actualArray =
            {
                new int[] { 3, 4 },
                new int[] { 12, 11 },
                null,
                null,
                new int[] { 1, 0, 1 }
            };
            int[][] expectedArray =
            {
                null,
                null,
                new int[] { 1, 0, 1 },
                new int[] { 3, 4 },
                new int[] { 12, 11 }
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortByMinElementHelper().Compare);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMinDescendingOrder()
        {
            int[][] actualArray =
            {
                new int[] { 3, 4 },
                null,
                new int[] { 12, 11 },
                null,
                new int[] { 1, 0, 1 }
            };
            int[][] expectedArray =
            {
                new int[] { 12, 11 },
                new int[] { 3, 4 },
                new int[] { 1, 0, 1 },
                null,
                null
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortByMinElementDescendingHelper().Compare);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMax()
        {
            int[][] actualArray =
            {
                new int[] { 5, 3, 1, 100 },
                null,
                new int[] { 10, 9, 8 },
                null,
                new int[] { 2, 4 }
            };
            int[][] expectedArray =
            {
                null,
                null,
                new int[] { 2, 4 },
                new int[] { 10, 9, 8 },
                new int[] { 5, 3, 1, 100 }
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortByMaxElementHelper().Compare);
            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethodByMaxDescendOrder()
        {
            int[][] actualArray =
            {
                new int[] { 1, 3, 5 },
                null,
                new int[] { 11, 28, 15 },
                null,
                new int[] { 10, 10, 10 }
            };
            int[][] expectedArray =
            {
                new int[] { 11, 28, 15 },
                new int[] { 10, 10, 10 },
                new int[] { 1, 3, 5 },
                null,
                null
            };
            AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(actualArray, new SortByMaxElementHelperDescendingHelper().Compare);

            CollectionAssert.AreEqual(expectedArray, actualArray);
        }

        [Test]
        public void SortJaggedMethod_NullReference_ArgumentNullException()
        => Assert.Throws<ArgumentNullException>(() => AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(null, new SortByMaxElementHelperDescendingHelper().Compare));

        [Test]
        public void SortJaggedMethod_ArrayWithZeroLength_ArgumentException()
        => Assert.Throws<ArgumentException>(() => AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(new int[0][], new SortByMinElementHelper().Compare));

        [Test]
        public void SortJaggedMethod_ArrayWithNullComparer_ArgumentNullException()
        => Assert.Throws<ArgumentNullException>(() => AlgorithmSort.BubbleSortDelegateOnInterface.SortJaggedArray(
            new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 3, 4, 5 }
            },
            null));
    }
}
