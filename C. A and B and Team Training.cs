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
            var s = new string[100];

            s[0] = "zero";
            s[1] = "one";
            s[2] = "two";
            s[3] = "three";
            s[4] = "four";
            s[5] = "five";
            s[6] = "six";
            s[7] = "seven";
            s[8] = "eight";
            s[9] = "nine";
            s[10] = "ten";
            s[11] = "eleven";
            s[12] = "twelve";
            s[13] = "thirteen";
            s[14] = "fourteen";
            s[15] = "fifteen";
            s[16] = "sixteen";
            s[17] = "seventeen";
            s[18] = "eighteen";
            s[19] = "nineteen";
            s[20] = "twenty";
            s[30] = "thirty";
            s[40] = "forty";
            s[50] = "fifty";
            s[60] = "sixty";
            s[70] = "seventy";
            s[80] = "eighty";
            s[90] = "ninety";

            if (init < 20 || init % 10 == 0)
                Console.WriteLine(s[init]);
            else
                Console.WriteLine(s[init / 10 * 10] + "-" + s[init % 10]);

            Console.WriteLine();
            Console.ReadLine();
        }
      
    }
}
