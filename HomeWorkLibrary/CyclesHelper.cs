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

       public static double TestT()
        {
            return 2.42341 * 8.513412;
        }

       public static void FindAllNumbersDivisibleByA(int a)
        {
            if (a==0)
            {
                throw new ArgumentException("A should be not equal to zero!");
            }
            if (a<0)
            {
                a *= -1;
            }

            int[] arrayDivisibleByA = new int[1000 / a]; 

            for (int i = a; i <= 1000; i += a)
            {
                for (int j = 0; j < arrayDivisibleByA.Length-1; j++)
                {
                    arrayDivisibleByA[j] = i;
                }
            }
        }

        public static int FindThenumberOfPositiveIntegers(int a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("A must be greater than zero");
            }
            int n;
            for (n = 1; n * n < a; ++n) ;

            return n-1;
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

        static int Task6(int a)
        {
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

        static int Task7(int a, int b)
        {
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

        static int Task9(int n)
        {
            int count = 0;

            while (n != 0)
            {
                if (n % 10 % 2 == 1)
                {
                    ++count;
                }

                n /= 10;
            }

            return count;
        }

        static int Task10(int n)
        {
            int reverse = 0;
            int remainder;

            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            return reverse;
        }

        static int Task11(int n)
        {
            int odd = 0;
            int even = 0;
            int nCopy = n;

            while (n != 0)
            {
                int currentDigit = n % 10;
                if (currentDigit % 2 == 1)
                {
                    odd += currentDigit;
                }
                else
                {
                    even += currentDigit;
                }

                n /= 10;
            }

            if (even > odd)
            {
                return nCopy;
            }

            return 0;
        }

        static bool Task12(int a, int b)
        {
            bool result = false;

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

        static double Task13(int a)
        {
            double sum = 0;
            double i = 1.0;

            for (i = 50; i >= 1; i--)
            {
                sum = (Math.Sqrt(i + sum));
            }

            return sum;
        }

        static int Task14(double a)
        {
            int n = 1;
            double sum = 0;
            do
            {
                sum += 1 / n;
                n++;
            } while (sum > a);

            return n;
        }
    }
}
