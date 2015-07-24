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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = init[0];
            var m = init[1];
            var q = init[2];

            var bears = new int[n,m];
            var scores = new int[n];

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                {
                    bears[i,j] = line[j];
                    if (line[j] == 1)
                        scores[i]++;
                }
            }

            for (int i = 0; i < q; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int x = line[0] - 1;
                int y = line[1] - 1;

                if (bears[x,y] == 1)
                {
                    bears[x, y] = 0;
                    scores[x]--;
                }
                else
                {
                    bears[x, y] = 1;
                    scores[x]++;
                }

                Console.WriteLine(scores[x]);
            }

                Console.ReadLine();
        }
    }
}
