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
            int kn = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();

            int[] chars = new int[26];

            for (int i = 0; i < line.Length;i++)
            {
                int pos = char.ToUpper(line[i]) - 64;
                chars[pos - 1]++;
            }

            if (chars.Any(x => x % kn != 0))
            {
                Console.WriteLine(-1);
                return;
            }

            var sb = new StringBuilder();
            for (int k = 0; k < kn; k++)
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < chars[i]/kn; j++)
                    {
                        char c = (char)('A' + (char)i);
                        sb.Append(char.ToLower(c));
                    }
                }
            }

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
