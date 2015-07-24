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

            if (num == 3)
            {
                Console.WriteLine("2");
                Console.WriteLine("1 3");
            }
            
            if (num < 3)
            {
                Console.WriteLine("1");
                Console.WriteLine("1");
            }

            var x = (num + 1) / 2;

            var ans = new int[num];

            for (int i = 0; i < num; i++)
            {
                ans[i] = x;

                if(i % 2 > 0)
                {
                    x -= num / 2 + 1;
                }
                else
                {
                    x += num / 2;
                }
            }

            Console.WriteLine(num);
            foreach (int i in ans)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
      
    }
}
