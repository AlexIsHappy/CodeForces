using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var d = int.Parse(Console.ReadLine());
            var days = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = 0;

            for (int i = 0; i < d; i++ )
            {
                if (days[i] == str.Length)
                    continue;
                length = ((str.Length - days[i]) - (days[i] - 1)) + 1;
                var rev = str.Substring(days[i] - 1, length);
                rev.Reverse();
                str = str.Replace(str.Substring(days[i] - 1,length),rev);
            }

                Console.WriteLine(str);
                Console.ReadLine();

        }
    }
}
