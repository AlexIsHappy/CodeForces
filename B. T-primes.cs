using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                double result = 0;
                for (int j = 0; j < i; j++)
                {
                   result += Math.Pow(j,i);
                   Console.Write(result);
                   Console.Write(" ");
                }
                Console.WriteLine(result % 5);
            }

            Console.ReadLine();
        }
    }
}
