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
            Console.WriteLine("Dynamic Fib " + input5 + " Fibonacci: " + j);

            Console.ReadKey();
        }
    }
}
