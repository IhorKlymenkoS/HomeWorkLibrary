using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public class VariablesHelper
    {
        public static int SolveEquation(int a, int b)
        {
            if (a==b)
            {
                throw new ArgumentException("A should be not equal to b!");
            }

            return ((5 * a) + (b * b)) / (b - a);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (int, int) ADividedByB(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("B should be not equal to zero!");
            }

            int aDividedByB = a / b;
            int remainder = a % b;
            return (aDividedByB, remainder);
        }

        public static int SolveLinearEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new ArgumentException("A should be not equal to zero!");
            }

            return (c - b) / a;
        }

        public static int FindEquationOfAStraightLine
            (int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new ArgumentException("X1 should be not equal to X2!");
            }

            return (y1 - y2) / (x1 - x2);
        }
    }
}
