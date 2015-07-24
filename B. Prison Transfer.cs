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

            bool[] words = new bool[2];
            if (init.Contains("BA"))
               {
                   init = init.Remove(init.IndexOf("BA"), 2);
                   words[1] = true;
               }

            if (init.Contains("AB"))
                {
                    init = init.Remove(init.IndexOf("AB"),2);
                    words[0] = true;
                }

            Console.WriteLine(words.All(x => x == true) ? "YES":"NO");
            Console.ReadLine();
        }
    }
}
