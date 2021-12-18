using System;

namespace HomeWorkLibrary
{
    public class CyclesHelper
    {
       public static int AToPowerB(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else if (b < 0)
            {
                throw new ArgumentException("B must be greater than zero");
            }

            int result = a;

            for (int i = 1; i <= b - 1; i++)
            {
                result *= a;
            }

            return result;
        }

       public static int[] FindAllNumbersDivisibleByA(int a)
        {
            if (a == 0)
            {
                throw new ArgumentException("A should be not equal to zero!");
            }
            if (a < 0)
            {
                a *= -1;
            }

            int[] arrayDivisibleByA = new int[1000 / a];

            for (int i = a, j = 0; i <= 1000; i += a)
            {
                arrayDivisibleByA[j++] = i;
            }

            return arrayDivisibleByA;
        }

        public static int FindTheNumberOfPositiveIntegers(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("A must be greater than zero");
            }
            int n;
            for (n = 1; n * n < a; ++n) { }

            return n - 1;
        }

        public static int FindTheGreatestDivisor(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("A must be greater than zero");
            }
            if (a == 1)
            {
                throw new ArgumentException("There is no other greatest divisor");
            }
            int i = a - 1;
            for (; i >= 1; i--)
            {
                if (a % i == 0)
                {
                    break;
                }
            }

            return i;
        }

        public static int GetSumOfAllNumbersInTheRangeFromAToB(int a, int b)
        {
            int sum = 0;

            if (b < a)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int BringOutTheNumberOfFibanachi(int a)
        {
            if (a==1||a==2)
            {
                return 1;
            }
            if (a < 1)
            {
                throw new ArgumentException("A must be greater than zero");
            }

            int fibonacci1 = 1;
            int fibonacci2 = 1;
            int fibonacci3 = 0;

            for (int i = 0; i <= a - 3; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }

            return fibonacci3;
        }

        public static int FindTheGreatestCommonFactor(int a, int b)
        {
            if (a < 0 || b<0)
            {
                throw new ArgumentException("A and B must be greater than zero");
            }
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("A and B must be greater than zero");
            }

            if (b<a)
            {
                Swap(ref a, ref b);
            }

            int remainder;
            do
            {
                remainder = a % b;
                a = b;
                if (remainder != 0)
                {
                    b = remainder;
                }

            } while (remainder != 0);

            return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int FindTheNumberOfOddDigits(int a)
        {
            int count = 0;
            if (a<1)
            {
                a *= -1;
            }

            while (a != 0)
            {
                if (a % 2 == 1)
                {
                    ++count;
                }

                a /= 10;
            }

            return count;
        }

        public static int FindTheMirroredNumber(int a)
        {
            int reverse = 0;
            int remainder;

            while (a != 0)
            {
                remainder = a % 10;
                reverse = reverse * 10 + remainder;
                a /= 10;
            }

            return reverse;
        }

        public static int GetNumbersTheSumOfEvenDigitsOfWhichIsMoreThanOdd(int a)
        {
            if (a <= 1)
            {
                throw new ArgumentException("A must be greater than one");
            }

            int odd = 0;
            int even = 0;
            int aCopy = a;

            while (a != 0)
            {
                int currentDigit = a % 10;
                if (currentDigit % 2 == 1)
                {
                    odd += currentDigit;
                }
                else
                {
                    even += currentDigit;
                }

                a /= 10;
            }

            if (even > odd)
            {
                return aCopy;
            }

            return 0;
        }

        public static bool FindIfThereAreIdenticalDigitsInNumbers(int a, int b)
        {
            bool result = false;

            if (a<0)
            {
                a *= -1;
            }
            if (b < 0)
            {
                b *= -1;
            }

            while (a != 0 && !result)
            {
                int currentDigitA = a % 10;
                int bCopy = b;

                while (bCopy != 0)
                {
                    int currentDigitB = bCopy % 10;

                    if (currentDigitA == currentDigitB)
                    {
                        result = true;
                        break;
                    }

                    bCopy /= 10;
                }

                a /= 10;
            }

            return result;
        }
    }
}
