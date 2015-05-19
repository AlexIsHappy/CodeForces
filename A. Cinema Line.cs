using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var money = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int c25 = 0; int c50 = 0;
            for (int i = 0; i < n; i++)
            {
                if (money[i] == 25)
                    c25++;
                else if (money[i] == 50)
                {
                   if (c25 > 0)
                   {
                       c25--;
                       c50++;
                   }
                   else
                   {
                       Console.WriteLine("NO");
                       return;
                   }
                }
                else
                {
                    if (c25 == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else if (c50 > 0)
                    {
                        c25--;
                        c50--;
                    }
                    else if (c25 >= 3)
                    {
                        c25 -= 3;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
            Console.ReadLine();
        }
    } 
}
