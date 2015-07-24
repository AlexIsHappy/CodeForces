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
            var num = int.Parse(Console.ReadLine());
            var number = Console.ReadLine();

            while (true)
            {
                bool removed = false;
                for (int i = 1; i < number.Length; i++)
                {
                    if (number[i] != number[i-1])
                    {
                        number = number.Remove(i - 1, 2);
                        removed = true;
                    }
                }

               
                if (removed == false)
                {
                    break;
                }
            }

            Console.WriteLine(number.Length);
            Console.ReadLine();
        }
      
    }
}
