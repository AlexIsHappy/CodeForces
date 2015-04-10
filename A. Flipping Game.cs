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
            int amount = int.Parse(Console.ReadLine());
            var numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int pol = 0;
            int crimes = 0;
            bool flag = false;

            while (numbs[numbs.Count - 1] > 0)
                numbs.RemoveAt(numbs.Count - 1);

            for (int i = 0; i < numbs.Count; i ++)
            {
                if (numbs[i] > 0)
                    pol += numbs[i];
                else if (numbs[i] < 0)
                    pol--;
            }

            Console.WriteLine(pol > 0 ? 0 : Math.Abs(pol));
                Console.ReadLine();

        }
    }
}
