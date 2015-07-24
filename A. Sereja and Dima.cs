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
            var init = Console.ReadLine();

            bool sub = false;
            int sum = init.Length;

            for (int i = 1; i < init.Length; i++)
            {
                if (init[i] == init[i - 1])
                {
                    sum++;
                }
            }

          Console.WriteLine((init.Length + 1) * 26 - sum);
          Console.ReadLine();
        }
      
    }
}
