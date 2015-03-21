using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            String line1 = Console.ReadLine().ToLower() ;
            String line2 = Console.ReadLine().ToLower();

            for (int i = 0; i < line2.Length; i++)
            {
                if (line2[i].Equals(line1[i]))
                    continue;
                else
                {
                    if (line1[i] > line2[i])
                    {
                        Console.WriteLine(1);
                        return;
                    }
                    else if (line1[i] < line2[i])
                    {
                        Console.WriteLine(-1);
                        return;
                    }
                }
            }

            Console.WriteLine(0);
            Console.ReadLine();

        }
    }
}
