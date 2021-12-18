using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public class IfHelper
    {
        public static int CompareAAndB(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }

            return result;
        }

        public static int GetQuarter(int x, int y)
        {
            if (x == 0 || y==0)
            {
                throw new ArgumentException("Point on the coordinate axis");
            }

            int quarter;
            if (x > 0)
            {
                if (y > 0)
                {
                    quarter = 1;
                }
                else
                {
                    quarter = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    quarter = 2;
                }
                else
                {
                    quarter = 3;
                }
            }

            return quarter;
        }

        public static void SortArray(int[] array)
        {
            if(array==null)
            {
                throw new ArgumentNullException(nameof(array),"Array is null");
            }

            for (int i = 0; i < array.Length; i++)
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

        public static (double x1, double x2) SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            (double x1, double x2) result;

            if (a == 0)
            {
                throw new ArgumentException("A should be not equal to zero!");
            }
            if (discriminant > 0)
            {
               double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
               double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
               result = (x1, x2);
            }
            else if (discriminant == 0)
            {
                double x1 = -b / 2 * a;
                result = (x1, x1);
            }
            else
            {
                throw new ArgumentException("No roots");
            }

            return result;
        }

        public static string ConvertNumberToText(int number)
        {
            if (number>99 || number <10)
            {
                throw new ArgumentException("The number must be two-digit!");
            }
            string result;
            int dozens = number / 10;
            int units = number % 10;

            if (dozens != 1)
            {
                result = GetDozens(dozens) + " " + GetUnits(units);
            }
            else
            {
                result = GetSecondDozens(units);
            }

            return result;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static string GetDozens(int number)
        {
            string result = "";
            switch (number)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "trirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }

        private static string GetUnits(int number)
        {
            string result = "";
            switch (number)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "tree";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        private static string GetSecondDozens(int number)
        {
            string result = number switch
            {
                1 => "eleven",
                2 => "twelve",
                3 => "thirteen",
                4 => "fourteen",
                5 => "fifteen",
                6 => "sixteen",
                7 => "seventeen",
                8 => "eighteen",
                9 => "nineteen",
                _ => "ten",
            };

            return result;
        }
    }
}
