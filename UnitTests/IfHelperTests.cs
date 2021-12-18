using HomeWorkLibrary;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class IfHelperTests
    {
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, -1)]
        [TestCase(2, -1, 1)]
        [TestCase(-1, 2, -3)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 0)]
        public void CompareAAndB_When_ShouldCalculateEquation
            (int a, int b, int expectedResult)
        {
            int actualResult = IfHelper.CompareAAndB(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(4, 9, 1)]
        [TestCase(-2, 8, 2)]
        [TestCase(7, -5, 4)]
        [TestCase(-6, -3, 3)]
        public void GetQuarter_WhenXAndYNotEqualToZero_GetQuarter
            (int x, int y, int expectedResult)
        {
            int actualResult = IfHelper.GetQuarter(x, y);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 0)]
        public void GetQuarter_When_XOrYEqualToZero_ShouldThrowArgumentExeption
            (int x, int y)
        {
            try
            {
                IfHelper.GetQuarter(x, y);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Point on the coordinate axis", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [TestCase(new[] { 3, 3, 1 }, new[] { 1, 3, 3 })]
        [TestCase(new[] { 3, -2, 1 }, new[] { -2, 1, 3 })]
        [TestCase(new[] { 2, 1 }, new[] { 1, 2 })]
        [TestCase(new[] { 2 }, new[] { 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortArray_WhenArrayIsNotNull_ShouldSortArrayInAscendingOrder(
            int[] array,int[] expectedArray)
        {
            IfHelper.SortArray(array);
            Assert.AreEqual(expectedArray, array);
        }

        [Test]
        public void SortArray_WhenArrayIsNull_ShouldThrowArgumentException()
        {
            try
            {
                IfHelper.SortArray(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Array is null (Parameter 'array')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, -8, 12, 2, 6)]
        public void SolveQuadraticEquation_When_DiscriminantIsNotNegativeAndANotEqualToZero_ShouldSolveQuadraticEquation
            (double a, double b, double c, double expectedX1, double expectedX2)
        {
            (double, double) actualResult = IfHelper.SolveQuadraticEquation(a, b, c);
            Assert.IsTrue(actualResult.Item1 == expectedX1 || actualResult.Item2 == expectedX1);
            Assert.IsTrue(actualResult.Item1 == expectedX2 || actualResult.Item2 == expectedX2);
        }

        [Test]
        public void SolveQuadraticEquation_When_AEqualToZero_ShouldThrowArgumentException()
        {
            try
            {
                IfHelper.SolveQuadraticEquation(0, 2, 3);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be not equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void SolveQuadraticEquation_When_DiscriminantIsNegative_ShouldThrowArgumentException()
        {
            try
            {
                IfHelper.SolveQuadraticEquation(2, 1, 3);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("No roots", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(25, "twenty five")]
        [TestCase(30, "trirty ")]
        [TestCase(12, "twelve")]
        public void ConvertNumberToText_WhenNumberIsTwoDigit_ShouldConvertNumberToText(int number,string expectedResult)
        {
            string actualResult = IfHelper.ConvertNumberToText(number);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(9)]
        [TestCase(748)]
        public void ConvertNumberToText_WhenNumberIsNotTwoDigit_ShouldThrowArgumentException(int number)
        {
            try
            {
                IfHelper.ConvertNumberToText(number);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("The number must be two-digit!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}