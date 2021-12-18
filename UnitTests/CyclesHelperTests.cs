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

        [TestCase(250, new[] { 250, 500, 750, 1000 })]
        [TestCase(-250, new[] { 250, 500, 750, 1000 })]
        public void FindAllNumbersDivisibleByA_WhenANotEqualToZero_FindAllNumbers
            (int a, int[] expectedArray)
        {
            int[] arrayDivisibleByA = CyclesHelper.FindAllNumbersDivisibleByA(a);
            CollectionAssert.AreEqual(expectedArray, arrayDivisibleByA);
        }

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
        public void FindTheNumberOfPositiveIntegers_WhenAGreaterThanZero_ShouldFindThenumber
            (int a, int expectedResult)
        {
            int actualResult = CyclesHelper.FindTheNumberOfPositiveIntegers(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-2)]
        public void FindThenumberOfPositiveIntegers_WhenALessThanZero_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.FindTheNumberOfPositiveIntegers(a);
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
        public void GetSumOfAllNumbersInTheRangeFromAToB_WhenAAndBPassed_ShouldGetSum
            (int a, int b, int expectedResult)
        {
            int actualResult = CyclesHelper.GetSumOfAllNumbersInTheRangeFromAToB(a, b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(10, 55)]
        public void BringOutTheNumberOfFibanachi_WhenAGreaterThanZero_ShouldFindGreatestDivisor(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.BringOutTheNumberOfFibanachi(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void BringOutTheNumberOfFibanachi_WhenALessThanZero_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.BringOutTheNumberOfFibanachi(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A must be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
   
        [TestCase(1, 1, 1)]
        [TestCase(25, 10, 5)]
        [TestCase(144, 17, 1)]
        [TestCase(0, 2, 2)]
        [TestCase(2, 0, 2)]

        public void FindTheGreatestCommonFactor_WhenAAndBGreaterThanZero_ShouldFindTheGreatestCommonFactor(int a, int b, int expectedResult)
        {
            int actualResult = CyclesHelper.FindTheGreatestCommonFactor(a,b);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, -1)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]

        public void FindTheGreatestCommonFactor_WhenAOrBLessThanZero_ShouldThrowArgumentException(int a, int b)
        {
            try
            {
                CyclesHelper.FindTheGreatestCommonFactor(a,b);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A and B must be greater than zero", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(0, 0)]
        [TestCase(1425698, 3)]
        [TestCase(-52362172, 4)]

        public void FindTheNumberOfOddDigits_WhenAEntered_ShouldFindTheNumberOfOddDigits(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.FindTheNumberOfOddDigits(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(123456789, 987654321)]
        [TestCase(0123456789, 987654321)]
        [TestCase(12056, 65021)]
        [TestCase(-12, -21)]

        public void FindTheMirroredNumber_WhenAEntered_ShouldFindTheMirroredNumber(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.FindTheMirroredNumber(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(6, 6)]
        [TestCase(7, 0)]


        public void GetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd_WhenAMoreThanOne_ShouldGetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd(int a, int expectedResult)
        {
            int actualResult = CyclesHelper.GetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd(a);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-1)]
        public void GetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd_WhenALessThanOne_ShouldThrowArgumentException(int a)
        {
            try
            {
                CyclesHelper.GetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd(a);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("A must be greater than one", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(123, 456, false)]
        [TestCase(123, -456, false)]
        [TestCase(-123, 456, false)]
        [TestCase(123, 312, true)]
        [TestCase(5312, 1, true)]
        [TestCase(53102, 0, true)]//??
        [TestCase(-123, 111, true)]
        [TestCase(123, -111, true)]

        public void FindIfThereAreIdenticalDigitsInNumbers_WhenAAndBEntered_ShouldFindIfThereAreIdenticalDigitsInNumbers(int a, int b, bool expectedResult)
        {
            bool actualResult = CyclesHelper.FindIfThereAreIdenticalDigitsInNumbers(a,b);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}