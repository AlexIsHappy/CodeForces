using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var init = long.Parse(Console.ReadLine());
            var goal = long.Parse(Console.ReadLine());

            while (goal > init)
            {
                goal = goal / init;
                if (goal == init)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }

            if( goal == init)
            {
                Console.WriteLine("YES");
                return;
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
                Console.ReadLine();
        }
    }
}
