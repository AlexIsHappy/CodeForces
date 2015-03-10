using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            ulong res = 0;
            int[] temp = new int[2];
            temp[0] = int.Parse(s[0]);
            temp[1] = int.Parse(s[1]);

            int min = Math.Min(temp[0], temp[1]);
            int max = Math.Max(temp[0], temp[1]);

            int m = min;
            int temp0 = 0;
            int temp2 = int.Parse(s[2]);

            if (int.Parse(s[2]) == 1)
                res = (ulong)max * (ulong)min;
            else
            {
                while (m > 0)
                {
                    m -= temp2;
                    temp0++;
                }
                while (max > 0)
                {
                    max -= temp2;
                    res++;
                }
                res *= (ulong)temp0;
            }
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
