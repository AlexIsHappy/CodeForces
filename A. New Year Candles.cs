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
            String[] init = Console.ReadLine().Split(' ');

            int initSocks = int.Parse(init[0]);
            int luckyDay = int.Parse(init[1]);

            int save = 0;
            int socks = initSocks;
            int count = 0;

            while (socks > 0)
            {
                if (socks % luckyDay == 0)
                    save++;

                socks--;

                if (socks == 0)
                {
                    socks += save;
                    save = 0;
                }

                count++;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
