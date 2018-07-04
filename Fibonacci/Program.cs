using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {        
        static int DynamicFib(int n)
        {

            // Declare an array to 
            // store Fibonacci numbers.
            // 1 extra to handle 
            // case, n = 0
            int[] f = new int[n + 2];
            int i;

            /* 0th and 1st number of the 
               series are 0 and 1 */
            f[0] = 0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                /* Add the previous 2 numbers
                   in the series and store it */
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
        public static uint GetNthFibonacci2(int n)
        {
            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
        public static int GetNthFibonacci(int n)
        {
            // 1 based index
            var previous = -1;
            var current = 1;
            int index = 1;
            int element = 0;

            while (index++ <= n)
            {
                element = previous + current;
                previous = current;
                current = element;
            }

            return element;
        }
        public static int FindNthFibonacciNumber(int n)
        {
            // 0 based index
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            int nthfibonacciNumber = FindNthFibonacciNumber(n - 1) + FindNthFibonacciNumber(n - 2);
            return nthfibonacciNumber;
        }
        static bool isPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);
        }

        // Returns true if n is a Fibonacci Number, else false
        static bool isFibonacci(int n)
        {
            // n is Fibonacci if one of 5*n*n + 4 or 5*n*n - 4 or 
            // both are a perfect square
            return isPerfectSquare(5 * n * n + 4) ||
                   isPerfectSquare(5 * n * n - 4);
        }
        
        static void FindClosestFibNo()
        {
            /*
             Given a positive integer, return the closest number of the Fibonacci
             sequence, under these rules:

             The closest Fibonacci number is defined as the Fibonacci number with
             the smallest absolute difference with the given integer. For example,
             34 is the closest Fibonacci number to 30, because |34 - 30| = 4,
             which is smaller than the second closest one, 21, for which |21 - 30| = 9.

             If the given integer belongs to the Fibonacci sequence, the closest
             Fibonacci number is exactly itself. For example, the closest Fibonacci
             number to 13 is exactly 13.

             In case of a tie, you may choose to output either one of the Fibonacci
             numbers that are both closest to the input or just output them both.
             For instance, if the input is 17, all of the following are valid: 21,
             13 or 21, 13. In case you return them both, please mention the format.
             */

            Func<int, int> g = x => {
                                        int a = 0, b = 1;

                                        for (; b < x; a = b - a)
                                            b += a;

                                        return x - a > b - x ? b : a;
                                    };

            Console.WriteLine(g(1));
            Console.WriteLine(g(3));
            Console.WriteLine(g(4));
            Console.WriteLine(g(6));
            Console.WriteLine(g(17));
            Console.WriteLine(g(63));
            Console.WriteLine(g(377));
            Console.WriteLine(g(467));
            Console.WriteLine(g(1399));
        }
        static void Main(string[] args)
        {
            int input1 = 8;
            int n = FindNthFibonacciNumber(input1);

            int input2 = 9;
            int m = GetNthFibonacci(input2);

            int input3 = 7;
            uint l = GetNthFibonacci2(input3);

            int input4 = 8;
            int k = Fib(input4);

            int input5 = 8;
            int j = Fib(input5);

            Console.WriteLine("Find " + input1 + "th Fibonacci: " + n);
            Console.WriteLine("Get " + input2 + "th Fibonacci: " + m);
            Console.WriteLine("Get2 " + input3 + "th Fibonacci: " + l);
            Console.WriteLine("Fib " + input4 + " Fibonacci: " + k);
            Console.WriteLine("Dynamic Fib " + input5 + " Fibonacci: " + j + "\n");

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(isFibonacci(i) ? i + " is a Fibonacci Number" :
                                                   i + " is a not Fibonacci Number");
            Console.WriteLine();
            FindClosestFibNo();

            Console.ReadKey();
        }
    }
}
