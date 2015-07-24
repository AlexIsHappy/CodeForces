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
            var num = int.Parse(Console.ReadLine());
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int max = int.MaxValue;
            for (int i = 1; i < init.Count - 1; i++)
            {
                var init1 = init.ToList();
                init1.RemoveAt(i);
                var localMax = 0;
                for (int j = 1 ; j < init1.Count; j++)
                {
                    localMax = Math.Max(localMax, init1[j] - init1[j - 1]);
                }

                max = Math.Min(max, localMax);
            }
         

            Console.WriteLine(max);
            Console.ReadLine();
        }
      
    }
}
