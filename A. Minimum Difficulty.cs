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
            var str = Console.ReadLine();

            var ans = 0;

            var keys = new int[27];

            for (int i = 0; i < (num - 1)*2;i++)
            {
                int key = char.ToUpper(str[i]) - 64;
                if (char.IsLower(str[i]))
                {
                    keys[key]++;
                }
                else
                {
                    if(keys[key] > 0)
                        keys[key]--;
                }
            }

            for (int i = 0; i < keys.Length;i++)
            {
                ans += keys[i];
            }

                Console.WriteLine(ans);
            Console.ReadLine();
        }
      
    }
}
