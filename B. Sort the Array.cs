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
            var init = int.Parse(Console.ReadLine());
            string[] lines = new string[init];
            int count = 1;

            for (int i = 0; i < init; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 1; i < init; i++)
            {
                if (lines[i][0] == lines[i - 1][1])
                    count++;
            }

                Console.WriteLine(count);
                Console.ReadLine();

        }

        public static bool isSorted (List<int> numbers)
        {
           for (int i = 1; i < numbers.Count; i ++)
           {
               if (numbers[i] < numbers[i - 1])
                   return false;
           }

           return true;
        }

    }
}
