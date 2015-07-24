using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var l = init[0];
            var r = init[1];

            var candidates = new List<long>();

            for (long i = l; i <= r; i++)
            {
                for (long j = i + 1; j <= r; j++)
                {
                    if (coprime(i,j))
                    {
                        //Start searching for a second pair of comprimes
                        for (long k = j + 1; k <= r; k++)
                        {
                            if(coprime(j,k))
                            {
                                if (!coprime(i,k))
                                {
                                    candidates.Add(i);
                                    candidates.Add(j);
                                    candidates.Add(k);
                                }
                            }
                        }
                    }
                }
            }
            
            if (candidates.Count == 3)
            {
                string ans = candidates[0] + " " + candidates[1] + " " + candidates[2];
                Console.WriteLine(ans);
                return;
            }
            else{
                Console.WriteLine(-1);
                return;
            }

            Console.ReadLine();
        }

        public static long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }

        public static bool coprime(long a, long b)
        {
            return GCD(a, b) == 1;
        }
    }
}
