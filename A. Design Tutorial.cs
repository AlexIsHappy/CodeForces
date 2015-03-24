using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            String line = Console.ReadLine();
            bool[] word = new bool[5];
            char[] hello = new char[] { 'h', 'e', 'l', 'l', 'o' };
            int count = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (count == 5)
                {
                    Console.WriteLine("YES");
                    return;
                } 
                if (line[i] == hello[count])
                {
                    count++;
                }
            }

            Console.WriteLine("NO");
        }
    }
}
