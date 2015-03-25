using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] initialLine = Console.ReadLine().Split();


            int n = Int32.Parse(initialLine[0]);
            int x = Int32.Parse(initialLine[1]);

            int MovieTime = 0;
            int interTime = 0;
            for (int i = 0; i < n; i++)
            {
                int [] moment = Console.ReadLine().Split().Select(int.Parse).ToArray();
                while (MovieTime + x < moment[0])
                {
                    MovieTime += x;
                }

                interTime += (moment[1] - MovieTime);
                MovieTime = moment[1];
            }

            Console.WriteLine(interTime);
            Console.ReadLine();

        }
    }
}
