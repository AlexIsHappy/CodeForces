using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] board = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int area = board[0] * board[1];
            int result = 0;

            if (area%2 == 0)
            {
                result = area / 2;
            } else
            {
                result = (area - 1) / 2;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
