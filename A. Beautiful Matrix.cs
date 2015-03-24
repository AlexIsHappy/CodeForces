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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var amount = init[0];
            var iter = init[1];

            var children = Console.ReadLine();
            char[] child = children.ToArray();


            for (int i = 0; i < iter; i++)
            {
                for (int j = 1; j < children.Length; j++)
                {
                    if (child[j - 1] == 'B' && child[j] == 'G')
                    {
                        char temp = child[j - 1];
                        child[j - 1] = child[j];
                        child[j] = temp;
                        j++;
                    }
                }
            }

            children = String.Join("", child);
            Console.WriteLine(children);
                Console.ReadLine();
        }
    }
}
