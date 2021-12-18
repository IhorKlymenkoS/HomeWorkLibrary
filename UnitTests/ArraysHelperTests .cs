using HomeWorkLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class ArraysHelperTests
    {
        [TestCase(new[] { 3, 2, 1 }, 5)]
        [TestCase(new[] { 3, -3, 1 }, -3)]
        [TestCase(new[] { 3, 0, 5 }, 0)]
        [TestCase(new[] { 2, 1 }, 1)]
        [TestCase(new[] { 2 }, 2)]
        public void GetMin_WhenArrayIsNotNull_ShouldGetMin(
     int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetMin(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMin_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetMin(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 3, 2, 1 }, 3)]
        [TestCase(new[] { -2, -3, -1 }, -1)]
        [TestCase(new[] { -3, 0, -5 }, 0)]
        [TestCase(new[] { 2, 1 }, 2)]
        [TestCase(new[] { 2 }, 2)]
        public void GetMax_WhenArrayIsNotNull_ShouldGetMax(
     int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetMax(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMax_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetMax(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 3, 2, 1 }, 2)]
        [TestCase(new[] { -2, -3, -1 }, 1)]
        [TestCase(new[] { 3, 0, 5 }, 1)]
        [TestCase(new[] { 2, 1, 1 }, 1)]
        [TestCase(new[] { 1, 2 }, 0)]
        [TestCase(new[] { 2 }, 0)]

        public void GetMinI_WhenArrayIsNotNull_ShouldGetMinI(
int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetMinI(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMinI_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetMinI(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 3, 2, 1 }, 0)]
        [TestCase(new[] { -2, -3, -1 }, 2)]
        [TestCase(new[] { 3, 0, 5 }, 2)]
        [TestCase(new[] { 2, 2, 1 }, 0)]
        [TestCase(new[] { 1, 2 }, 1)]
        [TestCase(new[] { 2 }, 0)]

        public void GetMaxI_WhenArrayIsNotNull_ShouldGetMaxI(
int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetMaxI(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetMaxI_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetMaxI(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 6)]
        [TestCase(new[] { -2, -3, -1, -5 }, -8)]
        [TestCase(new[] { 3, 0, 0, 4 }, 4)]
        [TestCase(new[] { -2, 2, 1 }, 2)]
        [TestCase(new[] { 1, 2 }, 2)]
        [TestCase(new[] { 2 }, 0)]

        public void GetOddISum_WhenArrayIsNotNull_ShouldGetOddISum(
int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetOddISum(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetOddISum_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetOddISum(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 3, 3, 1 }, new[] { 1, 3, 3 })]
        [TestCase(new[] { 3, -2, 1 }, new[] { 1, -2, 3 })]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 2 }, new[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseArray_WhenArrayIsNotNull_ShouldReverseArray(
    int[] array, int[] expectedArray)
        {
            ArraysHelper.ReverseArray(array);
            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void ReverseArray_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.ReverseArray(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new[] { -2, -3, -1, -5 }, 3)]
        [TestCase(new[] { 3, 0, 0, 4 }, 1)]
        [TestCase(new[] { -2, 2, 4 }, 0)]
        [TestCase(new[] { 1, 2 }, 1)]
        [TestCase(new[] { 2 }, 0)]

        public void GetAmountOddNumbers_WhenArrayIsNotNull_ShouldGetAmountOddNumbers(
int[] array, int expectedResult)
        {
            int actualResult = ArraysHelper.GetAmountOddNumbers(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetAmountOddNumbers_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.GetAmountOddNumbers(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 5, 4, 8 }, new[] { 8, 4, 5 })]
        [TestCase(new[] { -3, 3, 5 }, new[] { 5, 3, -3 })]
        [TestCase(new[] { 3, -2, 1 }, new[] { 1, -2, 3 })]
        [TestCase(new[] { 3, 6, 1, 8 }, new[] { 1, 8, 3, 6})]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 2 }, new[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SwapHalfArray_WhenArrayIsNotNull_ShouldSwapHalfArray(
int[] array, int[] expectedArray)
        {
            ArraysHelper.SwapHalfArray(array);
            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void SwapHalfArray_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.SwapHalfArray(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 5, 4, 8 }, new[] { 4, 5, 8 })]
        [TestCase(new[] { 3, -3, 5 }, new[] { -3, 3, 5 })]
        [TestCase(new[] { -5, -8, -1 }, new[] { -8, -5, -1 })]
        [TestCase(new[] { 3, 6, 1, 8 }, new[] { 1, 3, 6, 8 })]
        [TestCase(new[] { -3, -6, -1, -8 }, new[] { -8, -6, -3, -1 })]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 2 }, new[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortingBubble_WhenArrayIsNotNull_ShouldSortingBubble(
int[] array, int[] expectedArray)
        {
            ArraysHelper.SortingBubble(array);
            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void SortingBubble_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.SortingBubble(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 6, 6, 8 }, new[] { 6, 6, 8 })]
        [TestCase(new[] { 3, -3, 5 }, new[] { -3, 3, 5 })]
        [TestCase(new[] { -5, -8, -1 }, new[] { -8, -5, -1 })]
        [TestCase(new[] { 1, 6, 0, 8 }, new[] { 0, 1, 6, 8 })]
        [TestCase(new[] { -3, -6, -1, -8 }, new[] { -8, -6, -3, -1 })]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 2 }, new[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortingInsertion_WhenArrayIsNotNull_ShouldSortingInsertion(
int[] array, int[] expectedArray)
        {
            ArraysHelper.SortingInsertion(array);
            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void SortingInsertion_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                ArraysHelper.SortingInsertion(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
