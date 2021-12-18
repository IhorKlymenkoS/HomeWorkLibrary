using HomeWorkLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class MultiDimentionalArraysHelperTests
    {
        [TestCaseSource(nameof(MaxCases))]
        public void Max_WhenArrayIsFilled_ShouldGetMaxValue(int[,] array, int expectedResult)
        {
            int actualResult = MultiDimentionalArraysHelper.Max(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MaxCases =
        {
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 } }, 6 },
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 }, { 5, 10, 1 } }, 10 },
            new object[] { new[,] { { 1, 2}, { 8, 5 }, { 1, 5 } }, 8 },
            new object[] { new[,] { { 1, 2, -3}, { 0, -7, -6 } }, 2 },
            new object[] { new[,] { { -1, -2, -3}, { -4, -5, -6 }, { -5, -10, -1 } }, -1 },
        };

        [Test]
        public void Max_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.Max(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(MinCases))]
        public void Min_WhenArrayIsFilled_ShouldGetMinValue(int[,] array, int expectedResult)
        {
            int actualResult = MultiDimentionalArraysHelper.Min(array);
            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] MinCases =
        {
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 } }, 1 },
            new object[] { new[,] { { 7, 2, 3}, { 4, 5, 6 }, { 5, 10, 2 } }, 2 },
            new object[] { new[,] { { 1, 2}, { 8, 5 }, { 1, 5 } }, 1 },
            new object[] { new[,] { { 1, 2, -3}, { 0, -7, -6 } }, -7 },
            new object[] { new[,] { { -1, -2, -3}, { -4, -5, -6 }, { -5, -10, -1 } }, -10 },
        };

        [Test]
        public void Min_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.Min(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(MaxICases))]
        public void MaxI_WhenArrayIsFilled_ShouldGetMaxI(int[,] array, int expectedI1, int expectedI2)
        {
            (int,int) actualResult = MultiDimentionalArraysHelper.MaxI(array);

            Assert.AreEqual((expectedI1, expectedI2), actualResult);
        }

        static object[] MaxICases =
        {
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 } }, 1, 2 },
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 }, { 5, 10, 1 } }, 2, 1 },
            new object[] { new[,] { { 1, 2}, { 8, 5 }, { 1, 5 } }, 1, 0 },
            new object[] { new[,] { { -1, 2, -3}, { 0, -7, -6 } }, 0, 1 },
            new object[] { new[,] { { -1, -2, -3}, { -4, -5, -6 }, { -5, -10, -1 } }, 0, 0 },
        };

        [Test]
        public void MaxI_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.MaxI(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(MinICases))]
        public void MinI_WhenArrayIsFilled_ShouldGetMinI(int[,] array, int expectedI1, int expectedI2)
        {
            (int, int) actualResult = MultiDimentionalArraysHelper.MinI(array);

            Assert.AreEqual((expectedI1, expectedI2), actualResult);
        }

        static object[] MinICases =
        {
            new object[] { new[,] { { 1, 2, 3}, { 4, 5, 6 } }, 0, 0 },
            new object[] { new[,] { { 5, 2, 3}, { 4, 5, 6 }, { 5, 10, 1 } }, 2, 2 },
            new object[] { new[,] { { 1, 2}, { 8, 0 }, { 1, 5 } }, 1, 1 },
            new object[] { new[,] { { -1, 2, -3}, { 0, -7, -9 } }, 1, 2 },
            new object[] { new[,] { { -1, -2, -3}, { -4, -5, -6 }, { -5, -10, -1 } }, 2, 1 },
        };

        [Test]
        public void MinI_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.MinI(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(ReverseLine))]
        public void FlipAongLine_WhenArrayIsNotNull_ShouldFlipAongLine(int[,] array, int[,] expectedArray)
        {
            MultiDimentionalArraysHelper.FlipAongLine(array);

            Assert.AreEqual(expectedArray, array);
        }

        static object[] ReverseLine =
        {
            new object[] { new[,] { { 5, 2, 3}, { 4, 5, 6 }, { 5, 10, 1 } }, new[,] { { 5, 4, 5}, { 2, 5, 10 }, { 3, 6, 1 } } },
            new object[] { new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }, new[,] { { 1, 5, 9, 13 }, { 2, 6, 10, 14 }, { 3, 7, 11, 15 }, { 4, 8, 12, 16 } } },

        };

        [Test]
        public void FlipAongLine_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.FlipAongLine(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCaseSource(nameof(GetLargestCells))]
        public void GetLargestCells_WhenArrayIsFilled_ShouldGetLargestCells(int[,] array, int expectedResult)
        {
            int actualResult = MultiDimentionalArraysHelper.GetLargestCells(array);

            Assert.AreEqual(expectedResult, actualResult);
        }

        static object[] GetLargestCells =
        {
            new object[] { new[,] { { 1, 2, 1}, { 1, 1, 2 } }, 2 },
            new object[] { new[,] { { 4, 2, 8}, { -2, 3, -5 } }, 3 },
            new object[] { new[,] { { 1, 12, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }, 2 },

        };

        [Test]
        public void GetLargestCells_WhenArrayIsNull_ShouldThrowArgumentExeption()
        {
            try
            {
                MultiDimentionalArraysHelper.GetLargestCells(null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Matrix is null (Parameter 'matrix')", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}
