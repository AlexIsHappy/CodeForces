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
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int L = 0;
            int R = 0;
            bool increasing = true;

            for (int i = 1; i < init; i++)
            {
                if (increasing == true)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        L = i - 1;
                        increasing = false;
                    }
                }
                else if (increasing == false)
                {
                    if (numbers[i] > numbers[i-1])
                    {
                        R = i - 1;
                        break;
                    }
                    else
                    {
                        R = i;
                    }
                }
            }

            numbers.Reverse(L, (R - L + 1));

                if (isSorted(numbers) == true)
                {
                    Console.WriteLine("yes");
                    Console.WriteLine((L + 1) + " " + (R + 1));
                }
                else
                {
                    Console.WriteLine("no");
                   // Console.WriteLine((L + 1) + " " + (R + 1));
                }

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
