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
            var init = int.Parse(Console.ReadLine());
            var line = Console.ReadLine();

            var ans = Math.Min(init, line.TakeWhile(x => x == '1').Count() + 1);

            
                Console.WriteLine(ans);
                Console.ReadLine();
        }
      
    }
}
