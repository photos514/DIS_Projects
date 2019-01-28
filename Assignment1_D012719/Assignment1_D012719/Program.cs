﻿using System;
using System.Linq;

namespace Assignment1_D012719
{
    class Program
    {
        public static void Main()
        {
            int a = 1, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);


            long n2 = 15;
            long r2 = decimalToBinary(n2);
            Console.WriteLine("Binary conversion of the decimal number " + n2 + " is: " + r2);


            long n3 = 1111;
            long r3 = binaryToDecimal(n3);
            Console.WriteLine("Decimal conversion of the binary number " + n3 + " is: " + r3);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Raghav Dasari");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadLine();

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {

                int num, i, ctr;
                Console.Write("The prime numbers between {0} and {1} are : \n", x, y);

                for (num = x; num <= y; num++)
                {
                    ctr = 0;
                    if (num > 0)
                    {
                        for (i = 2; i <= num / 2; i++)
                        {
                            if (num % i == 0)
                            {
                                ctr++;
                                break;
                            }
                        }
                        if (ctr == 0 && num != 1)
                            Console.Write("{0} ", num);
                    }

                }
                Console.Write("\n");

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }

        }

        public static double getSeriesResult(int n)
        {
            try
            {
                double term = 1;
                double res = 0;
                for (int i = 1; i <= n; i++)
                {
                    res += (factorial(i)) * term / (i + 1);
                    term = term * (-1);
                }

                return Math.Round(res, 3);

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static long decimalToBinary(long n)
        {
            try
            {

                long remainder;

                string result = string.Empty;
                while (n > 0)
                {
                    remainder = n % 2;
                    n /= 2;
                    result = remainder.ToString() + result;

                }
                return Convert.ToInt64(result);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
            }

            return 0;
        }

        public static int binaryToDecimal(long n)
        {
            try
            {
                int num = (int)n;
                int dec_value = 0;

                // Initializing base1 
                // value to 1, i.e 2^0 
                int base1 = 1;

                int temp = num;
                while (temp > 0)
                {
                    int last_digit = temp % 10;
                    temp = temp / 10;

                    dec_value += last_digit * base1;

                    base1 = base1 * 2;
                }

                return dec_value;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                int a, x;
                Console.WriteLine("Print paramid");
                for (int i = 1; i <= n; i++)
                {
                    for (a = 1; a <= (n - i); a++)
                        Console.Write(" ");
                    for (x = 1; x <= i; x++)
                        Console.Write('*');
                    for (x = (i - 1); x >= 1; x--)
                        Console.Write('*');
                    Console.WriteLine();

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {

                var output = a
                    .GroupBy(num => num)
                    .OrderBy(group => group.Key)
                    .Select(group => new { value = group.Key, count = group.Count() });
                Console.WriteLine(String.Format("{0,5} {1,8}", "Number", "Frequency"));
                foreach (var item in output)
                {
                    Console.WriteLine(String.Format("|{0,5}|{1,8}|", item.value.ToString(), item.count.ToString()));

                }



            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
        public static int factorial(int n)
        {
            int result = n;

            for (int i = 1; i < n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
