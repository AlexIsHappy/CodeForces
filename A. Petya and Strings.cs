using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split('+').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int max = i;
                for (int j = i; j< numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        max = j;

                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != numbers.Length - 1)
                    Console.Write(numbers[i] + "+");
                else
                    Console.WriteLine(numbers[i]);
            }

                Console.ReadLine();

        }
    }
}
