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
                if (days[i] == 1)
                    length = str.Length - days[i] + 1;
                else
                    length = ((str.Length - days[i]) - (days[i] - 1)) + 1;

                var rev = str.Substring(days[i] - 1,length).ToCharArray();
                Array.Reverse(rev);
                str = str.Replace(str.Substring(days[i] - 1,length), new String(rev));
            }

                Console.WriteLine(str);
                Console.ReadLine();

        }
    }
}
