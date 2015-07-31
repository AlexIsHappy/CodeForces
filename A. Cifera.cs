using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var init = int.Parse(Console.ReadLine());

            var nums = new List<int>();

            var i = 1;

            while (nums.Count < init)
            {
                if (isPrime(i))
                {
                    nums.Add(i);
                }
                i++;
            }

            foreach(int k in nums)
            {
                Console.Write(k + " ");
            }
                Console.ReadLine();
        }

        public static bool isPrime(int n)
        {
            var boundary = Math.Floor(Math.Sqrt(n));

            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
