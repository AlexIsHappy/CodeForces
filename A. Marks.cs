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
            var start = Console.ReadLine();

            var ans = 0;

            if (int.Parse(start) > 0)
            {
                var l = (start[start.Length - 1] - '0');
  
                if (8 - l > 0)
                {
                    ans = 8 - l;
                    Console.WriteLine(ans);
                    return;
                }
                else
                {
                    var lt = int.Parse(start.Substring(start.Length - 2,2)); 
                    ans = Math.Min(80 - lt, 18 - l);
                    Console.WriteLine(ans == 80 - lt ? 80 - lt : 18 - l);
                    return;
                }
            }
            else
            {
                var l = (start[start.Length - 1] - '0');
                if (8 - l > 0)
                {
                    var lt = int.Parse(start.Substring(start.Length - 2, 2));
                    ans = Math.Min(90 - lt, l + 8);
                    Console.WriteLine(ans == 90 - lt ? 90 - lt : l+8);
                    return;
                }
                else
                {
                    ans = l - 8;
                    Console.WriteLine(ans);
                    return;
                }
            }

                Console.ReadLine();
        }
    }
}
