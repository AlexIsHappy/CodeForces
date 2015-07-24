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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = init[0];
            var k = init[1];
            
            var ans = new int[n];

            for (int i = 0; i < n; i++)
            {
                ans[i] = i + 1;
            }

            int temp = ans[k - 1];
            ans[k - 1] = ans[k];
            ans[k] = temp;

            foreach (int i in ans)
            {
                Console.Write(i + " ");
            }


            Console.ReadLine();
        }
    }
}
