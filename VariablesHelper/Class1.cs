using System;

namespace VariablesHelper
{
    public class Class1
    {
        static int SolveEquation(int a, int b)
        {
            return (5 * a + b * b) / b - a;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static (int, int) ADividedByB(int a, int b)
        {
            int aDivided = a / b;
            int remainder = a % b;
            return (aDivided, remainder);
        }

        static int SolveLinearEquation(int a, int b, int c)
        {
            return (c - b) / a;
        }

        static int FindEquationOfAStraightLine(int x1, int y1, int x2, int y2)
        {
            return (y1 - y2) / (x1 - x2);
        }
    }
}
