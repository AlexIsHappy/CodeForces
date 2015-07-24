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
            int n = int.Parse(Console.ReadLine());
            String[] line = Console.ReadLine().Split(' ');
            int[] numbers = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                numbers[i] = int.Parse(line[i]);
            }

            if (numbers.Length == 1)
            {
                Console.WriteLine("YES");
                return;
            }

            if (numbers.Length == 2)
            {
                if (numbers[0] == numbers[1])
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i - 2] == numbers[i-1] && numbers[i - 2] == numbers[i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
            Console.ReadLine();

        }

    }
}
