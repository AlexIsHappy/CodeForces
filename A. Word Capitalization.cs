using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] coins = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = coins.Sum();

            //Sort first
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = i; j > 0 && coins[j] < coins[j - 1]; j--)
                {
                    int temp = coins[j - 1];
                    coins[j - 1] = coins[j];
                    coins[j] = temp;
                }
            }

            int localSum = 0;
            int numofcoins = 0;

            for (int i = 0; i < number; i++)
            {
                localSum += coins[i];

                if (localSum > sum / 2)
                {
                    numofcoins = i + 1;
                    break;
                }
                else
                {
                    numofcoins = i + 1;
                }
            }

            Console.WriteLine(numofcoins);
            Console.ReadLine();
        }
    }
}
