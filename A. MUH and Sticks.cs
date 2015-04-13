using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var str = Console.ReadLine().Split(' ');
            int count = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                if (str[i] == "0")
                {
                    count++;
                    if (count > max)
                        max = count;
                }
                else if (str[i] == "1")
                {
                    count = 0;
                }
            }

            Console.WriteLine(str.Count(x => x == "1") + max);
            Console.ReadLine();

        }
    }
}
