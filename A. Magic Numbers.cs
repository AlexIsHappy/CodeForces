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
            var n = Console.ReadLine();
            var init = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < init.Length / 2; i++)
            {
               if (init[i] == '7' || init[i] == '4')
               {
                   sum += init[i] - '0';
               }
               else
               {
                   Console.WriteLine("NO");
                   return;
               }
            }

            for (int i = init.Length / 2; i < init.Length; i++)
            {
                if (init[i] == '7' || init[i] == '4')
                {
                    sum -= init[i] - '0';
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
                
            }

                Console.WriteLine(sum == 0 ?  "YES" : "NO");
                Console.ReadLine();
        }

    }
}
