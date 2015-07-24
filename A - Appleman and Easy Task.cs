using System;
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

            long ans = 0;
            foreach (var x in Console.ReadLine().GroupBy(ch => ch).Select(g => g.Count()).OrderByDescending(x => x))
            {
                var y = Math.Min(x, k);
                ans += 1L * y * y;
                k -= y;

            }

            Console.WriteLine(ans);
            Console.ReadLine();

        }

        static string IntToBinaryString(int bits, bool removeTrailingZero)
        {
            var sb = new StringBuilder(8);
            for (int i = 0; i < 8; i++)
            {
                if ((bits & 0x00000001) != 0)
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
                bits = bits << 1;
            }
            string s = sb.ToString();
            if (removeTrailingZero)
            {
                return s.TrimStart('0');
            }
            else
            {
                return s;
            }
        }



    }
}
