using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public class ArraysHelper
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int GetMin(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }

            int minI = GetMinI(array);
            return array[minI];
        }

        public static int GetMax(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int maxI = GetMaxI(array);
            return array[maxI];
        }

        public static int GetMinI(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int min = GetMin(array);
            int minI=0;

            for (int i = 0; i < array.Length; i++)
            {
                if (min == array[i])
                {
                    minI=i;
                    break;
                }
            }

            return minI;
        }

        public static int GetMaxI(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int max = GetMax(array);
            int maxI = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (max == array[i])
                {
                    maxI=i;
                    break;
                }
            }

            return maxI;
        }

        public static int GetOddISum(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int oddSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += array[i];
                }
            }

            return oddSum;
        }

        public static void ReverseArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }

        public static int GetAmountOddNumbers(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int oddsum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddsum++;
                }
            }

            return oddsum;
        }

        public static void SwapHalfArray(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            int halfSize = array.Length / 2;
            int shift = array.Length % 2;
            for (int i = 0; i < halfSize; i++)
            {
                Swap(ref array[i], ref array[halfSize + i+ shift]);
            }
        }

        public static void SortingBubble(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        public static void SortingInsertion(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array is null");
            }
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                int index = i;
                while ((index > 0) && (array[index - 1] > number))
                {
                    Swap(ref array[index - 1], ref array[index]);
                    index--;
                }

                array[index] = number;
            }

        }

    }
}
