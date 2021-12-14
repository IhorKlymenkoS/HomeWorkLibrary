using HomeWorkLibrary;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class VariablesHelperTests //((5 * a) + (b * b)) / (b - a);
    {
        [TestCase(1, 2, 9)]
        [TestCase(2, 1, -11)]
        [TestCase(-1, 2, 0)]//0,3 3 argm
        [TestCase(1, -2, -3)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, -5)]
        [TestCase(127, 371, 566)] // 566,6 = 566,0
        public void SolveEquation_WhenANotEqualToB_ShouldCalculateEquation
            (int a, int b, int expectedResult)
        {
            int actualResult = VariablesHelper.SolveEquation(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SolveEquation_WhenAEqualToB_ShouldThrowArgumentExeption()
        {
            try
            {
                VariablesHelper.SolveEquation(1, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be not equal to b!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(10, 10, 1, 0)]
        [TestCase(10, 9, 1, 1)]
        [TestCase(10, 1, 10, 0)]
        [TestCase(1, 10, 0, 1)]//??
        [TestCase(0, 10, 0, 0)]
        [TestCase(10, -10, -1, 0)]
        [TestCase(10, -9, -1, 1)]
        [TestCase(-10, 10, -1, 0)]
        [TestCase(-10, 9, -1, -1)]
        [TestCase(-10, -10, 1, 0)]
        [TestCase(-10, -9, 1, -1)]
        public void ADividedByB_WhenBNotEqualToZero_ShouldCalculateEquation
            (int a, int b, int expectedDivided, int expectedremainder)
        {
            (int actualDivided, int actualremainder)
                = VariablesHelper.ADividedByB(a, b);
            Assert.AreEqual(expectedDivided, actualDivided);
            Assert.AreEqual(expectedremainder, actualremainder);
        }

        [Test]
        public void ADividedByB_WhenBEqualToZero_ShouldThrowArgumentExeption()
        {
            try
            {
                VariablesHelper.ADividedByB(10, 0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("B should be not equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 2, 3, 1)] //(c - b) / a;
        [TestCase(3, 2, 1, 0)]//??
        [TestCase(3, 3, 3, 0)]
        [TestCase(3, 0, 0, 0)]
        [TestCase(-1, -2, -3, 1)]
        [TestCase(1, -2, -3, -1)]
        public void SolveLinearEquation_WhenANotEqualToZero_ShouldCalculateEquation
            (int a, int b, int c, int expectedResult)
        {
            int actualResult = VariablesHelper.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SolveLinearEquation_WhenAEqualToZero_ShouldThrowArgumentExeption()
        {
            try
            {
                VariablesHelper.SolveLinearEquation(0, 1, 2);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be not equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(3, 3, 2, 2, 1)] // (y1 - y2) / (x1 - x2)
        [TestCase(-3, -3, 2, 2, 1)]
        [TestCase(3, 3, -2, -2, 1)]
        [TestCase(-3, -3, -2, -2, 1)]
        [TestCase(0, 0, 2, 2, 1)]
        [TestCase(3, 3, 2, 3, 0)]
        public void FindEquationOfAStraightLine_WhenX1NotEqualToX2_ShouldCalculateEquation
           (int x1, int y1, int x2, int y2, int expectedResult)
        {
            int actualResult = VariablesHelper.FindEquationOfAStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindEquationOfAStraightLine_WhenX1EqualToX2_ShouldThrowArgumentExeption()
        {
            try
            {
                VariablesHelper.FindEquationOfAStraightLine(2, 1, 2, 1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("X1 should be not equal to X2!", ex.Message);
                Assert.Pass();
            }
        }

    }
}