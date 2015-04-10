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
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            var str = new StringBuilder();

            for (int i = 0; i < line1.Length; i++)
            {
                if (line1[i] != line2[i])
                    str.Append('1');
                else
                    str.Append('0');
            }

            Console.WriteLine(str.ToString());
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
