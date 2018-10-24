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
                new int[] {9,1,2,},
                new int[] {15,-1,2},
                new int[] {11,1,2,-4},
            };
            int[][] expectedArray =
            {
                new int[] {1,2,9,},
                new int[] {-1,2,15},
                new int[] {-4,1,2,11},
            };
            AlgorithmSort.Sort.SortJagged(actualArray);
            CollectionAssert.AreEqual(expectedArray, actualArray);

        }
    }
}
