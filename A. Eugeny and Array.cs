using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var reverse = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != reverse[reverse.Length - i - 1])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
            Console.ReadLine();
        }
    }
}
