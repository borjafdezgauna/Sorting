using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorting;
using System;

namespace UnitTests
{
    [TestClass]
    public class SortingAlgorithms
    {
        public void TestSortingAlgorithm(ISortingAlgorithm algorithm)
        {
            int[] A = new int[] { 4, 3, 2, -1, 5, 25 };
            algorithm.Sort(A);
            Assert.IsTrue(Utils.IsOrdered(A));

            A = new int[] { 12, 6, 3, 2, 1, 0, -2 };
            algorithm.Sort(A);
            Assert.IsTrue(Utils.IsOrdered(A));

            A = new int[] { 0, 1, 2, 3, 4, 20 };
            algorithm.Sort(A);
            Assert.IsTrue(Utils.IsOrdered(A));

            A = new int[] { 1 };
            algorithm.Sort(A);
            Assert.IsTrue(Utils.IsOrdered(A));
        }

        [TestMethod]
        public void SelectionSort()
        {

            SelectionSort sortingAlgorithm = new SelectionSort();
            TestSortingAlgorithm(sortingAlgorithm);
        }

        [TestMethod]
        public void QuickSort()
        {

            QuickSort sortingAlgorithm = new QuickSort();
            TestSortingAlgorithm(sortingAlgorithm);
        }

        [TestMethod]
        public void MergeSort()
        {

            MergeSort sortingAlgorithm = new MergeSort();
            TestSortingAlgorithm(sortingAlgorithm);
        }
    }
}
