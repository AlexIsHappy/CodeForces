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
            int init = int.Parse(Console.ReadLine());

            List<int[]> items = new List<int[]>();

            var ans = 0;

            for (int i = 0; i < init; i++)
            {
               items.Add( Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }

            for(int i = 0;  i < init;i ++)
            {
                bool[] sides = new bool[4];
                for (int j =0; j < init; j++)
                {
                    // right
                    if (items[j][0] > items[i][0] && items[j][1] == items[i][1])
                        sides[0] = true;
                    if (items[j][0] < items[i][0] && items[j][1] == items[i][1])
                        sides[1] = true;
                    if (items[j][0] == items[i][0] && items[j][1] > items[i][1])
                        sides[2] = true;
                    if (items[j][0] == items[i][0] && items[j][1] < items[i][1])
                        sides[3] = true;
                }

                ans += sides.All(x => x == true) ? 1 : 0; 
            }

            Console.WriteLine(ans);
                Console.ReadLine();
        }
    }
}
