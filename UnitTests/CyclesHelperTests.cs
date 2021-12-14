using HomeWorkLibrary;
using NUnit.Framework;
using System;

namespace UnitTests
{
    public class CyclesHelperTests
    {
        [TestCase(2, 4, 16)]
        [TestCase(-2, 2, 4)]
        [TestCase(3, 2, 9)]
        [TestCase(-3, 3, -27)]
        [TestCase(2, 0, 1)]
        [TestCase(0, 4, 0)]
        public void AToPowerB_WhenABPassed_ShouldAPowerToB
            (int a, int b, int expectedResult)
        {
            int actualResult = CyclesHelper.AToPowerB(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestTest()
        {
            double actualResult = CyclesHelper.TestT();
            Assert.AreEqual(20.6, actualResult, 0.1);
        }

        [Test]
        public void AToPowerB_WhenBLessZero_ShouldThrowArgumentException()
        {
            try
            {
                CyclesHelper.AToPowerB(2, -1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("B must be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        //[TestCase(250, new[] { 250, 500, 750, 1000 })]
        //[TestCase(-250, new[] { 250, 500, 750, 1000 })]
        //public void FindAllNumbersDivisibleByA_WhenANotEqualToZero_FindAllNumbers(int a, int[] expectedArrey)
        //{
            //int[] arrayDivisibleByA;
            //CyclesHelper.FindAllNumbersDivisibleByA(a);
            //Assert.AreEqual(expectedArrey, arrayDivisibleByA);
        //}

        [Test]
        public void FindAllNumbersDivisibleByA_WhenANotEqualToZero_ShouldThrowArgumentException()
        {
            try
            {
                CyclesHelper.FindAllNumbersDivisibleByA(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A should be not equal to zero!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(5, 2)]
        [TestCase(125, 11)]
        public void FindThenumberOfPositiveIntegers_WhenAGreaterThanZero_ShouldFindThenumber(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.FindThenumberOfPositiveIntegers(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void FindThenumberOfPositiveIntegers_WhenALessThanZero_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.FindThenumberOfPositiveIntegers(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A must be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(100, 50)]
        [TestCase(25, 5)]
        public void FindTheGreatestDivisor_WhenAGreaterThanZero_ShouldFindGreatestDivisor(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.FindTheGreatestDivisor(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FindTheGreatestDivisor_WhenALessThanZero_ShouldThrowArgumentException()
        {
            try
            {
                CyclesHelper.FindTheGreatestDivisor(-2);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A must be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void FindTheGreatestDivisor_WhenAIsEqualToOne_ShouldThrowArgumentException()
        {
            try
            {
                CyclesHelper.FindTheGreatestDivisor(1);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("There is no other greatest divisor", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(0, 30, 70)]
        [TestCase(0, -30, -70)]
        public void GetSumOfAllNumbersInTheRangeFromAToB_When_ShouldGetSum(int a, int b, int expectedResult)
        {
            int actualResult = CyclesHelper.GetSumOfAllNumbersInTheRangeFromAToB(a,b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}