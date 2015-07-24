using System;
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
            var line = Console.ReadLine();

            var ab = "AB";
            var ba = "BA";
            bool [] nonover = new bool[2]{false,false};

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i-1] == 'A' && line[i] == 'B')
                {
                    nonover[0] = true;
                    i++;
                }
                else if (line[i-1] == 'B' && line[i] == 'A')
                {
                    nonover[1] = true;
                    i++;
                }
            }

           Console.WriteLine(nonover.Any(x => x==false) ? "NO" : "YES");


            Console.ReadLine();

        }


    }
}
