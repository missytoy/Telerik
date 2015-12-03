using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static int[] memo;
        private const int Mod = 1000000007;
        static void Main(string[] args)
        {
            // For bgcoder - put the matriz class in this namespace

            //Console.WriteLine(PowModNumbers(2, 10));
            int n = int.Parse(Console.ReadLine());
            memo = new int[n + 1];

            //Console.WriteLine(RecursiveMemoizationFibonacci(n));

            Console.WriteLine(RecursiveMemoizationFibonacci(n));
        }

        static int RecursiveMemoizationFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            if (memo[n] != 0)
            {
                return memo[n];
            }

            int number = RecursiveMemoizationFibonacci(n - 1) + RecursiveMemoizationFibonacci(n - 2);
           // number %= Mod;

            memo[n] = number;

            return number;
        }
    }
}
