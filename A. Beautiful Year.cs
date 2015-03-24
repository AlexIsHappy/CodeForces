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
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (Composite(i) && Composite(number - i))
                {
                    Console.WriteLine(i + " " + (number - i));
                    return;
                }
            }
        }

        public static bool Composite (int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return true;
            }
            return false;
        }
    }
}
