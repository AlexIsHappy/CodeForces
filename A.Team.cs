using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int problemsNum = int.Parse(Console.ReadLine());
            int[] problem = new int[problemsNum];
            int solved = 0;

            for (int i = 0; i < problemsNum; i++)
            {
                int[] votes = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int v = 0; v < 3; v++)
                {
                    problem[i] += votes[v];
                }

                if (problem[i] >= 2)
                {
                    solved++;
                }
            }

            Console.WriteLine(solved);
            Console.ReadLine();
        }
    }
}