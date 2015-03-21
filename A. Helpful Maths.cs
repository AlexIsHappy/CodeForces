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


            int n = numbers.Length;

            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0 && numbers[j] < numbers[j - 1]; j--)
                {
                    int temp = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = temp;
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
