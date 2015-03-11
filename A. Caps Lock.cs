using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int currentMax = 0;
            int max = 0;
            String currentUser = "";
            String lastUser = "";

            for (int i = 0; i < length; i++)
            {
                String[] repost = Console.ReadLine().Split();
                currentUser = repost[2].ToLower();

                if (currentUser == lastUser)
                {
                    currentMax++;
                    if (currentMax > max)
                        max = currentMax;
                }
                else
                    currentMax = 0;

                lastUser = repost[0].ToLower();
            }

            Console.WriteLine(max + 2);
            Console.ReadLine();
        }
    }
}
