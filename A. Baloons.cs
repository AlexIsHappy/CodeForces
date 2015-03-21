using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] init = Console.ReadLine().Split(' ');
            int all = int.Parse(init[0]);
            int selected = int.Parse(init[1]);
            int [] baloons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> final = new List<int>();

            int distinct = 1;
            final.Add(baloons[0]);
            for (int i = 1; i < all; i++)
            {
                if (baloons[i - 1] != baloons[i])
                {
                    distinct++;
                    final.Add(baloons[i]);
                }
            }

            while (final.Count < selected)
            {
                Random rnd = new Random();
                final.Add(baloons[rnd.Next(0, baloons.Length)]);
            }

            for (int i = 0; i < final.Count; i++)
            {
                Console.Write(final[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
